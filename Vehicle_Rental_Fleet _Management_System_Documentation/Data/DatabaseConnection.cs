    using MySql.Data.MySqlClient;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public class DatabaseConnection
    {
        private readonly string connectionString =
             //"Server=localhost;Database=vehiclerentaldb;Uid=rental_app;Pwd=mike9146;";
             "Server=localhost;Database=vehiclerentaldb;Uid=rental_app;Pwd=dl4321;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}