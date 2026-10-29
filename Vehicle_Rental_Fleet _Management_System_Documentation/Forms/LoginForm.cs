using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class LoginForm : Form
    {
        // Available after a successful login (read them from Program.cs or your main form)
        public string LoggedInFullName { get; private set; }
        public string LoggedInRole { get; private set; }

        public LoginForm()
        {
            InitializeComponent();

            // Card panel: white, on top, and a child of the form so it can overlap the green panel
            cardPanel1.CarImage = Properties.Resources.v2321_removebg_preview;
            cardPanel1.Parent = this;
            cardPanel1.BackColor = Color.White;


            // Login behavior
            txtPassword.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;          // Enter = Login
            this.CancelButton = btnCancelLogin;    // Esc = Cancel
            this.StartPosition = FormStartPosition.CenterScreen;
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
                                LoggedInFullName = reader.GetString("full_name");
                                LoggedInRole = reader.GetString("role");
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
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        // Empty handlers kept because the designer may still be wired to them.
        // If you delete them, also remove the event hookup in LoginForm.Desi   gner.cs.
        private void txtUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void lblUsername_Click(object sender, EventArgs e) { }
        private void lblPassword_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}