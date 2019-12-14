using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YazilimSinama
{
    class OgrenciGiris
    {
            Database db = new Database();
            public string kullaniciAdi_tut { get; set; }
            public string sifre_tut { get; set; }

            public string girisDurumu { get; set; }


            public void girisYap(string kullaniciAdi, string sifre, Form frm1)
            {
                if (db.baglanti.State == System.Data.ConnectionState.Open)
                {
                    db.baglanti.Close();
                }
                try
                {
                    db.baglanti.Open();
                    SqlCommand giriskomutu = new SqlCommand("SELECT kullaniciAdi FROM tbl_OgrenciGiris WHERE kullaniciAdi=@kulAdi AND sifre=@sifre", db.baglanti);
                    giriskomutu.Parameters.AddWithValue("@kulAdi", kullaniciAdi);
                    giriskomutu.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader kulAdi_Oku = giriskomutu.ExecuteReader();
                    if (kulAdi_Oku.Read())
                    {
                    MessageBox.Show("Giriş başarılı");
                    FrmOgrenci frmOgrenci = new FrmOgrenci();
                    frm1.Hide();
                    frmOgrenci.Show();
                    //kullaniciAdi_tut = kulAdi_Oku["kullaniciAdi"].ToString();
                    /*SqlCommand giriskomutupw = new SqlCommand("SELECT sifre FROM tbl_OgrenciGiris WHERE sifre=@sifre ", db.baglanti);
                    giriskomutupw.Parameters.AddWithValue("@sifre", sifre);
                    SqlDataReader giriskomutupw_oku = giriskomutupw.ExecuteReader();

                    if (giriskomutupw_oku.Read())
                    {

                        sifre_tut = giriskomutupw_oku["sifre"].ToString();
                        girisDurumu = kullaniciAdi_tut + " " + sifre_tut;
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
                catch{ }

                finally
                {
                    db.baglanti.Close();
                }


            }
        }
    }
