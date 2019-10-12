using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ToDo
{
    class Database
    {
        SqlConnection connection = new SqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public Database()
        {
            string connectionAddress = "Server=localhost;Database=ToDo;User Id=sa;Password=Prima123Vera2;connection timeout=5;";
            connection.ConnectionString = connectionAddress;
        }
        public void connect()
        {
            connection.Open();
        }
        public Boolean checkSignupEmail(string userEmailForSignup)
        {
            string querry = "SELECT email FROM Users WHERE email='"+userEmailForSignup+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                return false;
            }
            return true;
        }
        public Boolean validationUser(Users user)
        {
            string querry = "SELECT userID,email,pass FROM Users WHERE email='" + user.email+ "' and pass='"+user.pass+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count == 1)
            {
                int userID = Convert.ToInt32(dataTable.Rows[0][0]);
                UserID.Default.userID = userID;
                return true;
            }
            return false;
        }
        public DataTable getTaskFromDatabase(string table)
        {
            string querry = "SELECT textTask FROM "+table+" WHERE userID ='" + UserID.Default.userID + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(querry, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public void insert(Users user)
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Users(firstName,lastName,email,pass) VALUES('" + user.name + "','" + user.surname + "','" + user.email + "','" + user.pass.ToString() + "')", connection);
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                
            }
        }
        public void close()
        {
            connection.Close();
        }

        public void insertTask(string taskDescription, string tableName)
        {
            try
            {
                connect();
                cmd = new SqlCommand("INSERT INTO "+tableName+"(userID,textTask) VALUES('" + UserID.Default.userID + "','" + taskDescription + "')", connection);
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {

            }
        }
    }
}
