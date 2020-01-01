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
    public partial class FrmBasariGrafigi : MetroFramework.Forms.MetroForm
    {
        public FrmBasariGrafigi()
        {
            InitializeComponent();
        }
        Database dbIslem = new Database();
        // database sınıfımızı çağırdık.//
        private void FrmBarGrafigi_Load(object sender, EventArgs e)
        {
            dbIslem.baglanti.Open();
            //bağlantımızı açtık.//
            SqlCommand grafikkomutu = new SqlCommand("SELECT K.konu, S.dogruSayisi * 5 FROM tbl_Soru S INNER JOIN tbl_Ogretmen O ON S.soruID=O.soruID INNER JOIN tbl_Konu K ON K.konuID=O.konuID GROUP BY K.konu, S.dogruSayisi", dbIslem.baglanti);
            //Sql'den verileri almak için sql komutu yazdık.//
            SqlDataReader read = grafikkomutu.ExecuteReader();
            //Sql data reader ile verileri okuduk.//
            while (read.Read())
            {
                //okuma işlemleri devam ettiği sürece grafiğe yazdırdık.//
                chartBasari.Series["Doğru Cevap Yüzdelik"].Points.AddPoint(Convert.ToString(read[0]), int.Parse(read[1].ToString()));
            }
            dbIslem.baglanti.Close();
            //baglantımızı kapattık.//
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenci ogrenciyedon = new FrmOgrenci();
            //geriye tıklayınca öğrenci ekranına dönmesini sağladık.//
            ogrenciyedon.Show();
            this.Hide();
        }
    }
}
