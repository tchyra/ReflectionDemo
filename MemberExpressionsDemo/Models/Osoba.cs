using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberExpressionsDemo.Models
{
    // przykładowa klasa modelu osoby
    public class Osoba
    {
        [DisplayName("Imię")]
        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        [DisplayName("Miejsce urodzenia")]
        public string MiejsceUrodzenia { get; set; }
        
        [DisplayName("Imię ojca")]
        public string ImieOjca { get; set; }

        [DisplayName("Nazwisko panieńskie matki")]
        public string NazwiskoPanienskieMatki { get; set; }
    }
}
