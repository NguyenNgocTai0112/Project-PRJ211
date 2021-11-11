using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineJob.Models
{
    public class CV2
    {
        public int CVID { get; set; }
        public string UserID { get; set; }
        public string CVProfile { get; set;  }

        public class CVList2
        {
            DBconnection db = new DBconnection();
            public List<CV2> getCV2(string ID)
            {
                string sql;
                if (string.IsNullOrEmpty(ID))
                {
                    sql = "SELECT * FROM CV ";
                }
                else
                {
                    sql = "SELECT * FROM CV  where CVID=" + ID;
                }
                List<CV2> pst = new List<CV2>();
                DataTable dt = new DataTable();
                String sqlConnectString = db.GetConnectionString();
                var connection = new SqlConnection(sqlConnectString);
                SqlDataAdapter da = new SqlDataAdapter(sql, connection);
                connection.Open();
                da.Fill(dt);
                da.Dispose();
                connection.Close();
                CV2 tmpPst;
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    tmpPst = new CV2();


                    tmpPst.CVID = Convert.ToInt32(dt.Rows[i]["CVID"].ToString());
                    tmpPst.UserID = dt.Rows[i]["UserID"].ToString();
                    tmpPst.CVProfile = dt.Rows[i]["CVProfile"].ToString();
          

                    pst.Add(tmpPst);
                }
                return pst;


            }


        }

    }
}
