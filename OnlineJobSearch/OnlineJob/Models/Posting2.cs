using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Models
{
    public class Posting2
    {


        public int PostingID { get; set; }
        public string CompanyName { get; set; }//khoa chinh
        public string CategoriesID { get; set; }//join bang category
        public float Wage { get; set; }
        
        public string Location { get; set; }
        public string ExperienceRequired { get; set; }

        public string EmployerName { get; set; }
        public string Gmail { get; set; }
        public string NumberPhone { get; set; }





    }


    public class Posting2List
    {
        DBconnection db = new DBconnection();
        public List<Posting2> getPosting2(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT * FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID";
            }
            else
            {
                sql = "SELECT * FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID where PostingID=" + ID;
            }
            List<Posting2> pst = new List<Posting2>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            Posting2 tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new Posting2();
                tmpPst.PostingID = Convert.ToInt32(dt.Rows[i]["PostingID"].ToString());

                tmpPst.CompanyName = dt.Rows[i]["CompanyName"].ToString();

                tmpPst.CategoriesID = dt.Rows[i]["CategoriesLanguage"].ToString();
                tmpPst.Wage = float.Parse(dt.Rows[i]["Wage"].ToString());
                tmpPst.ExperienceRequired = dt.Rows[i]["ExperienceRequired"].ToString();


                tmpPst.Location = dt.Rows[i]["Location"].ToString();
                tmpPst.EmployerName = dt.Rows[i]["EmployerName"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.NumberPhone = dt.Rows[i]["NumberPhone"].ToString();


                pst.Add(tmpPst);
            }
            return pst;


        }


    }







}
