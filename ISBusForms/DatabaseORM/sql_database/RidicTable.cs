using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using ISBusForms.DatabaseORM.sql_database;

namespace ISBusForms.DatabaseORM.slq_database
{
    class RidicTable
    {
        public static string TABLE_NAME = "Ridic";

        public static string SQL_SELECT_ALL = "SELECT * FROM Ridic";
        public static string SQL_SELECT_ONE = "SELECT * FROM Ridic WHERE osobni_cislo = @osobni_cislo";
        public static string SQL_INSERT = "INSERT INTO Ridic(osobni_cislo, jmeno, prijmeni, bydliste, telefon) " +
                                          "VALUES(@osobni_cislo, @jmeno, @prijmeni, @bydliste, @telefon)";
        public static string SQL_UPDATE = "UPDATE Ridic SET jmeno = @jmeno, prijmeni = @prijmeni, bydliste = @bydliste, telefon = @telefon " +
                                          "WHERE osobni_cislo = @osobni_cislo";
        public static string SQL_DELETE = "DELETE FROM Ridic WHERE osobni_cislo = @osobni_cislo";
        public static string SQL_RIDIC_SPOJE = "INSERT INTO temp_spojzjed EXEC PRidicSpoje @osobni_cislo";

        public static string SQL_CREATE_TEMP_TABLE = "CREATE TABLE temp_spojzjed(id_spoje INT PRIMARY KEY, cas_odjezdu DATETIME NOT NULL, cislo_linky INT NOT NULL, FOREIGN KEY(cislo_linky) REFERENCES Linka(cislo_linky))";
        public static string SQL_DROP_TEMP_TABLE = "DROP TABLE temp_spojzjed";
        public static string SQL_SELECT_TEMP = "SELECT * FROM temp_spojzjed JOIN Linka ON temp_spojzjed.cislo_linky = Linka.cislo_linky";

        #region CRUD operace
        public static int Insert(Ridic ridic)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            AddParams(command, ridic);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Update(Ridic ridic)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            AddParams(command, ridic);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Delete(int osobni_cislo)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);
            command.Parameters.AddWithValue("@osobni_cislo", osobni_cislo);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Ridic> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Ridic> ridici = Read(reader);
            reader.Close();
            db.Close();
            return ridici;
        }
        public static Ridic SelectOne(int osobni_cislo)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@osobni_cislo", osobni_cislo);
            SqlDataReader reader = db.Select(command);

            Collection<Ridic> ridici = Read(reader);
            Ridic ridic = null;
            if (ridici.Count == 1)
            {
                ridic = ridici[0];
            }
            reader.Close();
            db.Close();
            return ridic;
        }
        #endregion

        #region Netriviální funkce
        /// <summary>
        /// 2.5. Zobrazení řidičových spojů 
        /// </summary>
        /// <param name="osobni_cislo"></param>
        /// <returns></returns>
        public static Collection<SpojZjednoduseny> RidicSpoje(int osobni_cislo)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand commandTemp = db.CreateCommand(SQL_CREATE_TEMP_TABLE);
            db.ExecuteNonQuery(commandTemp);

            SqlCommand commandExec = db.CreateCommand(SQL_RIDIC_SPOJE);
            commandExec.Parameters.AddWithValue("@osobni_cislo", osobni_cislo);
            db.ExecuteNonQuery(commandExec);

            SqlCommand command = db.CreateCommand(SQL_SELECT_TEMP);

            SqlDataReader reader = db.Select(command);

            Collection<SpojZjednoduseny> spoje = ReadSpoj(reader);
            reader.Close();

            SqlCommand commandTempDel = db.CreateCommand(SQL_DROP_TEMP_TABLE);
            db.ExecuteNonQuery(commandTempDel);

            db.Close();

            return spoje;
        }
        #endregion

        #region Pomocné funkce
        private static Collection<Ridic> Read(SqlDataReader reader)
        {
            Collection<Ridic> ridici = new Collection<Ridic>();

            while (reader.Read())
            {
                Ridic ridic = new Ridic();
                ridic.Osobni_cislo = (int)reader["osobni_cislo"];
                ridic.Jmeno = (string)reader["jmeno"];
                ridic.Prijmeni = (string)reader["prijmeni"];
                ridic.Bydliste = (string)reader["bydliste"];
                if (reader["telefon"] != DBNull.Value)
                {
                    ridic.Telefon = (string)reader["telefon"];
                }
               
                ridici.Add(ridic);
            }
            return ridici;
        }
        private static Collection<SpojZjednoduseny> ReadSpoj(SqlDataReader reader)
        {
            Collection<SpojZjednoduseny> spoje = new Collection<SpojZjednoduseny>();

            while (reader.Read())
            {
                SpojZjednoduseny spoj = new SpojZjednoduseny();
                spoj.Id_spoje = (int)reader["id_spoje"];
                spoj.Cas_odjezdu = (DateTime)reader["cas_odjezdu"];

                spoj.Linka = new Linka
                {
                    Cislo_linky = (int)reader["cislo_linky"],
                    Nazev_linky = (string)reader["nazev_trasy"]
                };
                if (reader["delka_trasy"] != DBNull.Value)
                {
                    spoj.Linka.Delka_trasy = (int)reader["delka_trasy"];
                }
                if (reader["predepsana_doba_trasy"] != DBNull.Value)
                {
                    spoj.Linka.Predepsana_doba_trasy = (int)reader["predepsana_doba_trasy"];
                }

                spoje.Add(spoj);
            }
            return spoje;
        }
        private static void AddParams(SqlCommand command, Ridic ridic)
        {
            command.Parameters.AddWithValue("@osobni_cislo", ridic.Osobni_cislo);
            command.Parameters.AddWithValue("@jmeno", ridic.Jmeno);
            command.Parameters.AddWithValue("@prijmeni", ridic.Prijmeni);
            command.Parameters.AddWithValue("@bydliste", ridic.Bydliste);
            command.Parameters.AddWithValue("@telefon", ridic.Telefon == null || ridic.Telefon == "" ? DBNull.Value : (object)ridic.Telefon);
        }
        #endregion
    }
}
