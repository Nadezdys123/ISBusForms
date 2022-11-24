using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using ISBusForms.DatabaseORM.sql_database;

namespace ISBusForms.DatabaseORM.slq_database
{
    class LinkaTable
    {
        public static string TABLE_NAME = "Linka";
        public static string SQL_SELECT_ALL = "SELECT * FROM Linka";
        public static string SQL_SELECT_ONE = "SELECT * FROM Linka WHERE cislo_linky = @cislo_linky";
        public static string SQL_INSERT = "INSERT INTO Linka(cislo_linky, nazev_trasy, delka_trasy, predepsana_doba_trasy) " +
                                          "VALUES(@cislo_linky, @nazev_linky, @delka_trasy, @doba_trasy)";
        public static string SQL_UPDATE = "UPDATE Linka SET nazev_trasy = @nazev_linky, delka_trasy = @delka_trasy, predepsana_doba_trasy = @doba_trasy " +
                                          "WHERE cislo_linky = @cislo_linky";
        public static string SQL_DELETE = "DELETE FROM Linka WHERE cislo_linky = @cislo_linky";
        public static string SQL_ZMENIT_TRASU_LINKY = "EXEC PZmenitTrasuLinky @cislo_linky, @volba, @cislo_zastavky, @poradi_zastavky, @cas_odjezdu";
        public static string SQL_LINKY_PROJIZDEJICI_ZASTAVKOU = "EXEC PLinkyProjizdejiciZastavkou @cislo_zastavky";
        public static string SQL_STATISTIKA_LINEK = "INSERT INTO temp_stat EXEC PStatistikaLinek";

        public static string SQL_CREATE_TEMP_TABLE = "CREATE TABLE temp_stat(cislo_linky INT PRIMARY KEY, min_doba INT NOT NULL, max_doba INT NOT NULL, avg_doba INT NOT NULL, nejcastejsi_ridic INT NOT NULL, FOREIGN KEY(nejcastejsi_ridic) REFERENCES Ridic(osobni_cislo))";
        public static string SQL_DROP_TEMP_TABLE = "DROP TABLE temp_stat";
        public static string SQL_SELECT_TEMP = "SELECT * FROM temp_stat JOIN Ridic ON temp_stat.nejcastejsi_ridic = Ridic.osobni_cislo";

