using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Models
{
    public class ViewProfile
    {
        public int CVID { get; set; }
        public string UserID { get; set; }
        public string CVProfile { get; set;  }

        public string Username { get; set; }

        public string Gmail { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string YearOfBirth { get; set; }
    


        public class ViewListProfile
        {
            DBconnection db = new DBconnection();
            public List<ViewProfile> GetProfile(string ID)
            {
                string sql;
                if (string.IsNullOrEmpty(ID))
                {
                    sql = "SELECT CV.CVID , CV.UserID , CV.CVProfile , [User].Username , [User].Gmail ,[User].Sex,[User].[Address],[User].YearOfBirth    FROM [dbo].[CV] JOIN [User] ON [CV].UserID=[User].UserID  ";
                }
                else
                {
                    sql = "SELECT CV.CVID , CV.UserID , CV.CVProfile , [User].Username , [User].Gmail ,[User].Sex,[User].[Address],[User].YearOfBirth    FROM [dbo].[CV] JOIN [User] ON [CV].UserID=[User].UserID where CVID=" + ID;
                }
                List<ViewProfile> pst = new List<ViewProfile>();
                DataTable dt = new DataTable();
                String sqlConnectString = db.GetConnectionString();
                var connection = new SqlConnection(sqlConnectString);
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                connection.Open();
                da.Fill(dt);
                da.Dispose();
                connection.Close();
                ViewProfile tmpPst;
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    tmpPst = new ViewProfile();


                    tmpPst.CVID = Convert.ToInt32(dt.Rows[i]["CVID"].ToString());
                    tmpPst.UserID = dt.Rows[i]["UserID"].ToString();
                    tmpPst.CVProfile = dt.Rows[i]["CVProfile"].ToString();
                    tmpPst.Username = dt.Rows[i]["Username"].ToString();
                    tmpPst.Gmail = dt.Rows[i]["Gmail"].ToString();
                    tmpPst.Sex = dt.Rows[i]["Sex"].ToString();
                    tmpPst.Address = dt.Rows[i]["Address"].ToString();
                    tmpPst.YearOfBirth = dt.Rows[i]["YearOfBirth"].ToString();


                    pst.Add(tmpPst);
                }
                return pst;


            }


        }

    }
}
