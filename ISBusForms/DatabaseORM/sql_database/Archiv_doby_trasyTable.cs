using ISBusForms.DatabaseORM.sql_database;
using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;

namespace ISBusForms.DatabaseORM.slq_database
{
    class Archiv_doby_trasyTable
    {
        public static string TABLE_NAME = "Archiv_doby_trasy";

        public static string SQL_SELECT_ALL = "SELECT * FROM Archiv_doby_trasy JOIN Linka ON Archiv_doby_trasy.cislo_linky = Linka.cislo_linky " +
                                              "JOIN Linka_Ridic ON Archiv_doby_trasy.id_spoje = Linka_Ridic.id_spoje " +
                                              "JOIN Ridic ON Linka_ridic.osobni_cislo = Ridic.osobni_cislo " +
                                              "JOIN Autobus ON Linka_ridic.VIN = Autobus.VIN";
        public static string SQL_SELECT_ONE = "SELECT * FROM Archiv_doby_trasy JOIN Linka ON Archiv_doby_trasy.cislo_linky = Linka.cislo_linky " +
                                              "JOIN Linka_Ridic ON Archiv_doby_trasy.id_spoje = Linka_Ridic.id_spoje " +
                                              "JOIN Ridic ON Linka_ridic.osobni_cislo = Ridic.osobni_cislo " +
                                              "JOIN Autobus ON Linka_ridic.VIN = Autobus.VIN " +
                                              "WHERE datum_zmeny = @datum_zmeny";

        #region CRUD operace
        public static Collection<Archiv_doby_trasy> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Archiv_doby_trasy> archiv = Read(reader);
            reader.Close();
            db.Close();
            return archiv;
        }
        public static Archiv_doby_trasy SelectOne(DateTime datum)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@datum_zmeny", datum);
           // command.Parameters.AddWithValue("@id_spoje", id_spoje);
            SqlDataReader reader = db.Select(command);

            Collection<Archiv_doby_trasy> archiv = Read(reader);
            Archiv_doby_trasy arch = null;
            if (archiv.Count == 1)
            {
                arch = archiv[0];
            }
            reader.Close();
            db.Close();
            return arch;
        }
        #endregion

        #region Pomocné funkce
        private static Collection<Archiv_doby_trasy> Read(SqlDataReader reader)
        {
            Collection<Archiv_doby_trasy> archiv = new Collection<Archiv_doby_trasy>();

            while (reader.Read())
            {
                Archiv_doby_trasy arch = new Archiv_doby_trasy();
                arch.Realna_doba_trasy = (int)reader["realna_doba_trasy"];
                arch.Datum_zmeny = (DateTime)reader["datum_zmeny"];

                arch.Linka = new Linka
                {
                    Cislo_linky = (int)reader["cislo_linky"],
                    Nazev_linky = (string)reader["nazev_trasy"]
                };
                if (reader["delka_trasy"] != DBNull.Value)
                {
                    arch.Linka.Delka_trasy = (int)reader["delka_trasy"];
                }
                if (reader["predepsana_doba_trasy"] != DBNull.Value)
                {
                    arch.Linka.Predepsana_doba_trasy = (int)reader["predepsana_doba_trasy"];
                }

                arch.Spoj = new Linka_Ridic
                {
                    Id_spoje = (int)reader["id_spoje"],
                    Cas_odjezdu = (DateTime)reader["cas_odjezdu"],
                    Linka = arch.Linka,
                    Stav_spoje = (string)reader["stav_spoje"],
                };

                arch.Spoj.Ridic = new Ridic
                {
                    Osobni_cislo = (int)reader["osobni_cislo"],
                    Jmeno = (string)reader["jmeno"],
                    Prijmeni = (string)reader["prijmeni"],
                    Bydliste = (string)reader["bydliste"],
                };
                if (reader["telefon"] != DBNull.Value)
                {
                    arch.Spoj.Ridic.Telefon = (string)reader["telefon"];
                }

                arch.Spoj.Bus = new Autobus
                {
                    VIN = (string)reader["VIN"],
                    SPZ = (string)reader["spz"],
                    Model = (string)reader["model"],
                    Vyrobce = (string)reader["vyrobce"],
                    Pocet_mist = (int)reader["pocet_mist"]
                };
                archiv.Add(arch);
            }
            return archiv;
        }
        #endregion
    }
}
