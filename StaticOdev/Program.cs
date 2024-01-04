using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.musteriID = 1;
            m1.isim = "cengiz";
            m1.Soyisim = "han";
            m1.emailAdres = "cengizhan@gmail.com";
            m1.sifre = "1";

            Musteri.MusteriEkle(m1);
            Musteri m2 = new Musteri()
            {
                musteriID = 1,
                isim = "ahmet",
                Soyisim = "Atilla",
                emailAdres = "mehmetkadir@hotmail.com",
                KullaniciAdi = "ahmet.atilla",
                sifre = "2"

            };
            Musteri.MusteriEkle(m2);
            Console.ReadLine();

        }
    }
}
