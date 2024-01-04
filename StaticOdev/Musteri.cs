using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOdev
 {
    public class Musteri
    {
        #region sanal database 
        static ArrayList musteriDatabase;
        #endregion
        #region static yapıcı metod
        static Musteri()
        {
         musteriDatabase = new ArrayList();
        }

        #region field 
        public int musteriID { get; set; }
        public  string isim { get; set; }
        public string Soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }
        #endregion
        #region kapsullleme
        private string _kullaniciAdi;
        public string KullaniciAdi
        {
            get { return this._kullaniciAdi; }
            set 
            {
                bool kullanicİAdiKontrol = musteriKullaniciAdiKontrol(value);
                if(kullanicİAdiKontrol )
                {
                   Console.WriteLine("eklemek istediğiniz kullanici adı sistemde kayıtlı");
                   this._kullaniciAdi = string.Empty;
                }
                else
                {
                   this._kullaniciAdi = value;
                }
               
            }
        }
        #endregion
        #region Static Metotlar
        static Boolean musteriKullaniciAdiKontrol (string _kullaniciadi)
        {
            bool kontrol = false;
            for (int i = 0; i < musteriDatabase.Count;i++)
            {
                Musteri temp = (Musteri)musteriDatabase[i];
                if(temp._kullaniciAdi == _kullaniciadi)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }

        public static void MusteriEkle(Musteri M)
        {
            if(M!= null && !string.IsNullOrEmpty(M.KullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = MusteriEmailAdresKontrol(M.emailAdres);
                if(emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }
        }
        static bool MusteriEmailAdresKontrol(string _emailAdres)
        {
            bool kontrol = false;
            for(int i = 0;i < musteriDatabase.Count ;i++)
            {
                // şimditip dönüşümü yapıyoruz neden çeviriyoruz 
                // obje olarak saklıyorum nesneye çevirmem lazım ki içindeki bir fielda göre 
                // kontrol yapabileyim
                Musteri temp = (Musteri)musteriDatabase[i];
                if(temp.emailAdres == _emailAdres)
                {
                    kontrol = true;
                    break;
                }
            }
            return kontrol;
        }
        #endregion
    }
    #endregion
}