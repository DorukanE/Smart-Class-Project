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
    public partial class FrmOgrenci : MetroFramework.Forms.MetroForm
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        Database dbislemleri = new Database();
        private void profiligoster()
        {
            dbislemleri.baglanti.Open();
            SqlCommand ogrencikomut = new SqlCommand("SELECT * FROM tbl_OgrenciBilgi", dbislemleri.baglanti);
            //ogrenci bilgi tablomuzdaki tüm kayıtları seçtik.//
            SqlDataReader oku = ogrencikomut.ExecuteReader();
            //data reader ile komutumuzu okuduk.//
            while (oku.Read())
            {
                //okuma işlemimiz devam ettiği sürece kayıtlarımızı kolon kolon listview'a eklettik.//
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogrenciAd"].ToString();
                ekle.SubItems.Add(oku["ogrenciSoyad"].ToString());
                ekle.SubItems.Add(oku["ogrenciOkul"].ToString());
                ekle.SubItems.Add(oku["ogrenciCinsiyet"].ToString());
                ekle.SubItems.Add(oku["sinavTarihi"].ToString());
                ekle.SubItems.Add(oku["ogrenciDTarih"].ToString());
                listViewProfilim.Items.Add(ekle);
            }
            dbislemleri.baglanti.Close();
            // bağlantımızı kapattık.//
        }
        

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            listViewProfilim.Visible = false;
            pictureBoxProfilim.Visible = false;
            //form yğklenir yüklenmez listview'ın gelmesinin önüne geçtik.//

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
            FrmBasariGrafigi barGrafigineGecis = new FrmBasariGrafigi();
            barGrafigineGecis.Show();
            this.Hide();
            // menustrip'e tıklandığında bar grafiğinin olduğu forma gitmesini sağladık.//
        }

        private void çUBUKGRAFİĞİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCubukGrafigi cubukGrafigineGecis = new FrmCubukGrafigi();
            cubukGrafigineGecis.Show();
            this.Hide();
            // menustrip'e tıklandığında çubuk grafiğinin olduğu forma gitmesini sağladık.//
        }

        private void sINAVABAŞLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSinav sinavol = new FrmSinav();
            sinavol.Show();
            this.Hide();
            // menustrip'e tıklandığında sınavın olduğu forma gitmesini sağladık.//

        }

        private void lblCinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void profilimToolStripMenuItem_Click(object sender, EventArgs e)
        {
           listViewProfilim.Visible = true;
           pictureBoxProfilim.Visible = true;
           profiligoster();
            //tanımladığımız fonksiyonun çağrısını yaptık.//
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStripOgrenci_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listViewProfilim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
