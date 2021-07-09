using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace WinFormsApp2
{
    class DatabaseConnection
    {
        public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:/Users/tquin/Documents/CS Repos/WinFormsApp2/callsystem.mdb\"";
        public static string SQLCommand = "Select * from CustomerDetails";
        public static OleDbConnection DBConnection = new OleDbConnection(DatabaseConnection.ConnectionString);
        public static OleDbDataReader DBReader;
        public static OleDbCommand DBCommand = new OleDbCommand(DatabaseConnection.SQLCommand, DatabaseConnection.DBConnection);
    }
}
