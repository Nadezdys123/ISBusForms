using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using ISBusForms.DatabaseORM.sql_database;

namespace ISBusForms.DatabaseORM.slq_database
{
    class AutobusTable
    {
        public static string TABLE_NAME = "Autobus";

        public static string SQL_SELECT_ALL = "SELECT * FROM Autobus";
        public static string SQL_SELECT_ONE = "SELECT * FROM Autobus WHERE VIN = @VIN";
        public static string SQL_INSERT = "INSERT INTO Autobus(VIN, spz, model, vyrobce, pocet_mist) " +
                                          "VALUES(@VIN, @spz, @model, @vyrobce, @pocet_mist)";
        public static string SQL_UPDATE = "UPDATE Autobus SET spz = @spz, model = @model, vyrobce = @vyrobce, pocet_mist = @pocet_mist " +
                                          "WHERE VIN = @VIN";
        public static string SQL_DELETE = "DELETE FROM Autobus WHERE VIN = @VIN";

        #region CRUD operace
        public static int Insert(Autobus bus)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_INSERT);
            AddParams(command, bus);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Update(Autobus bus)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            AddParams(command, bus);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }
        public static int Delete(string VIN)
        {
            Database db = new Database();
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_DELETE);
            command.Parameters.AddWithValue("@VIN", VIN);
            int ret = db.ExecuteNonQuery(command);
            db.Close();
            return ret;
        }

        public static Collection<Autobus> SelectAll()
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ALL);
            SqlDataReader reader = db.Select(command);

            Collection<Autobus> busses = Read(reader);
            reader.Close();
            db.Close();
            return busses;
        }
        public static Autobus SelectOne(string VIN)
        {
            Database db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_SELECT_ONE);
            command.Parameters.AddWithValue("@VIN", VIN);
            SqlDataReader reader = db.Select(command);

            Collection<Autobus> busses = Read(reader);
            Autobus bus = null;
            if (busses.Count == 1)
            {
                bus = busses[0];
            }
            reader.Close();
            db.Close();
            return bus;
        }
        #endregion

        #region Pomocné funkce
        private static Collection<Autobus> Read(SqlDataReader reader)
        {
            Collection<Autobus> buses = new Collection<Autobus>();

            while (reader.Read())
            {
                Autobus bus = new Autobus();
                bus.SPZ = (string)reader["spz"];
                bus.Model = (string)reader["model"];
                bus.Vyrobce = (string)reader["vyrobce"];
                bus.Pocet_mist = (int)reader["pocet_mist"];
                bus.VIN = (string)reader["VIN"];

                buses.Add(bus);
            }
            return buses;
        }
        private static void AddParams(SqlCommand command, Autobus bus)
        {
            command.Parameters.AddWithValue("@VIN", bus.VIN);
            command.Parameters.AddWithValue("@spz", bus.SPZ);
            command.Parameters.AddWithValue("@model", bus.Model);
            command.Parameters.AddWithValue("@vyrobce", bus.Vyrobce);
            command.Parameters.AddWithValue("@pocet_mist", bus.Pocet_mist);
        }
        #endregion
    }
}
