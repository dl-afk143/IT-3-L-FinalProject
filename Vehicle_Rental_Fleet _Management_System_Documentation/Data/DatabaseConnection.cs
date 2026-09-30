using MySql.Data.MySqlClient;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
            "Server=localhost;Database=VehicleRentalDB;Uid=root;Pwd=mike9146;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}