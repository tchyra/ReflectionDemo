using ReflectionDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionDemo
{
    public partial class FrmMain : Form
    {
        private List<Osoba> _osoby;
        private List<Zamowienie> _zamowienia;

        public FrmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            _osoby = new List<Osoba>()
            {
                new Osoba("Jan", "Kowalski", 31, true),
                new Osoba("Agata", "Jesion", 18, false),
                new Osoba("Witold", "Potencjusz", 68, true)
            };

            _dgvOsoby.DataSource = _osoby;


            _zamowienia = new List<Zamowienie>()
            {
                new Zamowienie("Z-12314", 2, 10, false),
                new Zamowienie("Z-88192", 578, 981, false),
                new Zamowienie("Z-54123", 419, 419, true)
            };

            _dgvZamowienia.DataSource = _zamowienia;
        }
    }
}
