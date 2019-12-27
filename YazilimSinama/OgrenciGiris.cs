using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimSinama
{
    public class OgrenciGiris
    {
            Database db = new Database();
            // database sınıfımızı çağırdık.//
            public string kullaniciAdi_tut { get; set; }
            //ogrencinin kullanıcı adını tutmak için bir nesne tanımladık.//
            public string sifre_tut { get; set; }
            //ogrencinin şifresini tutmak için bir nesne tanımladık.//

            public string girisDurumu { get; set; }
            //ogretmenin giriş bilgisini tutmak için bir nesne tanımladık.//
               public void girisYap(string kullaniciAdi, string sifre)
                {
                    if (db.baglanti.State == System.Data.ConnectionState.Open)
                    {
                        db.baglanti.Close();
                        //baglantımızı kapattık.//
                    }
                    try
                    {
                        db.baglanti.Open();
                        //baglantımızı açtık.//
                        SqlCommand giriskomutu = new SqlCommand("SELECT kullaniciAdi FROM tbl_OgrenciGiris WHERE kullaniciAdi=@kulAdi AND sifre=@sifre", db.baglanti);
                        //kullanıcı adı ve sifre icin bir sql komutu yazdık.//
                        giriskomutu.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                        //kullanıcı adı parametresini yolladık.//
                        giriskomutu.Parameters.AddWithValue("@sifre", sifre);
                        //sifre parametresini yolladık.//
                        SqlDataReader kulAdi_Oku = giriskomutu.ExecuteReader();
                        //data reader ile komutu okuduk.//
                        if (kulAdi_Oku.Read())
                        {
                         //kullanıcı adını okumaya devam ettiği sürece if kosulunu koyduk.//
                        kullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
                        MessageBox.Show("Giriş başarılı");
                        FrmOgrenci frmOgrenci = new FrmOgrenci();
                        //giriş başarılıysa ögrenci formuna geçiş yaptık.//
                        frmOgrenci.Show();
                    
                        }
                        else
                        {
                          MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz.");
                        }
                    }
                    catch{ }

                    finally
                    {
                        db.baglanti.Close();
                        //baglantımızı kapattık.//
                    }


               }
    }
}
