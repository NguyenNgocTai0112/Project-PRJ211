using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Models
{
    public class Posting
    {
        [Required(ErrorMessage ="Please Enter your PostingID")]
        [Display(Name = "PostingID:")]
        public int PostingID { get; set; }
        [Required(ErrorMessage ="Please Enter your Name Company:")]
        [Display(Name ="CompanyName:")]
        public string CompanyName { get; set;}
        [Required(ErrorMessage = "Please Enter CategoriesID:")]
        [Display(Name = "CategoriesID:")]  
        public string CategoriesID { get; set; }
        [Required(ErrorMessage = "Please Enter Wage:")]
        [Display(Name = "Wage:")]
        public float Wage { get; set; }
        [Required(ErrorMessage = "Please Enter Location:")]
        [Display(Name = "Location:")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please Enter ExperienceRequired")]
        [Display(Name = "ExperiecnceRequired:")]
        public string ExperienceRequired { get; set; }
          public int CVID { get; set; }
        public string CategoriesName { get; set; }
      
        
        public string EmployerName { get; set; }
        public string Gmail { get; set; }
        public string NumberPhone { get; set; }
        public string Logo { get; set; }

    }
    class PostingList
    {
        private DBconnection db;

        public PostingList()
        {
            db = new DBconnection();
        }
        public List<Posting> GetPosting(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT Posting.PostingID,Posting.CompanyName,Categories.CategoriesLanguage ,Posting.Wage,Posting.Location,Posting.ExperienceRequired,Employer.EmployerName,Employer.Gmail,Employer.NumberPhone FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID";
            }
            else
            {
                sql = "SELECT  * FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID where PostingID=" + ID;
            }
            List<Posting> pst = new List<Posting>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            Posting tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new Posting();
                tmpPst.PostingID = Convert.ToInt32(dt.Rows[i]["PostingID"].ToString());
                tmpPst.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                tmpPst.CategoriesName = dt.Rows[i]["CategoriesLanguage"].ToString();
                tmpPst.Wage = float.Parse(dt.Rows[i]["Wage"].ToString());
                tmpPst.Location = dt.Rows[i]["Location"].ToString();
                tmpPst.ExperienceRequired = dt.Rows[i]["ExperienceRequired"].ToString();
                tmpPst.EmployerName = dt.Rows[i]["EmployerName"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.NumberPhone = dt.Rows[i]["NumberPhone"].ToString();


                pst.Add(tmpPst);
            }
            return pst;


        }
        public List<Posting> GetPostingbyWage(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT TOP 8 Posting.PostingID,Posting.CompanyName,Categories.CategoriesLanguage ,Posting.Wage,Posting.Location,Posting.ExperienceRequired,Employer.EmployerName,Employer.Gmail,Employer.NumberPhone,Employer.Logo FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID ORDER BY Posting.Wage DESC";
            }
            else
            {
                sql = "SELECT  * FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID where PostingID=" + ID;
            }
            List<Posting> pst = new List<Posting>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            Posting tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new Posting();
                tmpPst.PostingID = Convert.ToInt32(dt.Rows[i]["PostingID"].ToString());
                tmpPst.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                tmpPst.CategoriesName = dt.Rows[i]["CategoriesLanguage"].ToString();
                tmpPst.Wage = float.Parse(dt.Rows[i]["Wage"].ToString());
                tmpPst.Location = dt.Rows[i]["Location"].ToString();
                tmpPst.ExperienceRequired = dt.Rows[i]["ExperienceRequired"].ToString();
                tmpPst.EmployerName = dt.Rows[i]["EmployerName"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.NumberPhone = dt.Rows[i]["NumberPhone"].ToString();
                tmpPst.Logo = dt.Rows[i]["Logo"].ToString();


                pst.Add(tmpPst);
            }
            return pst;


        }
        public List<Posting> GetPostingEdit(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "SELECT Posting.PostingID,Posting.CompanyName,Categories.CategoriesLanguage ,Categories.CategoriesID,Posting.Wage,Posting.Location,Posting.ExperienceRequired,Employer.EmployerName,Employer.Gmail,Employer.NumberPhone FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID";
            }
            else
            {
                sql = "SELECT Posting.PostingID,Posting.CompanyName,Categories.CategoriesLanguage ,Categories.CategoriesID,Posting.Wage,Posting.Location,Posting.ExperienceRequired,Employer.EmployerName,Employer.Gmail,Employer.NumberPhone  FROM Posting JOIN Employer ON Posting.CompanyName= Employer.CompanyName join Categories on Posting.CategoriesID = Categories.CategoriesID where PostingID=" + ID;
            }
            List<Posting> pst = new List<Posting>();
            DataTable dt = new DataTable();
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            connection.Open();
            da.Fill(dt);
            da.Dispose();
            connection.Close();
            Posting tmpPst;
            for (int i = 0; i < dt.Rows.Count; i++)
            {


                tmpPst = new Posting();
                tmpPst.PostingID = Convert.ToInt32(dt.Rows[i]["PostingID"].ToString());
                tmpPst.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                tmpPst.CategoriesName = dt.Rows[i]["CategoriesLanguage"].ToString();
                tmpPst.CategoriesID = dt.Rows[i]["CategoriesID"].ToString();
                tmpPst.Wage = float.Parse(dt.Rows[i]["Wage"].ToString());
                tmpPst.Location = dt.Rows[i]["Location"].ToString();
                tmpPst.ExperienceRequired = dt.Rows[i]["ExperienceRequired"].ToString();
                tmpPst.EmployerName = dt.Rows[i]["EmployerName"].ToString();
                tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                tmpPst.NumberPhone = dt.Rows[i]["NumberPhone"].ToString();
                pst.Add(tmpPst);
            }
            return pst;


        }


        public void AddPosting(Posting pst)
        {
            string sql = "Insert into Posting([CompanyName] ,[CategoriesID],[Wage],[Location],[ExperienceRequired]) " +
                "Values('" + pst.CompanyName + "'," + pst.CategoriesID + "," + pst.Wage + ",'" + pst.Location + "','" + pst.ExperienceRequired + "')";
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();

        }
        public void DeletePosting(int ID)
        {
            string sql = "Delete Posting Where PostingID= " + ID;
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlCommand cmd = new SqlCommand(sql, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();

        }
        public void UpdatePosting(Posting pst)
        {
            string sql = "Update Posting SET CategoriesID='" + pst.CategoriesID + "' ,Wage='" + pst.Wage + "',ExperienceRequired='" + pst.ExperienceRequired + "' Where PostingID = " + pst.PostingID;
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
