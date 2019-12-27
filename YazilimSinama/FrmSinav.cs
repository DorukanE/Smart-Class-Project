using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace YazilimSinama
{
    public partial class FrmSinav : MetroFramework.Forms.MetroForm
    {
        public FrmSinav()
        {
            InitializeComponent();
        }

        Database dbislemleri = new Database();
        SoruObjesi donecekSoru = new SoruObjesi();


        private void FrmSinav_Load(object sender, EventArgs e)
        {
           timersure.Start();
            
        }

        public void YeniSoru()
        {
            SoruGetir();
            lblSoruMetni.Text = donecekSoru.soru.Trim();
            Random rnd = new Random();
            int dogruSecenek = rnd.Next(1, 4);
            if (dogruSecenek == 1)
            {
                btnAsecenegi.Text = donecekSoru.dogruCevap;
                btnBsecenegi.Text = soruIcinSecenekGetir();
                btnCsecenegi.Text = soruIcinSecenekGetir();
                btnDsecenegi.Text = soruIcinSecenekGetir();
            }
            else if (dogruSecenek == 2)
            {
                btnAsecenegi.Text = soruIcinSecenekGetir();
                btnBsecenegi.Text = donecekSoru.dogruCevap;
                btnCsecenegi.Text = soruIcinSecenekGetir();
                btnDsecenegi.Text = soruIcinSecenekGetir();
            }
            else if (dogruSecenek == 3)
            {
                btnAsecenegi.Text = soruIcinSecenekGetir();
                btnBsecenegi.Text = soruIcinSecenekGetir();
                btnCsecenegi.Text = donecekSoru.dogruCevap;
                btnDsecenegi.Text = soruIcinSecenekGetir();
            }
            else if (dogruSecenek == 4)
            {
                btnAsecenegi.Text = soruIcinSecenekGetir();
                btnBsecenegi.Text = soruIcinSecenekGetir();
                btnCsecenegi.Text = soruIcinSecenekGetir();
                btnDsecenegi.Text = donecekSoru.dogruCevap;
            }
        }
        public SoruObjesi SoruGetir()
        {
            Database dbislemleri = new Database();
            DataTable dt = new DataTable();
            string sorgu = "SELECT * FROM tbl_Soru WHERE kacinciOgrenme = 0 ";
            dt = dbislemleri.VeriTablosuDondur(sorgu);
            if (dt.Rows.Count == 0)
            {
                dt = dbislemleri.VeriTablosuDondur("SELECT * FROM tbl_Soru where kacinciOgrenme = -1");
                if (dt.Rows.Count == 0)
                {
                    dt = dbislemleri.VeriTablosuDondur("SELECT * FROM tbl_Soru where kacinciOgrenme = 1");
                    if (dt.Rows.Count == 0)
                    {
                        SoruObjesi soru = new SoruObjesi();
                        donecekSoru = soru;
                        return soru;
                    }
                }
            }
            Random rnd = new Random();
            int sayi = rnd.Next(0, dt.Rows.Count);
            DataRow k = dt.NewRow();
            k = dt.Rows[sayi];
            donecekSoru.soruID = Convert.ToInt32(k[0].ToString());
            donecekSoru.soru = k[1].ToString();
            donecekSoru.dogruCevap = k[2].ToString();
            donecekSoru.kacinciOgrenme = Convert.ToInt32(k[3].ToString());
            return donecekSoru;
        }

        Random rnd = new Random();
        public String soruIcinSecenekGetir()
        {
            string kelime = "";
            do
            {
                Database dbislemleri = new Database();
                DataTable dt = new DataTable();
                dt = dbislemleri.VeriTablosuDondur("SELECT dogruCevap FROM tbl_Soru");

                int sayi = rnd.Next(0, dt.Rows.Count);
                kelime = dt.Rows[sayi][0].ToString();


            } while (kelime == donecekSoru.dogruCevap);
            return kelime;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblSayac_Click(object sender, EventArgs e)
        {

        }

        private void timersure_Tick(object sender, EventArgs e)
        {
            int sure = int.Parse(lblSayac.Text);
            sure--;
            lblSayac.Text = sure.ToString();
            if (sure <= 0)
            {
                timersure.Stop();
                MessageBox.Show("Bu soru için ayrılan süre doldu!");
            }

        }

        public void txtSoruMetni_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSinavaBasla_Click(object sender, EventArgs e)
        {
            YeniSoru();
            btnSinavaBasla.Visible = false;

        }


        private void Secenek_Click_1(object sender, EventArgs e)
        {
           
        }
        private void txtDSecenegi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
        
        private void btnDsecenegi_MouseClick(object sender, MouseEventArgs e)
        {
            Button buton = sender as Button;
            Database dbislemleri = new Database();
            if (buton.Text == donecekSoru.dogruCevap)
            {
                dbislemleri.sorguCalistir("UPDATE tbl_Soru set dogruSayisi = (dogruSayisi + 1), ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                if (donecekSoru.kacinciOgrenme == 1)
                {
                    dbislemleri.sorguCalistir("UPDATE tbl_Soru set kacinciOgrenme = -2, ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                }
                else
                {
                    dbislemleri.sorguCalistir("UPDATE tbl_Soru set kacinciOgrenme = (kacinciOgrenme + 1), ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                }
                MessageBox.Show("Tebrikler doğru cevap");
                
            }
            else
            {
                if (donecekSoru.kacinciOgrenme != 0)
                {
                    dbislemleri.sorguCalistir("UPDATE tbl_Soru set kacinciOgrenme = (kacinciOgrenme - 1), ogrenilmetarihi = getdate() where soruID = " + donecekSoru.soruID);
                }
                MessageBox.Show("Maalesef yanlış cevap");
                //kullanıcı soruyu yanlış cevapladı.
            }
            YeniSoru();
        }
        public class SoruObjesi
        {
            public int soruID { get; set; }
            public string soru { get; set; }
            public string dogruCevap { get; set; }
            public int kacinciOgrenme { get; set; }
        }

        private void btnAsecenegi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            YeniSoru();
        }

        private void btnSinaviBitir_Click(object sender, EventArgs e)
        {
            FrmOgrenci ogrenciyegecis = new FrmOgrenci();
            ogrenciyegecis.Show();
            this.Hide();
        }

        private void lblSoruMetni_Click(object sender, EventArgs e)
        {

        }

        private void btnCsecenegi_Click(object sender, EventArgs e)
        {

        }

        private void btnBsecenegi_Click(object sender, EventArgs e)
        {

        }

        private void btnDsecenegi_Click(object sender, EventArgs e)
        {

        }

        private void btnIstatistigiGoster_Click(object sender, EventArgs e)
        {
            FrmBasariGrafigi istatistigegecis = new FrmBasariGrafigi();
            istatistigegecis.Show();
            this.Hide();

        }
    }
}
