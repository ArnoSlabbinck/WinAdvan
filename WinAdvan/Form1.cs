using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAdvan
{
    public partial class Form1 : Form
    {

        List<Werknemer> werknemers = new List<Werknemer>();
        Werknemer werknemer = new Werknemer();
        Salaris salaris;
        public Form1()
        {
            InitializeComponent();
            Werknemer werknemer1 = new Werknemer("Geert", salaris = new Salaris("WeekContract"));
            Werknemer werknemer2 = new Werknemer("Frank", 2200, salaris = new Salaris());
            Werknemer werknemer3 = new Werknemer("Daniel", "Nederland", salaris = new Salaris("Weekcontract"));
            Werknemer werknemer4 = new Werknemer("Sofia", "Nederland", 3110, salaris = new Salaris());
            werknemers.Add(werknemer1);
            werknemers.Add(werknemer2);
            werknemers.Add(werknemer3);
            werknemers.Add(werknemer4);

            comboBox1.DataSource = werknemers;
            comboBox1.DisplayMember = "Naam";

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            werknemer = comboBox1.SelectedItem as Werknemer;
            

            if (!(werknemer is null))
            {
                
                listBox1.Items.Add(werknemer.Herkomst);
                listBox1.Items.Add(werknemer._Salaris);
                listBox1.Items.Add(werknemer.NettoBedrag());
                listBox1.Items.Add(werknemer.Contract());

                

            }

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Enabled = true;
         
            

            

        }
    }
}
