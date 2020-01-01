using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazilimSinama
{
    public partial class FrmOgretmen : MetroFramework.Forms.MetroForm
    {
        public string girisDurum { get; set; }
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        Database dbislemleri = new Database();
        //database sınıfımızı çağırdık.//
        public void konuEkle()
        {
            dbislemleri.baglanti.Open();
            SqlCommand konueklekomutu = new SqlCommand("INSERT INTO tbl_Konu (konu) VALUES ('" + txtKonu.Text.ToString() + "')", dbislemleri.baglanti);
            //ilgili butona girilen konuyu içeri aktarmak için sql komutu yazdık.
            konueklekomutu.ExecuteNonQuery();
            //sql komutunu okuttuk.
            dbislemleri.baglanti.Close();
            //bağlantı kapatıldı.
        }

        public void KonuEkleTest(string konu)
        {
            txtKonu.Text = konu.ToString();
            dbislemleri.baglanti.Open();
            SqlCommand konueklekomutu = new SqlCommand("INSERT INTO tbl_Konu (konu) VALUES ('" + txtKonu.Text + "')", dbislemleri.baglanti);
            //ilgili butona girilen konuyu içeri aktarmak için sql komutu yazdık.
            konueklekomutu.ExecuteNonQuery();
            //sql komutunu okuttuk.
            dbislemleri.baglanti.Close();
            //bağlantı kapatıldı.
        }

        public void soruEkle()
        {
            dbislemleri.baglanti.Open();
            SqlCommand sorueklekomutu = new SqlCommand("INSERT INTO tbl_Soru(soru,dogruCevap) VALUES ('" + txtSoru.Text.ToString() + "','" + txtDogruCevap.Text.ToString() + "')", dbislemleri.baglanti);
            //ilgili butona girilen konuyu içeri aktarmak için sql komutu yazdık.
            sorueklekomutu.ExecuteNonQuery();
            //sql komutunu okuttuk.
            dbislemleri.baglanti.Close();
            //bağlantı kapatıldı.
        }

        public void SoruEkleTest(string soru, int dogruCevap)
        {
            txtDogruCevap.Text = dogruCevap.ToString();
            txtSoru.Text = soru.ToString();
            //Üstteki satırlarda, gelen parametreleri değer okuyacağımız yerlere attık.
            dbislemleri.baglanti.Open();
            SqlCommand sorueklekomutu = new SqlCommand("INSERT INTO tbl_Soru(soru,dogruCevap) VALUES ('" + txtSoru.Text + "','" + txtDogruCevap.Text + "')", dbislemleri.baglanti);
            sorueklekomutu.ExecuteNonQuery();
            //sql komutunu okuttuk.
            dbislemleri.baglanti.Close();
            girisDurum = "basarili";
        }

        //Mesaj gösterme Fonksiyonu
        public void MesajGoster()
        {
            MessageBox.Show("Soru başarıyla eklendi !");
        }
        private void FrmOgretmen_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGiris anasayfayadon = new FrmGiris();
            anasayfayadon.Show();
            this.Hide();
            //geri tusuna tıklandığında anasayfaya dönmesini sağladık.//
        }
        public void btnSoruEkle_Click_1(object sender, EventArgs e)
        { 
            //Eğer tüm alanlar doldurulmazsa soru ekleme işlemini iptal ediyor.
            if(txtDogruCevap.Text == "" || txtSoru.Text == "" || txtKonu.Text == "")
            {
                MessageBox.Show("Lütfen soruyla alakalı tüm bilgileri giriniz.");
            }
            else
            {
                konuEkle();
                soruEkle();
                MesajGoster();
            }

        }
    }
}
