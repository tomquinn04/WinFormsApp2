using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBConnect();
            DBRetrieve();
            DBShowResults();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void menuStrip1_ItemClicked(object sender, EventArgs e) { }
        private void updateCustomersToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void linkToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {// shows low coupling by calling a procedure that connects to the DB and sets up the required objects
            DBConnect();
        }

        private void closeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBClose();
        }


        // ----- DB FUNCTIONS ----- //

        private void DBConnect() // does this need SQLCommand? it doesn't do anything with this param
        {// closes then reopens the database connection
            try
            {
                DatabaseConnection.DBConnection.Close(); // in case the DB is already open, closes first
                DatabaseConnection.DBConnection.Open();
                UpdateDBStatusBar("Connected");
            }
            catch (Exception Exception1)
            {
                UpdateDBStatusBar("Disconnected");
                UpdateDebugStatusBar("DB Disconnect Failed");
                MessageBox.Show("Error: " + Exception1.ToString());
            }
        }

        private void DBClose()
        {
            try
            {
                DatabaseConnection.DBConnection.Close();
                UpdateDBStatusBar("Disconnected");
            }
            catch (Exception Exception1)
            {
                UpdateDBStatusBar("?");
                UpdateDebugStatusBar("DB Disconnect Failed");
                MessageBox.Show("Error: " + Exception1.ToString());
            }
        }

        private static void DBAddRecord()
        {// adds a record with filler data. todo: auto increment cust number
            try
            {
                DatabaseConnection.DBConnection.Close();
                // set commands for execution
                DatabaseConnection.SQLCommand = "INSERT INTO CustomerDetails(CUST_NUM, CUSTOMER_NAME, CUSTOMER_ADDRESS) VALUES ('999, 'New Customer', 'New Address')";
                DatabaseConnection.DBCommand = new OleDbCommand(DatabaseConnection.SQLCommand, DatabaseConnection.DBConnection);
                // execute commands
                DatabaseConnection.DBConnection.Open();
                DatabaseConnection.DBCommand.ExecuteNonQuery();
                MessageBox.Show("Record 999 added successfully");
            }
            catch (Exception Exception1)
            {
                MessageBox.Show("Record add FAILED");
                MessageBox.Show("Error: " + Exception1.ToString());
            }
        }

        private void DBDeleteRecord()
        {
            try
            {
                DatabaseConnection.DBConnection.Close();
                // set commands for execution
                DatabaseConnection.SQLCommand = "DELETE FROM CustomerDetails WHERE CUST_NUM = 999";
                DatabaseConnection.DBCommand = new OleDbCommand(DatabaseConnection.SQLCommand, DatabaseConnection.DBConnection);
                // execute commands
                DatabaseConnection.DBConnection.Open();
                DatabaseConnection.DBCommand.ExecuteNonQuery();
                UpdateDebugStatusBar("Record 999 deleted successfully");
            }
            catch (Exception Exception1)
            {
                MessageBox.Show("Record delete FAILED");
                MessageBox.Show("Error: " + Exception1.ToString());
            }
        }

        private void DBRetrieve()
        {
            try
            {
                //DatabaseConnection.DBConnection.Close(); redundant
                DBConnect();
                DatabaseConnection.DBReader = DatabaseConnection.DBCommand.ExecuteReader();
                UpdateDebugStatusBar("DB Retrieve successful");
            }
            catch (Exception Exception1)
            {
                MessageBox.Show("DB Retrieve FAILED");
                MessageBox.Show("Error: " + Exception1.ToString());
            }
        }

        private void DBShowResults()
        {
            DBRetrieve();
            listBox1.Items.Clear();
            while (DatabaseConnection.DBReader.Read())
            {
                listBox1.Items.Add(DatabaseConnection.DBReader[0].ToString() + ": " + DatabaseConnection.DBReader[1].ToString() + DatabaseConnection.DBReader[2].ToString());
            }
            UpdateDebugStatusBar("Results shown in listBox1");
        }

        private void UpdateDBStatusBar(string status)
        {
            statusBarDBStatus.Text = "DB Status: " + status;
        }

        private void UpdateDebugStatusBar(string status)
        {
            statusBarDebugLine.Text = DateTime.Now.ToString("hh:mm:ss") + " " + status;
        }

        private void displayAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBRetrieve();
            DBShowResults();
        }
    }
}
