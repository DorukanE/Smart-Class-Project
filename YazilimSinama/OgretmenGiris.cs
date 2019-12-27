using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimSinama
{
    class OgretmenGiris
    {
        Database db = new Database();
        public string OgretmenkullaniciAdi_tut { get; set; }
        //ogretmenin kullanıcı adını tutmak için bir nesne tanımladık.//
        public string Ogretmensifre_tut { get; set; }
        //ogretmenin şifresini tutmak için bir nesne tanımladık.//

        public string OgretmengirisDurumu { get; set; }
        //ogretmenin giriş bilgisini tutmak için bir nesne tanımladık.//


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
                //kullanıcı adı ve sifre icin bir sql komutu yazdık.//
                Ogretmengiriskomutu.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                //kullanıcı adı parametresini yolladık.//
                Ogretmengiriskomutu.Parameters.AddWithValue("@sifre", sifre);
                //sifre parametresini yolladık.//
                SqlDataReader kulAdi_Oku = Ogretmengiriskomutu.ExecuteReader();
                // sql komutunu reader ile okuduk.//
                if (kulAdi_Oku.Read())
                {
                    MessageBox.Show("Giriş başarılı");
                    FrmOgretmen frmOgretmen = new FrmOgretmen();
                    // giris basarılıysa öğretmen formuna yolladık.//
                    frmOgretmen.Show();
                    
                }
                else
                {
                    MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz.");
                    //Application.Exit();
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

