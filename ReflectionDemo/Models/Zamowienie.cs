using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo.Models
{
    public class Zamowienie : NotifyingObject
    {
        [DisplayName("Numer")]
        public string Numer { get; set; }

        [DisplayName("Zrealizowano")]
        public int LiczbaSztukZrealizowanych { get; set; }

        [DisplayName("Łącznie sztuk")]
        public int LiczbaSztuk { get; set; }

        [DisplayName("Czy zakończone")]
        public bool CzyZakonczone { get; set; }

        public Zamowienie() { }

        public Zamowienie(string numer, int liczbaSztukZrealizowanych, int liczbaSztuk, bool czyZakonczone)
        {
            Numer = numer;
            LiczbaSztukZrealizowanych = liczbaSztukZrealizowanych;
            LiczbaSztuk = liczbaSztuk;
            CzyZakonczone = czyZakonczone;
        }
    }
}
