using System;
using System.Linq;
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
            ogrenciGiris.girisYap(kullaniciAd, sifre);
            Assert.AreEqual(cikisDegeri, ogrenciGiris.kullaniciAdi_tut);

        }

        [TestMethod]
        public void ogrenciGiris()
        {
            ogrenciGirisTest("dorukan", "1234", "dorukan");
        }


    }
}
