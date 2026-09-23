using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            try
            {
                DatabaseConnection database = new DatabaseConnection();

                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Database connection successful!",
                        "Connection Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed!\n\n" + ex.Message,
                    "Connection Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}