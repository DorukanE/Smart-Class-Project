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
    public partial class FrmCubukGrafigi : MetroFramework.Forms.MetroForm
    {
        public FrmCubukGrafigi()
        {
            InitializeComponent();
        }

        Database dbIslem = new Database();
        bool loaded = false;
        private void FrmCubukGrafigi_Load(object sender, EventArgs e)
        { 
            cmbTarih.DataSource = tarihleriCek();
            grafikGoster();
            loaded = true;
        }
        private List<string> tarihleriCek()
        {
            List<string> tarihler = new List<string>();
            dbIslem.baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT DISTINCT FORMAT(ogrenilmeTarihi, 'dd-MM-yy') FROM tbl_Soru", dbIslem.baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0] != System.DBNull.Value)
                    tarihler.Add(Convert.ToDateTime(reader[0]).ToString("dd-MM-yy"));
            }
                dbIslem.baglanti.Close();
                return tarihler;
        }

        private void dogruSayisiCek(string tarih)
        {
            dbIslem.baglanti.Open();
            string query = String.Format("SELECT SUM(dogruSayisi), FORMAT (ogrenilmeTarihi, 'dd-MM-yy') FROM tbl_Soru GROUP BY FORMAT (ogrenilmeTarihi, 'dd-MM-yy') HAVING FORMAT (ogrenilmeTarihi, 'dd-MM-yy')='{0}'", tarih);
            SqlCommand command = new SqlCommand(query, dbIslem.baglanti);


            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                int dogruSayisi = Convert.ToInt32(reader[0]);
                seciliGrafikteGoster(dogruSayisi, tarih);
            }
            dbIslem.baglanti.Close();
        }

        private void seciliGrafikteGoster(int dogru, string tarih)       
        {
            chartZamanBasari.Series["Doğru Cevap Sayısı"].Points.Clear();
            chartZamanBasari.Series["Doğru Cevap Sayısı"].Points.AddPoint(Convert.ToString(tarih), int.Parse(dogru.ToString()));
        }
        private void grafikGoster()
        {
            dbIslem.baglanti.Open();
            SqlCommand command = new SqlCommand("SELECT SUM(dogruSayisi), FORMAT (ogrenilmeTarihi, 'dd-MM-yy') FROM tbl_Soru GROUP BY FORMAT (ogrenilmeTarihi, 'dd-MM-yy')", dbIslem.baglanti);
            SqlDataReader read = command.ExecuteReader();
            chartZamanBasari.Series["Doğru Cevap Sayısı"].Points.Clear();
            while (read.Read())
            {
                if(read[1]!= System.DBNull.Value)
                {
                    chartZamanBasari.Series["Doğru Cevap Sayısı"].Points.AddPoint(Convert.ToString(read[1]), int.Parse(read[0].ToString()));
                }
                
            }
            dbIslem.baglanti.Close();
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (cmbTarih.SelectedIndex >= 0)
                    dogruSayisiCek(cmbTarih.SelectedItem.ToString());
            }
        }

        private void btnGrafikGoster_Click(object sender, EventArgs e)
        {
            grafikGoster();
        }
    }
}
