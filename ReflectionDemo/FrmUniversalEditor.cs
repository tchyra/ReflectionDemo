using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace ReflectionDemo
{
    // formatka obsługująca edycję dowolnego obiektu jaki dostanie w konstruktorze
    // automatycznie generuje UI dla wszystkich właściwości mających atrubyt [DisplayName]
    // zaimplementowano dla:
    //  - string
    //  - int
    //  - bool
    public partial class FrmUniversalEditor : Form
    {
        // obiekt aktualnie edytowany w edytorze, nie wspieramy zmiany w trakcie działania
        private readonly object _edytowanyObiekt;
        private readonly Type _typEdytowanegoObiektu;

        // nazwa właściwości -> kontrolka edytora
        private Dictionary<string, Control> _kontrolkiDlaWlasciwosci = new Dictionary<string, Control>();

        // konstruktor przyjmujący obiekt do edycji
        public FrmUniversalEditor(object obiektDoEdycji)
        {
            // upewniamy się, że dostaliśmy obiekt do edycji
            if (obiektDoEdycji == null)
                throw new ArgumentNullException(nameof(obiektDoEdycji));

            // zapamiętujemy obiekt i jego typ
            _edytowanyObiekt = obiektDoEdycji;
            _typEdytowanegoObiektu = obiektDoEdycji.GetType();

            // inicjalizacja formatki zrobionej w designerze
            InitializeComponent();

            // zatrzymaj układanie (wystarczy raz ułożyć wszystkie kontrolki na koniec)
            _flpControls.SuspendLayout();

            // utwórz pola edytora
            UtworzKontrolki();

            // wznów układanie (ułóż kontrolki)
            _flpControls.ResumeLayout();
        }

        // tworzy i dodaje do flow layout panelu kontrolki dla każdej właściwości edytowanego obiektu mającej atrubyt [DisplayName]
        private void UtworzKontrolki()
        {
            // pobieramy wszystkie właściwości klasy
            var properties = _typEdytowanegoObiektu.GetProperties();

            // lecimy pętlą po właściwościach
            foreach (var property in properties)
            {
                // bierzemy atrybut [DisplayName] (albo null, jeżeli nie ma)
                var displayNameAttribute = property.GetCustomAttribute<DisplayNameAttribute>();

                // jeżeli nie ma atrybutu, pomijamy właściwość
                if (displayNameAttribute == null) continue;

                // pobieramy wartość dla właściwości (typ object)
                var wartosc = property.GetValue(_edytowanyObiekt);

                // tworzymy zmienną do której wpiszemy kontrolkę edytującą daną właściwość
                Control kontrolka;

                // wywołujemy odpowiednią funkcję tworzącą kontrolkę dla właściwości w zależności od jej typu

                if (property.PropertyType == typeof(string))
                {
                    kontrolka = StworzKontrolkiDlaWlasciwosciString(displayNameAttribute.DisplayName, (string)wartosc);
                }
                else if (property.PropertyType == typeof(int))
                {
                    kontrolka = StworzKontrolkiDlaWlasciwosciInt(displayNameAttribute.DisplayName, (int)wartosc);
                }
                else if (property.PropertyType == typeof(bool))
                {
                    kontrolka = StworzKontrolkiDlaWlasciwosciBool(displayNameAttribute.DisplayName, (bool)wartosc);
                }
                else
                {
                    throw new NotImplementedException($"Właściwość {property.Name} ma atrubyt [DisplayName], ale obsługa jej typu ({property.PropertyType.Name}) nie jest zaimplementowana.");
                }

                // zapisujemy kontrolkę służącą do edycji danej właściwości
                _kontrolkiDlaWlasciwosci[property.Name] = kontrolka;

                // następna właściwość
            }
        }

        // tworzy label i textbox dla właściwości string
        private Control StworzKontrolkiDlaWlasciwosciString(string nazwa, string wartosc)
        {
            var label = new Label()
            {
                Text = nazwa,
                Margin = new Padding(0, 0, 0, 2),
                AutoSize = true
            };

            var textbox = new TextBox()
            {
                Text = wartosc,
                Margin = new Padding(0, 0, 0, 8)
            };

            _flpControls.Controls.Add(label);
            _flpControls.Controls.Add(textbox);

            return textbox;
        }

        // tworzy label i numeric up and down dla właściwości int
        private Control StworzKontrolkiDlaWlasciwosciInt(string nazwa, int wartosc)
        {
            var label = new Label()
            {
                Text = nazwa,
                Margin = new Padding(0, 0, 0, 2),
                AutoSize = true
            };

            var nud = new NumericUpDown()
            {
                Value = wartosc,
                Margin = new Padding(0, 0, 0, 8)
            };

            _flpControls.Controls.Add(label);
            _flpControls.Controls.Add(nud);

            return nud;
        }

        // tworzy checkbox dla właściwości bool
        private Control StworzKontrolkiDlaWlasciwosciBool(string nazwa, bool wartosc)
        {
            var checkbox = new CheckBox()
            {
                Text = nazwa,
                Checked = wartosc,
                Margin = new Padding(0, 0, 0, 8)
            };


            _flpControls.Controls.Add(checkbox);

            return checkbox;
        }


        // obsługuje przepisanie wartości z kontrolek edytora do właściwości edytowanego obiektu
        private void Save()
        {
            // przechodzimy po wpisach w słowniku nazwa właściwości -> kontrolka
            foreach (var entry in _kontrolkiDlaWlasciwosci)
            {
                var nazwaWlasciwosci = entry.Key;
                var kontrolka = entry.Value;

                // ładujemy informację o właściwości za pomocą jej nazwy
                var property = _typEdytowanegoObiektu.GetProperty(nazwaWlasciwosci);

                // wyciągamy wartość z kontrolki w zależności od typu

                if (property.PropertyType == typeof(string))
                {
                    var textbox = (TextBox)kontrolka;
                    property.SetValue(_edytowanyObiekt, textbox.Text);
                }
                else if (property.PropertyType == typeof(int))
                {
                    var nud = (NumericUpDown)kontrolka;
                    property.SetValue(_edytowanyObiekt, (int)nud.Value);
                }
                else if (property.PropertyType == typeof(bool))
                {
                    var checkbox = (CheckBox)kontrolka;
                    property.SetValue(_edytowanyObiekt, checkbox.Checked);
                }
                else
                {
                    throw new NotImplementedException($"Właściwość {property.Name} ma atrubyt [DisplayName], ale obsługa jej typu ({property.PropertyType.Name}) nie jest zaimplementowana.");
                }
            }
        }

        // zamyka formatkę bez zapisywania
        private void _btnAnuluj_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // zapisuje i zamyka formatkę
        private void _btnZapisz_Click(object sender, EventArgs e)
        {
            Save();
            DialogResult = DialogResult.OK;
        }
    }
}
