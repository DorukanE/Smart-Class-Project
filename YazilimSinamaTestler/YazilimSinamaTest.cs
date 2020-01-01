using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinama;
using System.Windows.Forms;

namespace YazilimSinamaTestler
{
    [TestClass]
    public class YazilimSinamaTest : MetroFramework.Forms.MetroForm
    {
        [TestMethod]
         void ogrenciGirisTest(string kullaniciAd, string sifre, string cikisDegeri)
        {
            OgrenciGiris ogrenciGiris = new OgrenciGiris();
            ogrenciGiris.girisYap(kullaniciAd, sifre);
            Assert.AreEqual(cikisDegeri, ogrenciGiris.kullaniciAdi_tut);
        }

        [TestMethod]
        public void ogrenciGiris()
        {
            ogrenciGirisTest("dorukan", "1234", "dorukan");
        }

        [TestMethod]
         void ogretmenGirisTest(string kullaniciAd, string sifre, string cikisDegeri)
        {
            OgretmenGiris ogretmenGiris = new OgretmenGiris();
            ogretmenGiris.OgretmengirisYap(kullaniciAd, sifre);
            Assert.AreEqual(cikisDegeri, ogretmenGiris.OgretmenkullaniciAdi_tut);
        }

        [TestMethod]
        public void ogretmenGiris()
        {
            ogretmenGirisTest("eminborandag", "1234", "eminborandag");
        }

        [TestMethod]
        void OgretmenSoruEklemeTest(string konu, string soru, int dogruCevap, string cikisDegeri) 
        {
            FrmOgretmen ogretmenSoruEkle = new FrmOgretmen();
            ogretmenSoruEkle.KonuEkleTest(konu);
            ogretmenSoruEkle.SoruEkleTest(soru, dogruCevap);
            ogretmenSoruEkle.MesajGoster();
            Assert.AreEqual(cikisDegeri, ogretmenSoruEkle.girisDurum);
        }

        [TestMethod]
        public void OgretmenSoruEkleme()
        {
            OgretmenSoruEklemeTest("adsadasd", "sASas", 5, "basarili");
        }
    }
}
