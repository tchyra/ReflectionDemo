using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Models
{
    public class Zamowienie
    {
        public string Numer { get; set; }

        public int LiczbaSztukZrealizowanych { get; set; }
        public int LiczbaSztuk { get; set; }

        public bool CzyZakonczone { get; set; }

        public Zamowienie(string numer, int liczbaSztukZrealizowanych, int liczbaSztuk, bool czyZakonczone)
        {
            Numer = numer;
            LiczbaSztukZrealizowanych = liczbaSztukZrealizowanych;
            LiczbaSztuk = liczbaSztuk;
            CzyZakonczone = czyZakonczone;
        }
    }
}
