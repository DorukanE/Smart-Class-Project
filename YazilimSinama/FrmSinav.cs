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
    public partial class FrmSinav : MetroFramework.Forms.MetroForm
    {
        public FrmSinav()
        {
            InitializeComponent();
        }

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
    }
}
