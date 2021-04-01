using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAdvan
{
    class Werknemer
    {
        private Salaris salaris1;

        public Salaris Salaris
        {
            get { return salaris1; }
            set { salaris1 = value; }
        }
     
        private string naam;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        private double salaris;

        public double _Salaris
        {
            get { return salaris; }
            set {
                salaris = value;
            }
        }

        private string herkomst;

        public string Herkomst
        {
            get { return herkomst; }
            set {
                herkomst = value;

            }
        }

        public Werknemer()
        {
            salaris1 = new Salaris(salaris);
        }
        public Werknemer(string _naam, string _herkomst, double _salaris, Salaris Sal)
        {
            naam = _naam;
            herkomst = _herkomst;
            salaris = _salaris;
            salaris1 = Sal;
            salaris1.Brutobedrag = salaris;
        }
        public Werknemer(string _naam, Salaris Sal)
        {
            naam = _naam;
            salaris = 2440;
            herkomst = "Belgie";
            salaris1 = Sal;
        }
        public Werknemer(string _naam, string _herkomst, Salaris Sal)
        {
            naam = _naam;
            herkomst = _herkomst;
            salaris = 2440;
            salaris1 = Sal;
            

        }
        public Werknemer(string _naam, int salaris, Salaris Sal)
        {
            naam = _naam;
            this.salaris = salaris;
            herkomst = "Belgie";
            salaris1 = Sal;
            salaris1.Brutobedrag = salaris;
        }

        public double NettoBedrag()
        {
            return salaris1.BerekenNetto();
        }

        public string Contract()
        {
            return salaris1.SoortContract;

        }

    }
}
