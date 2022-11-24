using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using ISBusForms.DatabaseORM.sql_database;

namespace ISBusForms.DatabaseORM.slq_database
{
    class Linka_RidicTable
    {
        public static string TABLE_NAME = "Linka_Ridic";
        public static string SQL_SELECT_ALL = "SELECT * FROM Linka_Ridic JOIN Ridic ON Linka_Ridic.osobni_cislo = Ridic.osobni_cislo " +
                                              "JOIN Linka ON Linka_Ridic.cislo_linky = Linka.cislo_linky "+
                                              "JOIN Autobus ON Linka_Ridic.VIN = Autobus.VIN";
        public static string SQL_SELECT_ONE = "SELECT * FROM Linka_Ridic JOIN Ridic ON Linka_Ridic.osobni_cislo = Ridic.osobni_cislo " +
                                              "JOIN Linka ON Linka_Ridic.cislo_linky = Linka.cislo_linky " +
                                              "JOIN Autobus ON Linka_Ridic.VIN = Autobus.VIN WHERE id_spoje = @id_spoje";
        public static string SQL_INSERT = "INSERT INTO Linka_Ridic(id_spoje, cas_odjezdu, cislo_linky, osobni_cislo, VIN, stav_spoje) " +
                                          "VALUES(@id_spoje, @cas_odjezdu, @cislo_linky, @osobni_cislo, @VIN, @stav_spoje)";
        public static string SQL_UPDATE = "UPDATE Linka_Ridic SET cas_odjezdu = @cas_odjezdu, cislo_linky = @cislo_linky, osobni_cislo = @osobni_cislo, VIN = @VIN, stav_spoje = @stav_spoje " +
                                          "WHERE id_spoje = @id_spoje";
        public static string SQL_DELETE = "DELETE FROM Linka_Ridic WHERE id_spoje = @id_spoje";
        public static string SQL_ZMENA_RIDICE = "EXEC PZmenaRidiceSpoje @id_spoje";
        public static string SQL_ZMENA_AUTOBUSU = "EXEC PZmenaAutobusuSpoje @id_spoje";
        public static string SQL_PRVNICH10SPOJU = "INSERT INTO temp_spoj EXEC PPrvnich10Spoju @cislo_zastavky, @cas_odjezdu";
        public static string SQL_SPOJ_MEZI_ZASTAVKAMI = "INSERT INTO temp_spoj EXEC PSpojMeziZastavky @prvni_zastavka, @druha_zastavka";

        public static string SQL_CREATE_TEMP_TABLE = "CREATE TABLE temp_spoj(id_spoje INT PRIMARY KEY, cislo_linky INT NOT NULL, relativni_cas_odjezdu DATETIME NOT NULL, FOREIGN KEY(cislo_linky) REFERENCES Linka(cislo_linky))";
        public static string SQL_DROP_TEMP_TABLE = "DROP TABLE temp_spoj";
        public static string SQL_SELECT_TEMP = "SELECT * FROM temp_spoj JOIN Linka ON temp_spoj.cislo_linky = Linka.cislo_linky";


        #region CRUD operace
        public static int Insert(Linka_Ridic spoj)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            AddParams(command, spoj);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Update(Linka_Ridic spoj)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            AddParams(command, spoj);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Delete(int id_spoje)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Linka_Ridic> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Linka_Ridic> spoje = Read(reader);
            reader.Close();
            db.Close();
            return spoje;
        }
        public static Linka_Ridic SelectOne(int id_spoje)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            SqlDataReader reader = db.Select(command);

