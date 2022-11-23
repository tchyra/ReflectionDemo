using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace ReflectionDemo.Models
{
    public class Osoba : NotifyingObject
    {
        public int Id { get; set; }

        [DisplayName("Imię")]
        public string Imie { get; set; }

        [DisplayName("Nazwisko")]
        public string Nazwisko { get; set; }

        [DisplayName("Wiek")]
        public int Wiek { get; set; }

        [DisplayName("Czy mężczyzna")]
        public bool CzyMezczyzna { get; set; }

        public Osoba()
        {
            Id = _idCounter++;
        }

        public Osoba(string imie, string nazwisko, int wiek, bool czyMezczyzna) : this()
        {
            Imie = imie;
            Nazwisko = nazwisko;

            Wiek = wiek;

            CzyMezczyzna = czyMezczyzna;
        }

        private static int _idCounter = 1;
    }
}
