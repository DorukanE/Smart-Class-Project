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
        private void FrmBarGrafigi_Load(object sender, EventArgs e)
        {
            dbIslem.baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT K.konu, S.dogruSayisi * 5 FROM tbl_Soru S INNER JOIN tbl_Ogretmen O ON S.soruID=O.soruID INNER JOIN tbl_Konu K ON K.konuID=O.konuID GROUP BY K.konu, S.dogruSayisi", dbIslem.baglanti);
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                chartBasari.Series["Doğru Cevap"].Points.AddPoint(Convert.ToString(read[0]), int.Parse(read[1].ToString()));
            }
            dbIslem.baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgrenci ogrenciyedon = new FrmOgrenci();
            ogrenciyedon.Show();
            this.Hide();
        }
    }
}
