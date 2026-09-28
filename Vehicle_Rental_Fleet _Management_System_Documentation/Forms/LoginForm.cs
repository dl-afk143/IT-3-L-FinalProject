using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            try
            {
                var db = new DatabaseConnection();
                using (var conn = db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT full_name, role FROM users " +
                                 "WHERE username = @username AND password = @password AND is_active = TRUE";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", HashPassword(password));

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        

        private static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}