using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using ISBusForms.DatabaseORM.sql_database;

namespace ISBusForms.DatabaseORM.slq_database
{
    class Linka_ZastavkaTable
    {
        public static string TABLE_NAME = "Linka_Zastavka";
        public static string SQL_SELECT_ALL = "SELECT poradi_zastavky, relativni_cas_odjezdu, linka.cislo_linky, nazev_trasy, delka_trasy, predepsana_doba_trasy, zastavka.cislo_zastavky, nazev, tarifni_zona, ulice, ridic.osobni_cislo, jmeno, prijmeni, bydliste, telefon, linka_ridic.id_spoje, cas_odjezdu, autobus.VIN, spz, model, vyrobce, pocet_mist, stav_zastavky " +
                                              "FROM Linka_Zastavka JOIN Linka_Ridic ON Linka_Zastavka.id_spoje = Linka_Ridic.id_spoje " +
                                              "JOIN Zastavka ON Linka_Zastavka.cislo_zastavky = Zastavka.cislo_zastavky " +
                                              "JOIN Linka ON Linka_Zastavka.cislo_linky = Linka.cislo_linky " +
                                              "JOIN Ridic ON Linka_Ridic.osobni_cislo = Ridic.osobni_cislo " +
                                              "JOIN Autobus ON Linka_Ridic.VIN = Autobus.VIN";
        public static string SQL_SELECT_ONE = "SELECT poradi_zastavky, relativni_cas_odjezdu, linka.cislo_linky, nazev_trasy, delka_trasy, predepsana_doba_trasy, zastavka.cislo_zastavky, nazev, tarifni_zona, ulice, ridic.osobni_cislo, jmeno, prijmeni, bydliste, telefon, linka_ridic.id_spoje, cas_odjezdu, autobus.VIN, spz, model, vyrobce, pocet_mist, stav_zastavky " +
                                              "FROM Linka_Zastavka JOIN Linka_Ridic ON Linka_Zastavka.id_spoje = Linka_Ridic.id_spoje " +
                                              "JOIN Zastavka ON Linka_Zastavka.cislo_zastavky = Zastavka.cislo_zastavky " +
                                              "JOIN Linka ON Linka_Zastavka.cislo_linky = Linka.cislo_linky " +
                                              "JOIN Ridic ON Linka_Ridic.osobni_cislo = Ridic.osobni_cislo " +
                                              "JOIN Autobus ON Linka_Ridic.VIN = Autobus.VIN "+
                                              "WHERE linka.cislo_linky = @cislo_linky AND zastavka.cislo_zastavky = @cislo_zastavky AND linka_ridic.id_spoje = @id_spoje";
        public static string SQL_INSERT = "INSERT INTO Linka_zastavka(poradi_zastavky, relativni_cas_odjezdu, cislo_linky, cislo_zastavky, id_spoje, stav_zastavky) " +
                                          "VALUES(@poradi_zastavky, @relativni_cas_odjezdu, @cislo_linky, @cislo_zastavky, @id_spoje, @stav_zastavky)";
        public static string SQL_UPDATE = "UPDATE Linka_zastavka SET poradi_zastavky = @poradi_zastavky, relativni_cas_odjezdu = @relativni_cas_odjezdu, stav_zastavky = @stav_zastavky " +
                                          "WHERE cislo_linky = @cislo_linky AND cislo_zastavky = @cislo_zastavky AND id_spoje = @id_spoje";
        public static string SQL_DELETE = "DELETE FROM Linka_zastavka WHERE cislo_linky = @cislo_linky AND cislo_zastavky = @cislo_zastavky AND id_spoje = @id_spoje";


