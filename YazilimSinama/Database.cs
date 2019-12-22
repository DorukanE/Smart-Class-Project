using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YazilimSinama
{
    public class Database
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=.;Initial Catalog=AkilliSinif;Integrated Security=True");
        public DataTable datatbl = new DataTable();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public SqlCommand sqlkomut = new SqlCommand();
        public Database()
        {

        }

        public bool baglantiAc()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                baglanti.Close();
                return false;
            }
        }
        public bool baglantiKapat()
        {
            try
            {
                baglanti.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public DataTable VeriTablosuDondur(string sqlSorgusu)
        {
            datatbl.Clear();
            if (baglantiAc())
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sqlSorgusu;

                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);

                baglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int sorguCalistir(string sqlSorgusu)
        {
            if (baglantiAc())
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sqlSorgusu;
                int i = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return i;
            }
            return 0;
        }
    }
}
