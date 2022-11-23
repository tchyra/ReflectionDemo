using ReflectionDemo.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ReflectionDemo
{
    public partial class FrmMain : Form
    {
        private BindingList<Osoba> _osoby;
        private BindingList<Zamowienie> _zamowienia;

        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadData();
        }

        // tworzy przykładowe dane przy starcie formatki
        public void LoadData()
        {
            _osoby = new BindingList<Osoba>()
            {
                new Osoba("Jan", "Kowalski", 31, true),
                new Osoba("Agata", "Jesion", 18, false),
                new Osoba("Witold", "Potencjusz", 68, true)
            };

            _dgvOsoby.DataSource = _osoby;


            _zamowienia = new BindingList<Zamowienie>()
            {
                new Zamowienie("Z-12314", 2, 10, false),
                new Zamowienie("Z-88192", 578, 981, false),
                new Zamowienie("Z-54123", 419, 419, true)
            };

            _dgvZamowienia.DataSource = _zamowienia;
        }


        #region osoby

        // kliknięcie "dodaj" nad listą osób
        private void _btnOsobyDodaj_Click(object sender, EventArgs e)
        {
            var osoba = new Osoba();                        // utwórz obiekt osoby
            var edytor = new FrmUniversalEditor(osoba);     // utwórz edytor dla osoby
            if (edytor.ShowDialog() == DialogResult.OK)
            {
                _osoby.Add(osoba);                          // jeżeli wciśnięto zapisz, dodaj obiekt do listy
            }
        }

        // kliknięcie "edytuj" nad listą osób
        private void _btnOsobyEdytuj_Click(object sender, EventArgs e)
        {
            if (_dgvOsoby.SelectedRows.Count != 1) return;                  // jeżeli nie jest zaznaczona tylko jedna osoba, wyjdź

            var osoba = (Osoba)_dgvOsoby.SelectedRows[0].DataBoundItem;     // weź zaznaczoną osobę z wiersza datagridview
            var edytor = new FrmUniversalEditor(osoba);                     // utwórz edytor dla osoby

            if (edytor.ShowDialog() == DialogResult.OK)
            {
                osoba.NotifyAllPropertiesChanged();                         // jeśli wciśnięto zapisz, powiadom o zmianie w danych osoby
            }
        }

        #endregion


        #region zamówienia

        // kliknięcie "dodaj" nad listą zamówień
        private void _btnZamowieniaDodaj_Click(object sender, EventArgs e)
        {
            var zamowienie = new Zamowienie();                  // utwórz obiekt zamówienia
            var edytor = new FrmUniversalEditor(zamowienie);    // utwórz edytor dla zamówienia
            if (edytor.ShowDialog() == DialogResult.OK)
            {
                _zamowienia.Add(zamowienie);                    // jeżeli wciśnięto zapisz, dodaj zamówienie do listy
            }
        }

        // kliknięcie "edytuj" nad listą zamówień
        private void _btnZamowieniaEdytuj_Click(object sender, EventArgs e)
        {
            if (_dgvZamowienia.SelectedRows.Count != 1) return;                         // jeżeli nie jest zaznaczona tylko jedne zamówienie, wyjdź

            var zamowienie = (Zamowienie)_dgvZamowienia.SelectedRows[0].DataBoundItem;  // weź zaznaczone zamówienie z wiersza datagridview
            var edytor = new FrmUniversalEditor(zamowienie);                            // utwórz edytor dla zamówienia

            if (edytor.ShowDialog() == DialogResult.OK)
            {
                zamowienie.NotifyAllPropertiesChanged();                                // jeśli wciśnięto zapisz, powiadom o zmianie w danych zamówienia
            }
        }

        #endregion
    }
}