        #region CRUD operace
        public static int Insert(Linka_Zastavka row)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            AddParams(command, row);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Update(Linka_Zastavka row)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            AddParams(command, row);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Delete(int cislo_linky, int cislo_zastavky, int id_spoje)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);
            command.Parameters.AddWithValue("@cislo_linky", cislo_linky);
            command.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Linka_Zastavka> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Linka_Zastavka> rows = Read(reader);
            reader.Close();
            db.Close();
            return rows;
        }
        public static Linka_Zastavka SelectOne(int cislo_linky, int cislo_zastavky, int id_spoje)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@cislo_linky", cislo_linky);
            command.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            SqlDataReader reader = db.Select(command);

            Collection<Linka_Zastavka> rows = Read(reader);
            Linka_Zastavka row = null;
            if (rows.Count == 1)
            {
                row = rows[0];
            }
            reader.Close();
            db.Close();
            return row;
        }
        #endregion

        #region Pomocné funkce
        private static Collection<Linka_Zastavka> Read(SqlDataReader reader)
        {
            Collection<Linka_Zastavka> rows = new Collection<Linka_Zastavka>();

            while (reader.Read())
            {
                Linka_Zastavka row = new Linka_Zastavka();
                row.Poradi_zastavky = (int)reader["poradi_zastavky"];
                row.Relativni_cas_odjezdu = (DateTime)reader["relativni_cas_odjezdu"];

                row.Linka = new Linka
                {
                    Cislo_linky = (int)reader["cislo_linky"],
                    Nazev_linky = (string)reader["nazev_trasy"],
                };
                if (reader["delka_trasy"] != DBNull.Value)
                {
                    row.Linka.Delka_trasy = (int)reader["delka_trasy"];
                }
                if (reader["predepsana_doba_trasy"] != DBNull.Value)
                {
                    row.Linka.Predepsana_doba_trasy = (int)reader["predepsana_doba_trasy"];
                }

                row.Zastavka = new Zastavka
                {
                    Cislo_zastavky = (int)reader["cislo_zastavky"],
                    Nazev = (string)reader["nazev"],
                    Tarifni_zona = (int)reader["tarifni_zona"],
                };
                if (reader["ulice"] != DBNull.Value)
                {
                    row.Zastavka.Ulice = (string)reader["ulice"];
                }

                Ridic ridic = new Ridic
                {
                    Osobni_cislo = (int)reader["osobni_cislo"],
                    Jmeno = (string)reader["jmeno"],
                    Prijmeni = (string)reader["prijmeni"],
                    Bydliste = (string)reader["bydliste"],
                };
                if (reader["telefon"] != DBNull.Value)
                {
                    ridic.Telefon = (string)reader["telefon"];
                }

                row.Spoj = new Linka_Ridic 
                {
                    Id_spoje = (int)reader["id_spoje"],
                    Cas_odjezdu = (DateTime)reader["cas_odjezdu"],
                    Linka = row.Linka,
                    Ridic = ridic,
                    Bus = new Autobus
                    {
                        VIN = (string)reader["VIN"],
                        SPZ = (string)reader["spz"],
                        Model = (string)reader["model"],
                        Vyrobce = (string)reader["vyrobce"],
                        Pocet_mist = (int)reader["pocet_mist"]
                    }
                };
                
                row.Stav_zastavky = (string)reader["stav_zastavky"];

                rows.Add(row);
            }
            return rows;
        }
        private static void AddParams(SqlCommand command, Linka_Zastavka row)
        {
            command.Parameters.AddWithValue("@poradi_zastavky", row.Poradi_zastavky);
            command.Parameters.AddWithValue("@relativni_cas_odjezdu", row.Relativni_cas_odjezdu);
            command.Parameters.AddWithValue("@cislo_linky", row.Linka.Cislo_linky);
            command.Parameters.AddWithValue("@cislo_zastavky", row.Zastavka.Cislo_zastavky);
            command.Parameters.AddWithValue("@id_spoje", row.Spoj.Id_spoje);
            command.Parameters.AddWithValue("@stav_zastavky", row.Stav_zastavky);
        }
        #endregion
    }
}
