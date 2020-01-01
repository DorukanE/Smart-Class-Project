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
        //Olan class'lardan nesne yaratılması
        OgrenciGiris ogrencigirisyapalim = new OgrenciGiris();
        OgretmenGiris ogretmengirisyapalim = new OgretmenGiris();
    
        //Giriş butonuna tıklandığında seçili olan kullanıcıya göre giriş yapıyor.
            private void btnGiris_Click(object sender, EventArgs e)
            {
                if (rdnBtnOgrenci.Checked == true)
                {
                ogrencigirisyapalim.girisYap(txtKullanici.Text, txtSifre.Text);
                txtKullanici.Text = "";
                txtSifre.Text = "";
            }
                //Hangi tür kullanıcı olcağının seçimi
                if (rdnBtnOgretmen.Checked == true)
                {
                    ogretmengirisyapalim.OgretmengirisYap(txtKullanici.Text, txtSifre.Text);
                    txtKullanici.Text = "";
                    txtSifre.Text = "";
                }

            }

        //Girilen değerlere kısıtlama uyguluyoruz.
        private void txtBoxKullanici_TextChanged(object sender, EventArgs e)
        {
            txtKullanici.Text = txtKullanici.Text.ToLower();
            txtKullanici.SelectionStart = txtKullanici.Text.Length;
        }

        //Programdan çıkmak için yazılan fonksiyon.
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