        #region CRUD operace
        public static int Insert(Linka linka)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            AddParams(command, linka);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Update(Linka linka)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            AddParams(command, linka);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Delete(int cislo_linky)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);
            command.Parameters.AddWithValue("@cislo_linky", cislo_linky);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Linka> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Linka> linky = Read(reader);
            reader.Close();
            db.Close();
            return linky;
        }
        public static Linka SelectOne(int cislo_linky)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@cislo_linky", cislo_linky);
            SqlDataReader reader = db.Select(command);

            Collection<Linka> linky = Read(reader);
            Linka linka = null;
            if (linky.Count == 1)
            {
                linka = linky[0];
            }
            reader.Close();
            db.Close();
            return linka;
        }
        #endregion

        #region Netriviální funkce
        /// <summary>
        /// 1.5. Změnit trasu linky 
        /// </summary>
        /// <param name="cislo_linky"></param>
        /// <param name="volba"></param>
        /// <param name="cislo_zastavky"></param>
        /// <returns></returns>
        public static int ZmenitTrasuLinky(int cislo_linky, int volba, int cislo_zastavky)
        {
            return ZmenitTrasuLinky(cislo_linky, volba, cislo_zastavky, -1, new DateTime(2000,1,1,0,0,0));
        }
        /// <summary>
        /// 1.5. Změnit trasu linky 
        /// </summary>
        /// <param name="cislo_linky"></param>
        /// <param name="volba"></param>
        /// <param name="cislo_zastavky"></param>
        /// <param name="poradi_zastavky"></param>
        /// <param name="cas_odjedzu"></param>
        /// <returns></returns>
        public static int ZmenitTrasuLinky(int cislo_linky, int volba, int cislo_zastavky, int poradi_zastavky, DateTime cas_odjedzu)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_ZMENIT_TRASU_LINKY);
            command.Parameters.AddWithValue("@cislo_linky", cislo_linky);
            command.Parameters.AddWithValue("@volba", volba);
            command.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);
            command.Parameters.AddWithValue("@poradi_zastavky", poradi_zastavky);
            command.Parameters.AddWithValue("@cas_odjezdu", cas_odjedzu);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        /// <summary>
        /// 1.6. Linky projíždějících danou zastávkou
        /// </summary>
        /// <param name="cislo_zastavky"></param>
        /// <returns></returns>
        public static Collection<Linka> LinkyProjizdejiciZastavkou(int cislo_zastavky)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_LINKY_PROJIZDEJICI_ZASTAVKOU);
            command.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);

            SqlDataReader reader = db.Select(command);

            Collection<Linka> linky = Read(reader);
            reader.Close();
            db.Close();

            return linky;
        }
        /// <summary>
        /// 1.7. Statistika linek 
        /// </summary>
        /// <returns></returns>
        public static Collection<StatistikaLinek> StatistikaLinek()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand commandTemp = db.CreateCommand(SQL_CREATE_TEMP_TABLE);
            db.ExecuteNonQuery(commandTemp);

           SqlCommand commandTempStat = db.CreateCommand(SQL_STATISTIKA_LINEK);
           db.ExecuteNonQuery(commandTempStat);

            SqlCommand command = db.CreateCommand(SQL_SELECT_TEMP);

            SqlDataReader reader = db.Select(command);

            Collection<StatistikaLinek> linky = ReadStatistika(reader);
            reader.Close();

            SqlCommand commandTempDel = db.CreateCommand(SQL_DROP_TEMP_TABLE);
            db.ExecuteNonQuery(commandTempDel);

            db.Close();

            return linky;
        }
        #endregion

        #region Pomocné funkce
        private static Collection<Linka> Read(SqlDataReader reader)
        {
            Collection<Linka> linky = new Collection<Linka>();

            while (reader.Read())
            {
                Linka linka = new Linka();
                linka.Cislo_linky = (int)reader["cislo_linky"];
                linka.Nazev_linky = reader["nazev_trasy"].ToString();
                if (reader["delka_trasy"] != DBNull.Value)
                {
                    linka.Delka_trasy = (int)reader["delka_trasy"];
                }
                if (reader["predepsana_doba_trasy"] != DBNull.Value)
                {
                    linka.Predepsana_doba_trasy = (int)reader["predepsana_doba_trasy"];
                }
                linky.Add(linka);
            }
            return linky;
        }
        private static Collection<StatistikaLinek> ReadStatistika(SqlDataReader reader)
        {
            Collection<StatistikaLinek> linky = new Collection<StatistikaLinek>();

            while (reader.Read())
            {
                StatistikaLinek linka = new StatistikaLinek();
                linka.Cislo_linky = (int)reader["cislo_linky"];
                linka.Min_doba_trasy = (int)reader["min_doba"];
                linka.Max_doba_trasy = (int)reader["max_doba"];
                linka.Avg_doba_trasy = (int)reader["avg_doba"];
                linka.Nejcastejsi_ridic = new Ridic 
                {
                    Osobni_cislo = (int)reader["nejcastejsi_ridic"],
                    Jmeno = (string)reader["jmeno"],
                    Prijmeni = (string)reader["prijmeni"],
                    Bydliste = (string)reader["bydliste"],
                };
                if (reader["telefon"] != DBNull.Value)
                {
                    linka.Nejcastejsi_ridic.Telefon = (string)reader["telefon"];
                }
                linky.Add(linka);
            }
            return linky;
        }
        private static void AddParams(SqlCommand command, Linka linka)
        {
            command.Parameters.AddWithValue("@cislo_linky", linka.Cislo_linky);
            command.Parameters.AddWithValue("@nazev_linky", linka.Nazev_linky);
            command.Parameters.AddWithValue("@delka_trasy", linka.Delka_trasy == null ? DBNull.Value : (object)linka.Delka_trasy);
            command.Parameters.AddWithValue("@doba_trasy", linka.Predepsana_doba_trasy == null ? DBNull.Value : (object)linka.Predepsana_doba_trasy);
        }
        #endregion
    }
}