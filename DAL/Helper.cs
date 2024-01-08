using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class Helper
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = "Data Source=DESKTOP-LUBM8JD\\SQLEXPRESS;Initial Catalog=BerkeOdev;Integrated Security=True;Trust Server Certificate=True";
        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p = null)
        {
            using (cn = new SqlConnection(cstr))
            {
                using (cmd = new SqlCommand(cmdtext, cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
