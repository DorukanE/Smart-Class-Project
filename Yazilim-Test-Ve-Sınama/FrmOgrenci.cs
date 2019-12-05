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
    public partial class FrmOgrenci : MetroFramework.Forms.MetroForm
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {

        }

        private void kULLANICIBİLGİLERİMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çIKIŞYAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bARGRAFİĞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBarGrafigi barGrafigineGecis = new FrmBarGrafigi();
            barGrafigineGecis.Show();
            this.Hide();
        }

        private void çUBUKGRAFİĞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCubukGrafigi cubukGrafigineGecis = new FrmCubukGrafigi();
            cubukGrafigineGecis.Show();
            this.Hide();
        }

        private void sINAVABAŞLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSinav sinavol = new FrmSinav();
            sinavol.Show();
            this.Hide();
            

        }
    }
}
