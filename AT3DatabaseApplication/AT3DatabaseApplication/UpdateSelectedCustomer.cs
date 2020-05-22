//Title: AT3 Database Application
//Author: Ben Szekely
//Form: UpdateSelectedCustomer
//Version: 1.0
//Language: C#

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AT3DatabaseApplication
{
    public partial class UpdateSelectedCustomer : Form
    {
        public UpdateSelectedCustomer()
        {
            InitializeComponent();
        }

        //connection to database
        static string northwindDB = "Data Source=BEN-DESKTOPPC;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection northwindConnect = new SqlConnection(northwindDB);

        //Closes the window
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Takes the values from the text boxes and uses them to update the customer table record
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE Customers SET CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, " +
                                 "Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country," +
                                 "Phone = @Phone, Fax = @Fax WHERE CustomerID = @CustomerID";

            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            using (SqlCommand sqlCommand = new SqlCommand(updateQuery, sqlConnection))
            {
                //define parameters and their values
                sqlCommand.Parameters.AddWithValue("@CustomerID", txtCustomerId.Text);
                sqlCommand.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                sqlCommand.Parameters.AddWithValue("@ContactName", txtContactName.Text);
                sqlCommand.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text);
                sqlCommand.Parameters.AddWithValue("@Address", txtAddress.Text);
                sqlCommand.Parameters.AddWithValue("@City", txtCity.Text);
                sqlCommand.Parameters.AddWithValue("@Region", txtRegion.Text);
                sqlCommand.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                sqlCommand.Parameters.AddWithValue("@Country", txtCountry.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", txtPhone.Text);
                sqlCommand.Parameters.AddWithValue("@Fax", txtFax.Text);

                //open connection, execute INSERT, close connection
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                sqlConnection.Dispose();

                MessageBox.Show("Update was successful.");
                this.Close();
            }
        }

        //Takes the variables created in Form1(which contain record data) and displays them in
        //the correct text boxes in this form(Update selected customer)
        private void UpdateSelectedCustomer_Load(object sender, EventArgs e)
        {
            txtCustomerId.Text = Form1.customerId;
            txtCompanyName.Text = Form1.companyName;
            txtContactName.Text = Form1.contactName;
            txtContactTitle.Text = Form1.contactTitle;
            txtAddress.Text = Form1.address;
            txtCity.Text = Form1.city;
            txtRegion.Text = Form1.region;
            txtPostalCode.Text = Form1.postalCode;
            txtCountry.Text = Form1.country;
            txtPhone.Text = Form1.phone;
            txtFax.Text = Form1.fax;
        }
    }
}
