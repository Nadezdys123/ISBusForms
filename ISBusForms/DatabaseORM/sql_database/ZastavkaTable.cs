using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using ISBusForms.DatabaseORM.sql_database;

namespace ISBusForms.DatabaseORM.slq_database
{
    class ZastavkaTable
    {
        public static string TABLE_NAME = "Zastavka";

        public static string SQL_SELECT_ALL = "SELECT * FROM Zastavka";
        public static string SQL_SELECT_ONE = "SELECT * FROM Zastavka WHERE cislo_zastavky = @cislo_zastavky";
        public static string SQL_INSERT = "INSERT INTO Zastavka(cislo_zastavky, nazev, ulice, tarifni_zona) " +
                                          "VALUES(@cislo_zastavky, @nazev, @ulice, @tarifni_zona)";
        public static string SQL_UPDATE = "UPDATE Zastavka SET nazev = @nazev, ulice = @ulice, tarifni_zona = @tarifni_zona " +
                                          "WHERE cislo_zastavky = @cislo_zastavky";
        public static string SQL_DELETE = "DELETE FROM Zastavka WHERE cislo_zastavky = @cislo_zastavky";
        public static string SQL_PRISTI_ZASTAVKA = "EXEC PPristiZastavka @id_spoje";

        #region CRUD operace
        public static int Insert(Zastavka zast)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            AddParams(command, zast);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Update(Zastavka zast)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            AddParams(command, zast);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Delete(int cislo_zastavky)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);
            command.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Zastavka> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Zastavka> zastavky = Read(reader);
            reader.Close();
            db.Close();
            return zastavky;
        }
        public static Zastavka SelectOne(int cislo_zastavky)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);
            SqlDataReader reader = db.Select(command);

            Collection<Zastavka> zastavky = Read(reader);
            Zastavka zast = null;
            if (zastavky.Count == 1)
            {
                zast = zastavky[0];
            }
            reader.Close();
            db.Close();
            return zast;
        }
        #endregion

        #region Netriviální funkce
        /// <summary>
        /// 4.5. Příští zastávka spoje
        /// </summary>
        /// <param name="id_spoje"></param>
        /// <returns></returns>
        public static Zastavka PristiZastavka(int id_spoje)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_PRISTI_ZASTAVKA);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            SqlDataReader reader = db.Select(command);

            Collection<Zastavka> zastavky = Read(reader);
            Zastavka zast = null;
            if (zastavky.Count == 1)
            {
                zast = zastavky[0];
            }
            reader.Close();
            db.Close();
            return zast;
        }
        #endregion

        #region Pomocné funkce
        private static Collection<Zastavka> Read(SqlDataReader reader)
        {
            Collection<Zastavka> zastavky = new Collection<Zastavka>();

            while (reader.Read())
            {
                Zastavka zast = new Zastavka();
                zast.Cislo_zastavky = (int)reader["cislo_zastavky"];
                zast.Nazev = (string)reader["nazev"];
                if (reader["ulice"] != DBNull.Value)
                {
                    zast.Ulice = (string)reader["ulice"];
                } 
                zast.Tarifni_zona = (int)reader["tarifni_zona"];

                zastavky.Add(zast);
            }
            return zastavky;
        }
        private static void AddParams(SqlCommand command, Zastavka zast)
        {
            command.Parameters.AddWithValue("@cislo_zastavky", zast.Cislo_zastavky);
            command.Parameters.AddWithValue("@nazev", zast.Nazev);
            command.Parameters.AddWithValue("@ulice", zast.Ulice == null || zast.Ulice == "" ? DBNull.Value : (object)zast.Ulice);
            command.Parameters.AddWithValue("@tarifni_zona", zast.Tarifni_zona);
        }
        #endregion
    }
}
