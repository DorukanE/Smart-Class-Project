using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimSinama
{
    public class OgretmenGiris
    {
        Database db = new Database();
        public string OgretmenkullaniciAdi_tut { get; set; }
        //Ogretmenin kullanıcı adının depolanması
        public string Ogretmensifre_tut { get; set; }
        //Öğretmenin şifresinin depolanması
        public string OgretmengirisDurumu { get; set; }
        //Giriş durumunun tutulması

        public void OgretmengirisYap(string kullaniciAdi, string sifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
                //baglantıyı kapattık.//
            }
            try
            {
                db.baglanti.Open();
                SqlCommand Ogretmengiriskomutu = new SqlCommand("SELECT kullaniciAdi FROM tbl_OgretmenGiris WHERE kullaniciAdi=@kulAdi AND sifre=@sifre", db.baglanti);
                Ogretmengiriskomutu.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                //kullanıcı adı parametresini yolladık.//
                Ogretmengiriskomutu.Parameters.AddWithValue("@sifre", sifre);
                //sifre parametresini yolladık.//
                SqlDataReader kulAdi_Oku = Ogretmengiriskomutu.ExecuteReader();
                // sql komutunu reader ile okuduk.//
                if (kulAdi_Oku.Read())
                {
                    OgretmenkullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
                    MessageBox.Show("Giriş başarılı");
                    FrmOgretmen frmOgretmen = new FrmOgretmen();
                    frmOgretmen.Show();
                    
                }
                else
                {
                    MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz.");
                }
            }
            catch { }
            finally
            {
                db.baglanti.Close();
            }


        }
    }
}

