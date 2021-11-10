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
        
        public string UserID { get; set; }

        public string Username { get; set; }
        public string Gmail { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string YearOfBirth { get; set; }

        public string CategoriesID { get; set; }//String join category
        public string Experience { get; set; }
        public string Certificate { get; set; }




    }



    public class CVList
    {
        DBconnection db = new DBconnection();
        public List<CV> getCV(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT * FROM CV JOIN [User] ON CV.UserID= [User].UserID join Categories on CV.CategoriesID = Categories.CategoriesID";
            }
            else
            {
                sql = "SELECT * FROM CV JOIN [User] ON CV.UserID= [User].UserID join Categories on CV.CategoriesID = Categories.CategoriesID where UserID=" + ID;
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


                tmpPst.UserID = dt.Rows[i]["UserID"].ToString();
                tmpPst.Username = dt.Rows[i]["Username"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.Sex = dt.Rows[i]["Sex"].ToString();
                tmpPst.Address = dt.Rows[i]["Address"].ToString();
                tmpPst.YearOfBirth = dt.Rows[i]["YearOfBirth"].ToString();


                tmpPst.CategoriesID = dt.Rows[i]["CategoriesLanguage"].ToString();
                tmpPst.Experience = dt.Rows[i]["Experience"].ToString();
                tmpPst.Certificate = dt.Rows[i]["Certificate"].ToString();

                pst.Add(tmpPst);
            }
            return pst;


        }


    }









}
