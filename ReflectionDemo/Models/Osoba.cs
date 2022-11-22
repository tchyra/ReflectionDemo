using System.ComponentModel;

namespace ReflectionDemo.Models
{
    public class Osoba
    {
        public int Id { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public int Wiek { get; set; }

        public bool CzyMezczyzna { get; set; }

        public Osoba() { }

        public Osoba(string imie, string nazwisko, int wiek, bool czyMezczyzna)
        {
            Id = _idCounter++;

            Imie = imie;
            Nazwisko = nazwisko;

            Wiek = wiek;

            CzyMezczyzna = czyMezczyzna;
        }

        private static int _idCounter = 1;
    }
}