            Collection<Linka_Ridic> spoje = Read(reader);
            Linka_Ridic spoj = null;
            if (spoje.Count == 1)
            {
                spoj = spoje[0];
            }
            reader.Close();
            db.Close();
            return spoj;
        }
        #endregion

        #region Netriviální funkce
        /// <summary>
        /// Funkce 5.6. Změna řidiče u spoje
        /// </summary>
        /// <param name="id_spoje"></param>
        /// <returns></returns>
        public static int ZmenaRidice(int id_spoje)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_ZMENA_RIDICE);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        /// <summary>
        /// Funkce 5.7. Změna autobusu u spoje
        /// </summary>
        /// <param name="id_spoje"></param>
        /// <returns></returns>
        public static int ZmenaAutobusu(int id_spoje)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_ZMENA_AUTOBUSU);
            command.Parameters.AddWithValue("@id_spoje", id_spoje);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        /// <summary>
        /// 5.9. Prvních 10 spojů odjíždějících z dané zastávky v daný čas 
        /// </summary>
        /// <param name="cislo_zastavky"></param>
        /// <param name="cas"></param>
        /// <returns></returns>
        public static Collection<SpojZjednoduseny> Prvnich10Spoju(int cislo_zastavky, DateTime cas)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand commandTemp = db.CreateCommand(SQL_CREATE_TEMP_TABLE);
            db.ExecuteNonQuery(commandTemp);

            SqlCommand commandExec = db.CreateCommand(SQL_PRVNICH10SPOJU);
            commandExec.Parameters.AddWithValue("@cislo_zastavky", cislo_zastavky);
            commandExec.Parameters.AddWithValue("@cas_odjezdu", cas);
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
        /// <summary>
        /// 5.10. Spoj mezi dvěma zastávkami 
        /// </summary>
        /// <param name="prvni_zastavka"></param>
        /// <param name="druha_zastavka"></param>
        /// <returns></returns>
        public static Collection<SpojZjednoduseny> SpojMeziZastavkami(int prvni_zastavka, int druha_zastavka)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand commandTemp = db.CreateCommand(SQL_CREATE_TEMP_TABLE);
            db.ExecuteNonQuery(commandTemp);

            SqlCommand commandExec = db.CreateCommand(SQL_SPOJ_MEZI_ZASTAVKAMI);
            commandExec.Parameters.AddWithValue("@prvni_zastavka", prvni_zastavka);
            commandExec.Parameters.AddWithValue("@druha_zastavka", druha_zastavka);
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
        private static Collection<Linka_Ridic> Read(SqlDataReader reader)
        {
            Collection<Linka_Ridic> spoje = new Collection<Linka_Ridic>();

            while (reader.Read())
            {
                Linka_Ridic spoj = new Linka_Ridic();
                spoj.Id_spoje = (int)reader["id_spoje"];
                spoj.Cas_odjezdu = (DateTime)reader["cas_odjezdu"];

                spoj.Linka = new Linka
                {
                    Cislo_linky = (int)reader["cislo_linky"],
                    Nazev_linky = (string)reader["nazev_trasy"],
                };
                if (reader["delka_trasy"] != DBNull.Value)
                {
                    spoj.Linka.Delka_trasy = (int)reader["delka_trasy"];
                }
                if (reader["predepsana_doba_trasy"] != DBNull.Value)
                {
                    spoj.Linka.Predepsana_doba_trasy = (int)reader["predepsana_doba_trasy"];
                }

                spoj.Ridic = new Ridic
                {
                    Osobni_cislo = (int)reader["osobni_cislo"],
                    Jmeno = (string)reader["jmeno"],
                    Prijmeni = (string)reader["prijmeni"],
                    Bydliste = (string)reader["bydliste"],
                };
                if (reader["telefon"] != DBNull.Value)
                {
                    spoj.Ridic.Telefon = (string)reader["telefon"];
                }

                spoj.Bus = new Autobus 
                {
                    VIN = (string)reader["VIN"],
                    SPZ = (string)reader["spz"],
                    Model = (string)reader["model"],
                    Vyrobce = (string)reader["vyrobce"],
                    Pocet_mist = (int)reader["pocet_mist"]
                };

                spoj.Stav_spoje = (string)reader["stav_spoje"];

                spoje.Add(spoj);
            }
            return spoje;
        }
        private static Collection<SpojZjednoduseny> ReadSpoj(SqlDataReader reader)
        {
            Collection<SpojZjednoduseny> spoje = new Collection<SpojZjednoduseny>();

            while (reader.Read())
            {
                SpojZjednoduseny spoj = new SpojZjednoduseny();
                spoj.Id_spoje = (int)reader["id_spoje"];
                spoj.Cas_odjezdu = (DateTime)reader["relativni_cas_odjezdu"];
                
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
        private static void AddParams(SqlCommand command, Linka_Ridic spoj)
        {
            command.Parameters.AddWithValue("@id_spoje", spoj.Id_spoje);
            command.Parameters.AddWithValue("@cas_odjezdu", spoj.Cas_odjezdu);
            command.Parameters.AddWithValue("@cislo_linky", spoj.Linka.Cislo_linky);
            command.Parameters.AddWithValue("@osobni_cislo", spoj.Ridic.Osobni_cislo);
            command.Parameters.AddWithValue("@VIN", spoj.Bus.VIN);
            command.Parameters.AddWithValue("@stav_spoje", spoj.Stav_spoje);
        }
        #endregion
    }
}
