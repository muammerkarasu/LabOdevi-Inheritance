using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev5
{
    public class EskenarDortgen : Sekiller
    {
        private int genislik;
        private int yukseklik;
        public EskenarDortgen()
        {
            genislik = 1;
            yukseklik = 1;
        }
        public EskenarDortgen(int genislik, int yukseklik)
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public void Ciz()
        {
            if (genislik != yukseklik || genislik % 2 == 0 || yukseklik % 2 == 0)
            {
                Console.WriteLine("Çizim yapılamıyor.");
            }  
            else
            {
                for (int i = 0; i < yukseklik; i++)
                {
                    int boslukSayisi = Math.Abs(yukseklik / 2 - i);

                    for (int j = 0; j < boslukSayisi; j++)
                    {
                        Console.Write(" ");
                    }

                    int sembolSayisi = yukseklik - (boslukSayisi * 2);
                    if (GetDoluMu())
                    {
                        for (int j = 0; j < sembolSayisi; j++)
                        {
                            Console.Write(GetSembol());
                        }
                    }
                    
                    else
                    {
                        Console.Write(GetSembol());
                        for (int j = 0; j < sembolSayisi - 2; j++)
                        {
                            Console.Write(" ");
                        }
                        if (i != 0 && i != yukseklik - 1)
                        {
                            Console.Write(GetSembol());
                        }
                    }

                    Console.WriteLine();
                }
            }

            
        }
        public double AlanHesapla()
        {
            return (genislik * yukseklik)/2;
        }
        public void SetYukseklik(int yukseklik)
        {
            this.yukseklik = yukseklik;
        }
        public int GetYukseklik()
        {
            return yukseklik;
        }
        public void OzellikYazdir()
        {
            Console.WriteLine(base.GetOlusturulmaTarihi() + " tarihinde oluşturulan EşkenarDörtgen sınıfı--> Genişlik= " + GetGenislik() + " Yükseklik= " + GetYukseklik() + " Alan= " + AlanHesapla());
        }
        public void SetGenislik(int genislik)
        {
            this.genislik = genislik;
        }
        public int GetGenislik()
        {
            return genislik;
        }
    }
}
