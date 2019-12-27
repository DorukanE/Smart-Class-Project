using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YazilimSinama;

namespace YazilimSinamaTestler
{
    [TestClass]
    public class YazilimSinamaTest
    {
        [TestMethod]
         void ogrenciGirisTest(string kullaniciAd, string sifre, string cikisDegeri)
        {
            OgrenciGiris ogrenciGiris = new OgrenciGiris();
            ogrenciGiris = (ogrenciGiris.girisYap(kullaniciAd, sifre) as OgrenciGiris);
            Assert.AreEqual(cikisDegeri, ogrenciGiris.kullaniciAdi_tut);
        }

        [TestMethod]
        public void ogrenciGiris()
        {
            ogrenciGirisTest();
        }
    }
}
