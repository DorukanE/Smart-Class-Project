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
    public partial class FrmGiris : MetroFramework.Forms.MetroForm
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        OgrenciGiris ogrencigirisyapalim = new OgrenciGiris();
        OgretmenGiris ogretmengirisyapalim = new OgretmenGiris();
    
            private void btnGiris_Click(object sender, EventArgs e)
            {
                /*if (txtKullanici.Text == string.Empty || txtSifre.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen Kullanici Adi Ve Sifreni Gir..");

                }*/
                if (rdnBtnOgrenci.Checked == true)
                {
                ogrencigirisyapalim.girisYap(txtKullanici.Text, txtSifre.Text);
                txtKullanici.Text = "";
                txtSifre.Text = "";
                /*FrmOgrenci ogrenciyeGecis = new FrmOgrenci();
                ogrenciyeGecis.Show();
                this.Hide();*/
            }
                if (rdnBtnOgretmen.Checked == true)
                {
                    ogretmengirisyapalim.OgretmengirisYap(txtKullanici.Text, txtSifre.Text);
                    txtKullanici.Text = "";
                    txtSifre.Text = "";
                    /*FrmOgretmen ogretmenegecis = new FrmOgretmen();
                    ogretmenegecis.Show();
                    this.Hide();*/
                }

            }

        private void txtBoxKullanici_TextChanged(object sender, EventArgs e)
        {
            txtKullanici.Text = txtKullanici.Text.ToLower();
            txtKullanici.SelectionStart = txtKullanici.Text.Length;
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void FrmGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
               Application.Exit();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
