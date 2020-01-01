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
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        Database dbislemleri = new Database();
        //database sınıfımızı çağırdık.//
        private void konuEkle()
        {
            dbislemleri.baglanti.Open();
            SqlCommand konueklekomutu = new SqlCommand("INSERT INTO tbl_Konu (konu) VALUES ('" + txtKonu.Text.ToString() + "')", dbislemleri.baglanti);
            //ilgili butona girilen konuyu içeri aktarmak için sql komutu yazdık.//
            konueklekomutu.ExecuteNonQuery();
            //sql komutunu okuttuk.//
            dbislemleri.baglanti.Close();
        }
        private void soruEkle()
        {
            dbislemleri.baglanti.Open();
            SqlCommand sorueklekomutu = new SqlCommand("INSERT INTO tbl_Soru(soru,dogruCevap) VALUES ('" + txtSoru.Text.ToString() + "','" + txtDogruCevap.Text.ToString() + "')", dbislemleri.baglanti);
            sorueklekomutu.ExecuteNonQuery();
            dbislemleri.baglanti.Close();
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

        public void txtKonu_Click(object sender, EventArgs e)
        {

        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBoxOgretmen_Click(object sender, EventArgs e)
        {

        }

        private void btnSoruEkle_Click_1(object sender, EventArgs e)
        {
            konuEkle();
            soruEkle();
            MessageBox.Show("Soru Başarıyla Eklendi!");
        }
    }
}
