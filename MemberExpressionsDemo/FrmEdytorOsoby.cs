using MemberExpressionsDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemberExpressionsDemo
{
    public partial class FrmEdytorOsoby : Form
    {
        // osoba edytowana przez ten edytor
        private Osoba _osoba;

        public FrmEdytorOsoby()
        {
            InitializeComponent();

            // tworzenie osoby do testów (normalnie byłaby przekazana w argumencie)
            _osoba = new Osoba()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                ImieOjca = "Artur",
                MiejsceUrodzenia = "Opole",
                NazwiskoPanienskieMatki = "Joanna"
            };

            // wyłączenie układania kontrolek, stworzenie UI, ułożenie kontrolek raz na koniec
            _flpControls.SuspendLayout();
            CreateControls();
            _flpControls.ResumeLayout();
        }

        // tworzy kontrolki dla odpowiednich właściwości klasy Osoba
        private void CreateControls()
        {
            // dodanie kolejnych kontrolek dla właściwości
            // TODO: to wyglada brzydko
            _flpControls.Controls.AddRange(CreateControlsFor(o => o.Imie));
            _flpControls.Controls.AddRange(CreateControlsFor(o => o.Nazwisko));
            _flpControls.Controls.AddRange(CreateControlsFor(o => o.ImieOjca));
        }

        // tworzy kontrolki dla właściwości wskazanej wyrażeniem
        private Control[] CreateControlsFor(Expression<Func<Osoba, object>> expression)
        {
            // konwersja na MemberExpression
            var memberExpr = (MemberExpression)expression.Body;
            // pobranie właściwości z MemberExpression
            var prop = (PropertyInfo)memberExpr.Member;
            // pobranie atrybutu [DisplayName] z właściwości
            var displayAttr = prop.GetCustomAttribute<DisplayNameAttribute>();

            // wyświetlana nazwa z atrybutu, jeśli nie ma, nazwa właściwości
            var displayName = displayAttr?.DisplayName ?? prop.Name;
            // pobranie wartości właściwości z obiektu osoby
            var value = prop.GetValue(_osoba);

            // tworzenie kontrolek dla różnych typów właściwości (zaimplementowano tylko string)
            if (prop.PropertyType == typeof(string))
            {
                return CreateTextBoxControls(displayName, (string)value);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        // tworzenie kontrolek textboxa dla danej wyświetlanej nazwy i początkowego tekstu
        private Control[] CreateTextBoxControls(string displayName, string text)
        {
            var label = new Label()
            {
                Text = displayName,
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 3)
            };

            var textbox = new TextBox()
            {
                Text = text,
                Margin = new Padding(0, 0, 0, 8)
            };

            return new Control[] { label, textbox };
        }
    }
}
