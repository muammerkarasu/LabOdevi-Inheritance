using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOdev5 {
        public class Sekiller
        {
            private char sembol; 
            private bool doluMu; 
            private string olusturulmaTarihi;
            
            public Sekiller()
            {
                sembol = '*';
                olusturulmaTarihi = DateTime.Now.ToString("dd.MM.yyyy");
            }

            public Sekiller(char sembol)
            {
                this.sembol = sembol;
            }

            public Sekiller(char sembol, bool doluMu)
            {
                this.sembol = sembol;
                this.doluMu = doluMu;
            }

            public void SetSembol(char sembol)
            {
                this.sembol = sembol;
            }
            public char GetSembol()
        {
            return this.sembol;
        }
            public void SetDoluMu(bool doluMu)
            {
                this.doluMu = doluMu;
            }

            public bool GetDoluMu()
            {
                return doluMu;
            }

            public string GetOlusturulmaTarihi()
            {
                return olusturulmaTarihi;
            }
        }
    }
