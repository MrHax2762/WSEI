using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Firma
    {
        public Firma()
        {
        }
        public int FirmaID { get; set; }
        public string Nazwa { get; set; }
        public decimal Kapital { get; set; }
        public float Kod { get; set; }
        public Adres Adres { get; set; }
    }

    public class Adres
    {
        public Adres()
        {

        }
        public int AdresID { get; set; }
        public int Numer { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
    }
    
}