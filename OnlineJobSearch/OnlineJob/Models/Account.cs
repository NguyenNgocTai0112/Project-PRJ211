using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int isAdminstrator { get; set; }

    }

    public class AccountEmployer
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int isAdminstrator { get; set; }


        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string EmployerName { get; set; }
        public string Gmail { get; set; }
        public string NumberPhone { get; set; }
    }

    public class AccountUser
    {
        public int AccountID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public int isAdminstrator { get; set; }
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Gmail { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string YearOfBirth { get; set; }

    }


    public class AccountEmployerList
    {
        DBconnection db = new DBconnection();
        public List<AccountEmployer> getAccountEmployee(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT * FROM Employer JOIN Account ON Account.AcountID = Employer.AccountID";
            }
            else
            {
                sql = "SELECT * FROM Employer JOIN Account ON Account.AcountID = Employer.AccountID where AccountID=" + ID;
            }
            List<AccountEmployer> pst = new List<AccountEmployer>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            AccountEmployer tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new AccountEmployer();
                tmpPst.AccountID = Convert.ToInt32(dt.Rows[i]["AcountID"].ToString());
                tmpPst.UserName = dt.Rows[i]["Username"].ToString();
                tmpPst.PassWord = dt.Rows[i]["Password"].ToString();
                tmpPst.isAdminstrator = Convert.ToInt32(dt.Rows[i]["isAdminstrator"].ToString());

                tmpPst.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                tmpPst.Location = dt.Rows[i]["Location"].ToString();
                tmpPst.EmployerName = dt.Rows[i]["EmployerName"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.NumberPhone = dt.Rows[i]["NumberPhone"].ToString();


                pst.Add(tmpPst);
            }
            return pst;


        }


        public void DeleteAccountEmployee(int ID)
        {
            string sql = "Delete Employer Where AcountID= " + ID;
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();

        }



    }


    public class AccountUserList
    {
        DBconnection db = new DBconnection();
        public List<AccountUser> getAccountUser(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT * FROM [User] JOIN Account ON Account.AcountID = [User].AccountID";
            }
            else
            {
                sql = "SELECT * FROM [User] JOIN Account ON Account.AcountID = [User].AccountID where AccountID=" + ID;
            }
            List<AccountUser> pst = new List<AccountUser>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            AccountUser tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new AccountUser();
                tmpPst.AccountID = Convert.ToInt32(dt.Rows[i]["AcountID"].ToString());
                tmpPst.UserName = dt.Rows[i]["Username"].ToString();
                tmpPst.PassWord = dt.Rows[i]["Password"].ToString();
                tmpPst.isAdminstrator = Convert.ToInt32(dt.Rows[i]["isAdminstrator"].ToString());
                
                tmpPst.UserID = dt.Rows[i]["UserID"].ToString();
                tmpPst.Username = dt.Rows[i]["Username"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.Sex = dt.Rows[i]["Sex"].ToString();
                tmpPst.Address = dt.Rows[i]["Address"].ToString();
                tmpPst.YearOfBirth = dt.Rows[i]["YearOfBirth"].ToString();


                pst.Add(tmpPst);
            }
            return pst;


        }

        public void DeleteAccountUser(int ID)
        {
            string sql = "Delete [User] Where AcountID= " + ID;
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();

        }




    }



    public class AccountList
    {
        DBconnection db = new DBconnection();

        public List<Account> getAccount(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "Select * From Account";
            }
            else
            {
                sql = "Select * From Account where AccountID=" + ID;
            }
            List<Account> pst = new List<Account>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            Account tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tmpPst = new Account();
                tmpPst.AccountID = Convert.ToInt32(dt.Rows[i]["AcountID"].ToString());
                tmpPst.UserName = dt.Rows[i]["Username"].ToString();
                tmpPst.PassWord = dt.Rows[i]["Password"].ToString();
                tmpPst.isAdminstrator = Convert.ToInt32(dt.Rows[i]["isAdminstrator"].ToString());
                pst.Add(tmpPst);
            }
            return pst;


        }


        public void DeleteAccount(int ID)
        {
            string sql = "Delete Account Where AcountID= " + ID;
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();

        }



    }





}
