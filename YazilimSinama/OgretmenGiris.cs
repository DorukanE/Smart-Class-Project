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
        public string Ogretmensifre_tut { get; set; }

        public string OgretmengirisDurumu { get; set; }


        public void OgretmengirisYap(string kullaniciAdi, string sifre)
        {
            if (db.baglanti.State == System.Data.ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand Ogretmengiriskomutu = new SqlCommand("SELECT kullaniciAdi FROM tbl_OgretmenGiris WHERE kullaniciAdi=@kulAdi AND sifre=@sifre", db.baglanti);
                Ogretmengiriskomutu.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                Ogretmengiriskomutu.Parameters.AddWithValue("@sifre", sifre);
                SqlDataReader kulAdi_Oku = Ogretmengiriskomutu.ExecuteReader();
                if (kulAdi_Oku.Read())
                {
                    MessageBox.Show("Giriş başarılı");
                    FrmOgretmen frmOgretmen = new FrmOgretmen();
                    frmOgretmen.Show();
                    /*OgretmenkullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
                    SqlCommand Ogretmengiriskomutupw = new SqlCommand("SELECT sifre FROM tbl_OgretmenGiris WHERE sifre=@sifre ", db.baglanti);
                    Ogretmengiriskomutupw.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader Ogretmengiriskomutupw_oku = Ogretmengiriskomutupw.ExecuteReader();

                    if (Ogretmengiriskomutupw_oku.Read())
                    {
                        Ogretmensifre_tut = Ogretmengiriskomutupw_oku["sifre"].ToString();
                        OgretmengirisDurumu = OgretmenkullaniciAdi_tut + " " + Ogretmensifre_tut;
                    }
                    else
                    {
                        MessageBox.Show("Kullanici Adini Yanlis Girdiniz!");
                        Application.Exit();

                    }*/
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

