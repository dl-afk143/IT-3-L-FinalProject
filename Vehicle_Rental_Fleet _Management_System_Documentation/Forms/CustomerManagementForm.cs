using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehicle_Rental_Fleet__Management_System_Documentation.Form2;

namespace Vehicle_Rental_Fleet__Management_System_Documentation
{
    public partial class CustomerManagementForm : Form
    {
        private void LoadCustomers()
        {
            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT
                    customer_id,
                    first_name,
                    last_name,
                    phone,
                    email,
                    license_number,
                    address,
                    created_at
                FROM customers
                ORDER BY customer_id DESC";

                    using (MySqlDataAdapter adapter =
                           new MySqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvCustomerManagement.AutoGenerateColumns = false;

                        dgvCustomerManagement.Columns["VehicleCustomerID"].DataPropertyName = "customer_id";
                        dgvCustomerManagement.Columns["VehicleFirstName"].DataPropertyName = "first_name";
                        dgvCustomerManagement.Columns["VehicleLastName"].DataPropertyName = "last_name";
                        dgvCustomerManagement.Columns["VehicleContactNumber"].DataPropertyName = "phone";
                        dgvCustomerManagement.Columns["VehicleEmail"].DataPropertyName = "email";
                        dgvCustomerManagement.Columns["VehicleLicenseNumber"].DataPropertyName = "license_number";
                        dgvCustomerManagement.Columns["VehicleAddress"].DataPropertyName = "address";
                        dgvCustomerManagement.Columns["VehicleDateCreated"].DataPropertyName = "created_at";

                        dgvCustomerManagement.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load customers:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private readonly DatabaseConnection db = new DatabaseConnection();

        public CustomerManagementForm()
        {
            InitializeComponent();
            LoadCustomers();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();
            form1Form.Show();

            this.Hide();
        }

        // If I click the Vehicles button, open the Form2Vehicles form
        private void btnVehicles_Click(object sender, EventArgs e)
        {
            Form2Vehicles form2VehiclesForm = new Form2Vehicles();
            form2VehiclesForm.Show();

            this.Hide();
        }


        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            CustomerManagementForm customerManagementForm = new CustomerManagementForm();
            customerManagementForm.Show();

            this.Hide();
        }


        // If I click the Rentals button, open the Form3RentalManagement form
        private void btnRentals_Click(object sender, EventArgs e)
        {
            Form3RentalManagement form3RentalManagementForm = new Form3RentalManagement();
            form3RentalManagementForm.Show();

            this.Hide();
        }

        // If I click the Returns button, open the Form4ReturnManagement form
        private void btnReturns_Click(object sender, EventArgs e)
        {
            Form4ReturnManagement form4ReturnManagementForm = new Form4ReturnManagement();
            form4ReturnManagementForm.Show();

            this.Hide();
        }

        // If I click the Reports button, open the Form5Reports form
        private void btnReports_Click(object sender, EventArgs e)
        {
            Form5Reports form5ReportsForm = new Form5Reports();
            form5ReportsForm.Show();

            this.Hide();
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            // Get customer information
            string firstName = tbFirstName.Text.Trim();
            string lastName = tbLastName.Text.Trim();
            string contactNumber = tbContactNumber.Text.Trim();
            string email = tbEmail.Text.Trim();
            string licenseNumber = tbLicenseNumber.Text.Trim();
            string address = tbAddress.Text.Trim();

            // Validate required fields
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(licenseNumber) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show(
                    "Please fill in the first name, last name, contact number, license number, and address.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validate Philippine mobile number
            // Accepted: 09123456789 or 0912-345-6789
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                    contactNumber,
                    @"^(09\d{9}|09\d-\d{3}-\d{4})$"))
            {
                MessageBox.Show(
                    "Invalid contact number. Use 09123456789 or 0912-345-6789.",
                    "Invalid Contact Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tbContactNumber.Focus();
                return;
            }

            // Normalize contact number before saving
            string normalizedNumber = contactNumber.Replace("-", "");

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                INSERT INTO customers
                    (first_name, last_name, phone, email, license_number, address)
                VALUES
                    (@firstName, @lastName, @phone, @email, @licenseNumber, @address)";

                    using (MySqlCommand command =
                           new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@phone", normalizedNumber);
                        command.Parameters.AddWithValue("@email",
                            string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email);
                        command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                        command.Parameters.AddWithValue("@address", address);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Customer added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear the form and refresh the customer table
                ClearCustomerFields();
                LoadCustomers();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Database error:\n\n" +
                    ex.Message +
                    "\n\nError Code: " + ex.Number +
                    "\nSQL State: " + ex.SqlState,
                    "Add Customer Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error:\n\n" + ex.Message,
                    "Add Customer Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string customerID = tbCustomerID.Text.Trim();
            string firstName = tbFirstName.Text.Trim();
            string lastName = tbLastName.Text.Trim();
            string contactNumber = tbContactNumber.Text.Trim();
            string email = tbEmail.Text.Trim();
            string licenseNumber = tbLicenseNumber.Text.Trim();
            string address = tbAddress.Text.Trim();

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(contactNumber) ||
                string.IsNullOrWhiteSpace(licenseNumber) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (!int.TryParse(customerID, out int id))
            {
                MessageBox.Show("Invalid Customer ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to update this customer?",
                "Update Customer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        string query = @"UPDATE customers
                                 SET first_name = @firstName,
                                     last_name = @lastName,
                                     phone = @phone,
                                     email = @email,
                                     license_number = @licenseNumber,
                                     address = @address
                                 WHERE customer_id = @customerID";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@firstName", firstName);
                            cmd.Parameters.AddWithValue("@lastName", lastName);
                            cmd.Parameters.AddWithValue("@phone", contactNumber);
                            cmd.Parameters.AddWithValue(
                                    "@email",
                                string.IsNullOrWhiteSpace(email)
                                ? (object)DBNull.Value
                                : email
 );
                            cmd.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@customerID", id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer updated successfully!");
                                LoadCustomers();
                                ClearCustomerFields();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No changes were made, or the customer was not found."
                                );
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Unable to update customer.\n\n" + ex.Message,
                        "Update Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string customerID = tbCustomerID.Text.Trim();

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            if (!int.TryParse(customerID, out int id))
            {
                MessageBox.Show("Invalid Customer ID.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this customer?",
                "Delete Customer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        conn.Open();

                        string query = "DELETE FROM customers WHERE customer_id = @customerID";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@customerID", id);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Customer deleted successfully!");

                                ClearCustomerFields();
                                LoadCustomers();
                            }
                            else
                            {
                                MessageBox.Show("Customer not found.");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(
                        "Unable to delete customer. They may have related records.\n\n" + ex.Message,
                        "Delete Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "An error occurred: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCustomerFields();
        }

        private void ClearCustomerFields()
        {
            tbCustomerID.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbContactNumber.Clear();
            tbEmail.Clear();
            tbLicenseNumber.Clear();
            tbAddress.Clear();
            tbDateCreated.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void dgvCustomerManagement_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvCustomerManagement.Rows[e.RowIndex];

            tbCustomerID.Text = Convert.ToString(row.Cells["VehicleCustomerID"].Value);
            tbFirstName.Text = Convert.ToString(row.Cells["VehicleFirstName"].Value);
            tbLastName.Text = Convert.ToString(row.Cells["VehicleLastName"].Value);
            tbContactNumber.Text = Convert.ToString(row.Cells["VehicleContactNumber"].Value);
            tbEmail.Text = Convert.ToString(row.Cells["VehicleEmail"].Value);
            tbLicenseNumber.Text = Convert.ToString(row.Cells["VehicleLicenseNumber"].Value);
            tbAddress.Text = Convert.ToString(row.Cells["VehicleAddress"].Value);
            tbDateCreated.Text = Convert.ToString(row.Cells["VehicleDateCreated"].Value);
        }
        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {

        }
    }
}