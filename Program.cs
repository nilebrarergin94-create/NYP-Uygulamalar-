
using System;
using System.Collections.Generic;

namespace EkipmanTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ekipman> ekipmanlar = new List<Ekipman>
            {
                new Ekipman("1", "Kamera"),
                new Ekipman("2", "Mikrofon"),
                new Ekipman("3", "Bilgisayar")
            };

            List<Ogrenci> ogrenciler = new List<Ogrenci>
            {
                new Ogrenci("101", "Ayşe"),
                new Ogrenci("102", "Mehmet")
            };

            string secim = "";

            while (secim != "0")
            {
                Console.WriteLine("\n--- EKİPMAN TAKİP SİSTEMİ ---");
                Console.WriteLine("1 - Ekipmanları listele");
                Console.WriteLine("2 - Ödünç ver");
                Console.WriteLine("3 - İade al");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçiminiz: ");

                secim = Console.ReadLine() ?? "";

                switch (secim)
                {
                    case "1":
                        foreach (Ekipman e in ekipmanlar)
                        {
                            string durum = e.Oduncte
                                ? "Ödünçte"
                                : "Müsait";

                            Console.WriteLine(
                                $"{e.DemirbasNo} - {e.Ad} - {durum}");
                        }
                        break;

                    case "2":
                        Console.Write("Ekipman numarası: ");
                        string ekipmanNo = Console.ReadLine() ?? "";

                        Console.Write("Öğrenci numarası: ");
                        string ogrenciNo = Console.ReadLine() ?? "";

                        Ekipman? ekipman = EkipmanBul(ekipmanlar, ekipmanNo);
                        Ogrenci? ogrenci = OgrenciBul(ogrenciler, ogrenciNo);

                        if (ekipman == null)
                        {
                            Console.WriteLine("Ekipman bulunamadı.");
                        }
                        else if (ogrenci == null)
                        {
                            Console.WriteLine("Öğrenci bulunamadı.");
                        }
                        else if (ekipman.OduncVer(ogrenci.Numara))
                        {
                            Console.WriteLine(
                                $"{ekipman.Ad}, {ogrenci.AdSoyad} adlı öğrenciye ödünç verildi.");
                        }
                        else
                        {
                            Console.WriteLine(
                                "İşlem reddedildi. Ekipman zaten ödünçte.");
                        }
                        break;

                    case "3":
                        Console.Write("İade edilecek ekipman numarası: ");
                        string iadeNo = Console.ReadLine() ?? "";

                        Ekipman? iadeEkipmani = EkipmanBul(ekipmanlar, iadeNo);

                        if (iadeEkipmani == null)
                        {
                            Console.WriteLine("Ekipman bulunamadı.");
                        }
                        else if (iadeEkipmani.IadeAl())
                        {
                            Console.WriteLine("İade başarılı.");
                        }
                        else
                        {
                            Console.WriteLine(
                                "İşlem reddedildi. Ekipman zaten müsait.");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Program kapatılıyor.");
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }

        static Ekipman? EkipmanBul(List<Ekipman> liste, string no)
        {
            foreach (Ekipman e in liste)
            {
                if (e.DemirbasNo == no)
                    return e;
            }

            return null;
        }

        static Ogrenci? OgrenciBul(List<Ogrenci> liste, string no)
        {
            foreach (Ogrenci o in liste)
            {
                if (o.Numara == no)
                    return o;
            }

            return null;
        }
    }
}



