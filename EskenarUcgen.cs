using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev5
{
    public class EskenarUcgen : Sekiller
    {
        private int kenar;
        public EskenarUcgen()
        {
            kenar = 1;
        }
        public EskenarUcgen(int kenar)
        {
            this.kenar = kenar;
        }
        public double AlanHesapla()
        {
            return (Math.Sqrt(3) * kenar * kenar) / 4;
        }
        public double CevreHesapla()
        {
            return 3 * kenar;
        }
        public void SetKenar(int kenar)
        {
            this.kenar = kenar;
        }
        public int GetKenar()
        {
            return kenar;
        }
        public void Ciz()
        {
            if (kenar % 2 == 0)
            {
                Console.WriteLine("Çizim yapılamıyor.");
            }
            else
            {
                for (int i = 1; i <= kenar; i += 2)
                {
                    int boslukSayisi = (kenar - i) / 2;

                    for (int j = 0; j < boslukSayisi; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < i; j++)
                    {
                        if (base.GetDoluMu())
                        {
                            Console.Write(GetSembol());
                        }
                        else
                        {
                            if (j == 0 || j == i - 1 || i == kenar)
                            {
                                Console.Write(GetSembol());
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }

                    Console.WriteLine();
                }
            }

        }
        public void OzellikYazdir()
        {
            Console.WriteLine(base.GetOlusturulmaTarihi() + " tarihinde oluşturulan Eşkenar Üçgen sınıfı--> kenar= " + GetKenar()+ " Alan= " + AlanHesapla() + " Çevre " + CevreHesapla());
        }                   
    }
}
