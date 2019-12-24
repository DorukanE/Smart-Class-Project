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
       


        private void FrmSinav_Load(object sender, EventArgs e)
        {
           timersure.Start();
            
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
                if (donecekSoru.kacinciOgrenme == 1)
                {
                    dbislemleri.sorguCalistir("UPDATE tbl_Soru set kacinciOgrenme = -2 where soruID = " + donecekSoru.soruID);
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
                    dbislemleri.sorguCalistir("UPDATE tbl_Soru set kacinciOgrenme = (kacinciOgrenme - 1) where soruID = " + donecekSoru.soruID);
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

        public void lblSoruMetni_Click(object sender, EventArgs e)
        {

        }

        public void btnCsecenegi_Click(object sender, EventArgs e)
        {

        }

        public void btnBsecenegi_Click(object sender, EventArgs e)
        {

        }

        public void btnDsecenegi_Click(object sender, EventArgs e)
        {

        }
    }
}
