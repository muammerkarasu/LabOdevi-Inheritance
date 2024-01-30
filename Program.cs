using LabOdev5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("220541087 Muammer Karasu");
            Dikdortgen dik = new Dikdortgen();
            EskenarUcgen ucgen = new EskenarUcgen();
            EskenarDortgen dortgen = new EskenarDortgen();
            while (true)
            {
                en:
                Console.WriteLine("1-) Dikdörtgen\n2-) Eşkenar Üçgen\n3-) Eşkenar Dörtgen\n4-) Çıkış");
                int nesnesec = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    switch (nesnesec)
                    {
                        case 1:
                            Console.Write("Dikdörtgenin genişliğini giriniz. >> ");
                            dik.SetGenislik(int.Parse(Console.ReadLine()));
                            Console.Write("Dikdörtgenin yükseklik giriniz. >> ");
                            dik.SetYukseklik(int.Parse(Console.ReadLine()));
                            Console.WriteLine("içi dolu mu boş mu olacak");
                            dik.SetDoluMu(Convert.ToBoolean(Console.ReadLine()));
                            Console.WriteLine();
                            sura:
                            Console.WriteLine("1-) Alan Hesapla");
                            Console.WriteLine("2-) Çevre Hesapla");
                            Console.WriteLine("3-) Çiz");
                            Console.WriteLine("4-) Genişlik Değiştir");
                            Console.WriteLine("5-) Yükseklik Değiştir");
                            Console.WriteLine("6-) Sembol Değiştir");
                            Console.WriteLine("7-) DoluMu Değiştir");
                            Console.WriteLine("8-) Özellikleri Yazdır");
                            Console.WriteLine("9-) Üst Menü");
                            Console.WriteLine("10-) Çıkış");
                            Console.WriteLine("Seçiminiz >> ");
                        
                            int arasec = Convert.ToInt32(Console.ReadLine());
                            switch (arasec)
                            {
                                case 1:
                                    Console.WriteLine("seçiminiz için en uygun sonuç yapılıyor ");
                                    double a = dik.AlanHesapla();
                                    Console.WriteLine(a);
                                    goto sura;
                                case 2:
                                    Console.WriteLine("seçiminiz için en uygun sonuç yapılıyor ");
                                    double b = dik.CevreHesapla();
                                    Console.WriteLine(b);
                                    goto sura;
                                case 3:
                                    dik.Ciz();
                                    goto sura;
                                case 4:
                                    Console.Write("Yeni değer giriniz >> ");
                                    dik.SetGenislik(int.Parse(Console.ReadLine()));
                                    goto sura;
                                case 5:
                                    Console.Write("Yeni değer giriniz >> ");
                                    dik.SetYukseklik(int.Parse(Console.ReadLine()));
                                    goto sura;
                                case 6:
                                    Console.Write("Yeni sembol giriniz >> ");
                                    dik.SetSembol(Convert.ToChar(Console.ReadLine()));
                                    goto sura;
                                case 7:
                                    Console.Write("Dolu veya boş için özellik giriniz >> ");
                                    dik.SetDoluMu(Convert.ToBoolean(Console.ReadLine()));
                                    goto sura;
                                case 8:
                                    dik.OzellikYazdir();
                                    goto sura;
                                case 9:
                                    goto en;
                                case 10:
                                    goto bitir;
                                default:
                                    Console.WriteLine("Bir hata oldu sanırım bir daha giriniz");
                                    goto sura;



                            }
                            break;
                        case 2:
                            Console.Write("Eşkenar Üçgenin kenar uzunluğunu giriniz >> ");
                            ucgen.SetKenar(int.Parse(Console.ReadLine()));
                            Console.WriteLine("içi dolu mu boş mu olacak");
                            ucgen.SetDoluMu(Convert.ToBoolean(Console.ReadLine()));
                            Console.WriteLine();
                            usura:
                            Console.WriteLine("1-) Alan Hesapla");
                            Console.WriteLine("2-) Çevre Hesapla");
                            Console.WriteLine("3-) Çiz");
                            Console.WriteLine("4-) Kenar Değiştir");
                            Console.WriteLine("5-) Sembol Değiştir");
                            Console.WriteLine("6-) DoluMu Değiştir");
                            Console.WriteLine("7-) Özellikleri Yazdır");
                            Console.WriteLine("8-) Üst Menü");
                            Console.WriteLine("9-) Çıkış");
                            Console.WriteLine("Seçiminiz >> ");
                        
                            int uarasec = Convert.ToInt32(Console.ReadLine());
                            switch (uarasec)
                            {
                                case 1:
                                    Console.WriteLine("seçiminiz için en uygun sonuç yapılıyor ");
                                    double y = ucgen.AlanHesapla();
                                    Console.WriteLine(y);
                                    goto usura;
                                case 2:
                                    Console.WriteLine("seçiminiz için en uygun sonuç yapılıyor ");
                                    double z = ucgen.CevreHesapla();
                                    Console.WriteLine(z);
                                    goto usura;
                                case 3:
                                    ucgen.Ciz();
                                    goto usura;
                                case 4:
                                    Console.Write("Yeni değer giriniz >> ");
                                    ucgen.SetKenar(int.Parse(Console.ReadLine()));
                                    goto usura;
                                case 5:
                                    Console.Write("Yeni sembol giriniz >> ");
                                    ucgen.SetSembol(Convert.ToChar(Console.ReadLine()));
                                    goto usura;
                                case 6:
                                    Console.Write("Dolu veya boş için özellik giriniz >> ");
                                    ucgen.SetDoluMu(Convert.ToBoolean(Console.ReadLine()));
                                    goto usura;
                                case 7:
                                    ucgen.OzellikYazdir();
                                    goto usura;
                                case 8:
                                    goto en;
                                case 9:
                                    goto bitir;
                                default:
                                    Console.WriteLine("Bir hata oldu sanırım bir daha giriniz");
                                    goto usura;
                            }
                            break;
                        case 3:
                            Console.Write("Dikdörtgenin genişliğini giriniz. >> ");
                            dortgen.SetGenislik(int.Parse(Console.ReadLine()));
                            Console.Write("Dikdörtgenin yükseklik giriniz. >> ");
                            dortgen.SetYukseklik(int.Parse(Console.ReadLine()));
                            Console.WriteLine("içi dolu mu boş mu olacak");
                            dortgen.SetDoluMu(Convert.ToBoolean(Console.ReadLine()));
                            Console.WriteLine();
                            dsura:
                            Console.WriteLine("1-) Alan Hesapla");
                            Console.WriteLine("2-) Çiz");
                            Console.WriteLine("3-) Genişlik Değiştir");
                            Console.WriteLine("4-) Yükseklik Değiştir");
                            Console.WriteLine("5-) Sembol Değiştir");
                            Console.WriteLine("6-) DoluMu Değiştir");
                            Console.WriteLine("7-) Özellikleri Yazdır");
                            Console.WriteLine("8-) Üst Menü");
                            Console.WriteLine("9-) Çıkış");
                            Console.WriteLine("Seçiminiz >> ");
                        
                            int darasec = Convert.ToInt32(Console.ReadLine());
                            switch (darasec)
                            {
                                case 1:
                                    Console.WriteLine("seçiminiz için en uygun sonuç yapılıyor ");
                                    double x = dortgen.AlanHesapla();
                                    Console.WriteLine(x);
                                    goto dsura;
                                case 2:
                                    dortgen.Ciz();
                                    goto dsura;
                                case 3:
                                    Console.Write("Yeni değer giriniz >> ");
                                    dortgen.SetGenislik(int.Parse(Console.ReadLine()));
                                    goto dsura;
                                case 4:
                                    Console.Write("Yeni değer giriniz >> ");
                                    dortgen.SetYukseklik(int.Parse(Console.ReadLine()));
                                    goto dsura;
                                case 5:
                                    Console.Write("Yeni sembol giriniz >> ");
                                    dortgen.SetSembol(Convert.ToChar(Console.ReadLine()));
                                    goto dsura;
                                case 6:
                                    Console.Write("Dolu veya boş için özellik giriniz >> ");
                                    dik.SetDoluMu(Convert.ToBoolean(Console.ReadLine()));
                                    goto dsura;
                                case 7:
                                    dik.OzellikYazdir();
                                    goto dsura;
                                case 8:
                                    goto en;
                                case 9:
                                    goto bitir;
                                default:
                                    Console.WriteLine("Bir hata oldu sanırım bir daha giriniz");
                                    goto dsura;
                            }
                            break;
                        case 4:
                            goto bitir;
                        default:
                            Console.WriteLine("Bir hata oldu sanırım bir daha giriniz");
                            goto en;
                    }
                }

            }

        bitir:
            Console.WriteLine("Çıkış yapıldı... ");
            Console.Read();
        }
    }
}