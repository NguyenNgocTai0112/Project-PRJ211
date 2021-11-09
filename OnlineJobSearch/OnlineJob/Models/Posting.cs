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
        public int postingID { get; set; }
        [Required(ErrorMessage ="Please Enter you Name Company:")]
        [Display(Name ="CompanyName:")]
        public string CompanyName { get; set;}
        [Required(ErrorMessage = "Please Enter CategoriesID:")]
        [Display(Name = "CategoriesID:")]
        public int CategoriesID { get; set; }
        [Required(ErrorMessage = "Please Enter Wage:")]
        [Display(Name = "Wage:")]
        public float Wage { get; set; }
        [Required(ErrorMessage = "Please Enter ExperienceRequired")]
        [Display(Name = "ExperiecnceRequired:")]
        public string ExperienceRequired { get; set; }
        [Required(ErrorMessage = "Please Enter Location")]
        [Display(Name = "Location:")]
        public string Location { get; set;}
    }
    class PostingList
    {
        DBconnection db;

        public PostingList()
        {
            db = new DBconnection(); 
        }
        public List<Posting> getPosting(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            
                sql = "Select * From Posting";

            else 
            
                sql = "Select * From Posting where postingID=" + ID; 
            
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
            for(int i=0; i < dt.Rows.Count; i++)
            {
                tmpPst = new Posting() ;
                tmpPst.postingID = Convert.ToInt32(dt.Rows[i]["postingID"].ToString());
                tmpPst.CompanyName = dt.Rows[i]["CompanyName"].ToString();
                tmpPst.CategoriesID = Convert.ToInt32(dt.Rows[i]["CategoriesID"].ToString());
                tmpPst.Wage = float.Parse(dt.Rows[i]["Wage"].ToString());
                tmpPst.ExperienceRequired = dt.Rows[i]["Experience required"].ToString();
                tmpPst.Location = dt.Rows[i]["Location"].ToString();
                pst.Add(tmpPst);
            }
            
            return pst ;


        }

        public void AddPosting(Posting pst)
        {
            string sql = "Insert into Posting([CompanyName] ,[CategoriesID],[Wage],[Experience required],[Location]) " +
                "Values('"+pst.CompanyName+"',"+pst.CategoriesID+","+pst.Wage+",'"+pst.ExperienceRequired+"','"+pst.Location+"')";
            String sqlConnectString = db.GetConnectionString();
            var connection = new SqlConnection(sqlConnectString);
            SqlCommand cmd = new SqlCommand(sql, connection); 
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close(); 
            
        }
        public void DeletePosting(Posting pst)
        {
            string sql = "Delete Posting Where postingID= "+ pst.postingID;
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
