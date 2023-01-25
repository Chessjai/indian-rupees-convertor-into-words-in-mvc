using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

using MVC_rupees_converter.Models;

namespace MVC_rupees_converter.DAL
{
    public class CurrencyDAL
    {
        string conString = ConfigurationManager.ConnectionStrings["dbcs"].ToString();

        public bool InsertData(Currency cs)
        {

            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Insertdata";
                cmd.Parameters.AddWithValue("@Input", cs.Input);
                cmd.Parameters.AddWithValue("@Output", cs.Output);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (i > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

    }
}
