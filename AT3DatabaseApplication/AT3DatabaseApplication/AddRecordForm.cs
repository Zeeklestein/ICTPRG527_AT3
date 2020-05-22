//Title: AT3 Database Application
//Author: Ben Szekely
//Form: AddRecordForm
//Version: 1.0
//Language: C#

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AT3DatabaseApplication
{
    public partial class AddRecordForm : Form
    {
        public AddRecordForm()
        {
            InitializeComponent();
        }

        //connection to database
        static string northwindDB = "Data Source=BEN-DESKTOPPC;Initial Catalog=Northwind;Integrated Security=True";
        SqlConnection northwindConnect = new SqlConnection(northwindDB);

        //Close window button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Takes the text in the text boxes and adds a record into the Customers table
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string addRecordQuery = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, " +
                                    "City, Region, PostalCode, Country, Phone, Fax) VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, @Address, " +
                                    "@City, @Region, @PostalCode, @Country, @Phone, @Fax)";

            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            using (SqlCommand sqlCommand = new SqlCommand(addRecordQuery, sqlConnection))
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

                MessageBox.Show("Add was successful.");
                //Closes the Add record window
                this.Close();
            }
        }
    }
}
