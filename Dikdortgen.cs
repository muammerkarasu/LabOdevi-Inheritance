using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev5
{
    public class Dikdortgen : Sekiller
    {
        private int genislik; 
        private int yukseklik;
        public Dikdortgen()
        {
            genislik = 1;
            yukseklik = 1;
        }
        public Dikdortgen(int genislik, int yukseklik) 
        {
            this.genislik = genislik;
            this.yukseklik = yukseklik;
        }
        public double AlanHesapla()
        {
            return genislik * yukseklik;
        }
        public double CevreHesapla()
        {
            return 2 * (genislik + yukseklik);
        }
        public void SetGenislik(int genislik)
        {
            this.genislik = genislik;
        }
        public int GetGenislik()
        {
            return genislik;
        }
        public void SetYukseklik(int yukseklik)
        {
            this.yukseklik = yukseklik;
        }
        public int GetYukseklik()
        {
            return yukseklik;
        }
        public void Ciz()
        {
            for (int i = 0; i < yukseklik; i++)
            {
                    for (int j = 0; j < genislik; j++)
                    {
                        if (base.GetDoluMu() || i == 0 || i == yukseklik - 1 || j == 0 || j == genislik - 1)
                        {
                            Console.Write(GetSembol());
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
            }
        }
        public void OzellikYazdir()
        {
            Console.WriteLine(base.GetOlusturulmaTarihi()+ " tarihinde oluşturulan Dikdörtgen sınıfı--> Genişlik= "+GetGenislik()+" Yükseklik= "+GetYukseklik()+" Alan= "+AlanHesapla()+" Çevre "+CevreHesapla());
        }
    }
}


