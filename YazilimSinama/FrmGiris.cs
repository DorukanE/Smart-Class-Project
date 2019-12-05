using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimSinama
{
    public partial class FrmGiris : MetroFramework.Forms.MetroForm
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void txtKullanici_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (rdnbtnogrenci.Checked == true)
            {
                FrmOgrenci ogrenciyeGecis = new FrmOgrenci();
                ogrenciyeGecis.Show();
                this.Hide();
            }
           else if(rdnbtnogretmen.Checked == true)
            {
                FrmOgretmen ogretmeneGecis = new FrmOgretmen();
                ogretmeneGecis.Show();
                this.Hide();
            }

        }
    }
}
