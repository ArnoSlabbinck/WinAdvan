using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAdvan
{
    class Salaris
    {
        private string soortContract = "Maandcontract";

        public string SoortContract {
            get { return soortContract; }
            set { soortContract = value; }
        }

        private double brutobedrag = 2440.55;

        public double Brutobedrag
        {
            get { return brutobedrag; }
            set { brutobedrag = value; }
        }


        private int btwPercentage = 21;

        public int BtwPercentage {
            get { return btwPercentage; }
            set { btwPercentage = value; }
        }
        public Salaris(string _contract)
        {
            soortContract = _contract;
        }
        public Salaris(double _brutobedrag, int _btw, string _contract)
        {
            brutobedrag = _brutobedrag;
            btwPercentage = _btw;
            soortContract = _contract;
        }

        public Salaris()
        { }

        public Salaris(double _brutobedrag)
        {
            brutobedrag = _brutobedrag;
        }
        public double BerekenNetto()
        {
            return Math.Round(brutobedrag - (brutobedrag * btwPercentage/100),2);
        }

        public override string ToString()
        {
            return $"Brutobedrag: {brutobedrag}\n" +
                $"Nettobedrag: {BerekenNetto()}";
        }

    }
}
