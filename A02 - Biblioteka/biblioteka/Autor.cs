using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace biblioteka
{
    class Autor
    {
        public int Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Adresa { get; set; }

        public static DataTable Ucitaj()
        {
            SqlCommand cmd = Connection.GetCommand();
            cmd.CommandText = "uspAutor";

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

        public static DataTable UcitajPolja(string sifra)
        {
            SqlCommand cmd = Connection.GetCommand();
            cmd.CommandText = "uspAutorPolja";

            cmd.Parameters.AddWithValue("@autorID", sifra);

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

        public static DataTable UcitajComboBox()
        {
            SqlCommand cmd = Connection.GetCommand();
            cmd.CommandText = "uspAutorComboBox";

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

        public static bool Obrisi(string sifra)
        {
            SqlCommand cmd = Connection.GetCommand();
            cmd.CommandText = "uspObrisiAutora";

            cmd.Parameters.AddWithValue("@autorID", sifra);

            try
            {
                cmd.Connection.Open();
                int br = cmd.ExecuteNonQuery();
                if (br > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Nije doslo do brisanja");
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public static bool Dodaj(string sifra, string ime, string prezime, DateTime datumRodjenja)
        {
            SqlCommand cmd = Connection.GetCommand();
            cmd.CommandText = "uspDodajAutora";

            cmd.Parameters.AddWithValue("@autorID", sifra);
            cmd.Parameters.AddWithValue("@ime", ime);
            cmd.Parameters.AddWithValue("@prezime", prezime);
            if (datumRodjenja != DateTime.MaxValue || datumRodjenja != DateTime.MinValue)
            {
                cmd.Parameters.AddWithValue("@datumRodj", datumRodjenja);
            }

            try
            {
                cmd.Connection.Open();
                int br = cmd.ExecuteNonQuery();
                if (br > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Nije doslo do dodavanja");
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
