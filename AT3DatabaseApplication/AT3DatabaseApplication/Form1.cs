//Title: AT3 Database Application
//Author: Ben Szekely
//Form: Form1 (Main)
//Version: 1.0
//Language: C#

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace AT3DatabaseApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate combo box with table names when form loads
            getDbTableNames();
            test();
        }

        //connection to database
        static string northwindDB = "Data Source=BEN-DESKTOPPC;Initial Catalog=Northwind;Integrated Security=True";

        //get table names and display them in a list for the combo box
        private void getDbTableNames()
        {
            string getTablesQuery = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'Northwind'";
            SqlDataReader rs = null;

            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            {
                using (SqlCommand command = new SqlCommand(getTablesQuery, sqlConnection))
                {
                    //Stores the database table names in a list that will be accessible by the combo box 
                    List<string> tableNames = new List<string>();
                    sqlConnection.Open();
                    rs = command.ExecuteReader();

                    //add the table names to the list
                    while(rs.Read())
                    {
                        tableNames.Add(rs["TABLE_NAME"].ToString());
                    }
                    cbxSelectTable.DataSource = tableNames;
                    sqlConnection.Close();
                    sqlConnection.Dispose();
                }
            }
        }

        //Select table and Refresh buttons to exactly the same thing. Both exist for
        //greater usability
        private void btnSelectTable_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private void test()
        {
            //should add up the numbers 1 to 4. Answer should be 10.
            int begin = 1;
            int end = 5;
            int result = 0;

            for (int number = begin; number < end; number++)
            {
                result = result + number;
                Trace.WriteLine($"Result = {result}");
            }
            MessageBox.Show($"The Answer is: {result.ToString()}");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDataGridView();
        }
        
        //Public string variables that can be accessed by the update selected customer form
        public static string customerId;
        public static string companyName;
        public static string contactName;
        public static string contactTitle;
        public static string address;
        public static string city;
        public static string region;
        public static string postalCode;
        public static string country;
        public static string phone;
        public static string fax;

        //Updates the selected row in the data grid view
        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            if(cbxSelectTable.Text == "Customers")
            {
                //Makes sure only 1 row is selected
                if(dataGridView.SelectedRows.Count == 1)
                {
                    //Gets the values from the selected row and puts them in a string variable (Accessible by
                    //update selected customer form).
                    customerId = dataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                    companyName = dataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                    contactName = dataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                    contactTitle = dataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                    address = dataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                    city = dataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                    region = dataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
                    postalCode = dataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
                    country = dataGridView.SelectedRows[0].Cells[8].Value + string.Empty;
                    phone = dataGridView.SelectedRows[0].Cells[9].Value + string.Empty;
                    fax = dataGridView.SelectedRows[0].Cells[10].Value + string.Empty;

                    UpdateSelectedCustomer updateSelectedCustomer = new UpdateSelectedCustomer();
                    updateSelectedCustomer.Show();
                }
            }
            else
            {
                MessageBox.Show("Can only update rows from the Customer table.");
            }
        }

        //Loads data from the selected table and displays it in the data grid view
        private void loadDataGridView()
        {
            //Loads the table into the DGV based on the combo box selection
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(northwindDB))
            {
                string selectTableQuery = $"SELECT * FROM {cbxSelectTable.SelectedItem}";

                using (SqlCommand command = new SqlCommand(selectTableQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        dataTable.Load(command.ExecuteReader());
                        dataGridView.DataSource = dataTable;
                    }
                    catch(SqlException)
                    {
                        MessageBox.Show("Bad Query. Incorrect syntax.");
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                        connection.Dispose();
                    }
                }
            }
        }

        //Adds record to the customer table only. Loads up the Add record form
        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            if (cbxSelectTable.Text == "Customers")
            {
                AddRecordForm addRecordForm = new AddRecordForm();
                addRecordForm.Show();
            }
            else
            {
                MessageBox.Show("Can only add rows from the Customer table.");
            }
        }

        //Deletes a selected record from the customers table only
        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM Customers WHERE CustomerID = @CUSTOMERID";
            
            //Deletes the selected record, but only if 1 record is selected.
            if (cbxSelectTable.Text == "Customers")
            {
                if(dataGridView.SelectedRows.Count == 1)
                {
                    string deleteCustomerId = dataGridView.SelectedRows[0].Cells[0].Value + string.Empty;

                    using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
                    {
                        using (SqlCommand sqlCommand = new SqlCommand(deleteQuery, sqlConnection))
                        {
                            try
                            {
                                sqlCommand.Parameters.AddWithValue("@CUSTOMERID", deleteCustomerId);
                                sqlConnection.Open();
                                sqlCommand.ExecuteNonQuery();
                                MessageBox.Show("Delete was successful.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                if (sqlConnection.State == ConnectionState.Open)
                                {
                                    sqlConnection.Close();
                                }
                                sqlConnection.Dispose();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a record to delete.");
                }
            }
            else
            {
                MessageBox.Show("Can only delete rows from the Customer table.");
            }
        }

        //Creates a table called EpicAwesomeTableOfAwesomeness
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string createTableQuery = "CREATE TABLE EpicAwesomeTableOfAwesomeness (AwesomeId INTEGER CONSTRAINT PKeyAwesomeId PRIMARY KEY, FirstName CHAR(50), " +
                                      "LastName CHAR(50), Address CHAR(255), HeadCircumference FLOAT)";

            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            {
                using (SqlCommand sqlCommand = new SqlCommand(createTableQuery, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        getDbTableNames();
                        MessageBox.Show("Table Created");
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("The table 'EpicAwesomeTableOfAwesomeness' already exists.");
                    }
                    finally
                    {
                        if (sqlConnection.State == ConnectionState.Open)
                        {
                            sqlConnection.Close();
                        }
                        sqlConnection.Dispose();
                    }
                }
                
            }
        }

        //Drops the table EpicAwesomeTableOfAwesomeness
        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            {
                string dropTableQuery = "DROP TABLE EpicAwesomeTableOfAwesomeness";

                using (SqlCommand sqlCommand = new SqlCommand(dropTableQuery, sqlConnection))
                {
                    try
                    {
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        getDbTableNames();
                        MessageBox.Show("'EpicAwesomeTableOfAwesomeness' Dropped");

                        //Clears the data grid view. Set to null if bound to a data source.
                        dataGridView.DataSource = null;
                        dataGridView.Rows.Clear();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Table doesn't exist.");
                    }
                    finally
                    {
                        if (sqlConnection.State == ConnectionState.Open)
                        {
                            sqlConnection.Close();
                        }
                        sqlConnection.Dispose();
                    }
                }
            }
        }

        //Copies the EpicAwesomeTableOfAwesomeness table into the table EpicTableBackupOfDoom
        private void btnCopyTable_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            {
                string copyQuery = "SELECT * INTO EpicTableBackupOfDoom FROM EpicAwesomeTableOfAwesomeness";
                SqlCommand sqlCommand = new SqlCommand(copyQuery, sqlConnection);
                try
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    getDbTableNames();
                    MessageBox.Show("Table copied to EpicTableBackupOfDoom");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Copy failed. EpicAwesomeTableOfAwesomeness doesn't exist.");
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                    sqlConnection.Dispose();
                }
            }
        }

        //Shows table information based on the selected table in the combo box
        private void btnQueryTableDefinition_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(northwindDB))
            {
                string selectTableQuery = $"exec sp_columns {cbxSelectTable.Text}";

                using (SqlCommand command = new SqlCommand(selectTableQuery, connection))
                {
                    connection.Open();
                    dataTable.Load(command.ExecuteReader());
                    dataGridView.DataSource = dataTable;

                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection.Dispose();
                }
            }
        }

        //An example of an SQL transaction
        private void btnTransaction_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(northwindDB))
            {
                try
                {
                    sqlConnection.Open();
                    //Begin Transaction
                    SqlCommand command = new SqlCommand("BEGIN TRANSACTION", sqlConnection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("INSERT INTO Customers (CustomerID, CompanyName, ContactName) VALUES ('GCEI', 'Gelantinous Cube Exterminators Inc', 'Two-Hands Dan')", sqlConnection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("UPDATE Customers SET ContactName = 'One-Hand Dan' WHERE CustomerID = 'GCEI'", sqlConnection);
                    command.ExecuteNonQuery();
                    //Save Transaction
                    command = new SqlCommand("SAVE TRANSACTION GCEIUpdateTransacion", sqlConnection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("UPDATE Customers SET ContactName = 'No-Hands Dan' WHERE CustomerID = 'GCEI'", sqlConnection);
                    command.ExecuteNonQuery();
                    //Rollback Transaction
                    command = new SqlCommand("ROLLBACK TRANSACTION GCEIUpdateTransacion", sqlConnection);
                    command.ExecuteNonQuery();
                    //Commit Transaction
                    command = new SqlCommand("COMMIT TRANSACTION", sqlConnection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Transaction Successful");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Transaction failed");
                }
                finally
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                    sqlConnection.Dispose();
                }
            }
        }
    }
}
