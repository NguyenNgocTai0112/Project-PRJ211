using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Models
{
    public class CV
    {   
        
        public int CVID { get; set; }

        public string UserID { get; set; }
        public string CVProfile { get; set; }




    }



    public class CVList
    {
        DBconnection db = new DBconnection();
        public List<CV> getCV(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT * FROM CV JOIN [User] ON CV.UserID= [User].UserID ";
            }
            else
            {
                sql = "SELECT * FROM CV JOIN [User] ON CV.UserID= [User].UserID where UserID=" + ID;
            }
            List<CV> pst = new List<CV>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            CV tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new CV();


                tmpPst.CVID = Convert.ToInt32(dt.Rows[i]["CVID"].ToString());

                tmpPst.UserID = dt.Rows[i]["Username"].ToString();
                tmpPst.CVProfile = dt.Rows[i]["Username"].ToString();

                pst.Add(tmpPst);
            }
            return pst;


        }


        public void DeleteCV(int ID)
        {
            string sql = "Delete CV Where CVID= " + ID;
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
