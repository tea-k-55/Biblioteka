using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace biblioteka
{
    class Statistika
    {
        public static DataTable Chart(int god, int sifra)
        {
            SqlCommand cmd = Connection.GetCommand();
            cmd.CommandText = "uspAnaliza";

            cmd.Parameters.AddWithValue("@autorID", sifra);
            cmd.Parameters.AddWithValue("@period", god);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                cmd.Connection.Open();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
