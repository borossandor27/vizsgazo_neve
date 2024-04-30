using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        List<Dolgozo> dolgozok = new List<Dolgozo>();
        Adatbazis db = new Adatbazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaFrissitese();
        }

        private void listaFrissitese()
        {
            listBox_dolgozok.Items.Clear();
            dolgozok = db.getAllDolgozo();
            listBox_dolgozok.Items.AddRange(dolgozok.ToArray());
        }

        private void listBox_dolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dolgozo dolgozo = (Dolgozo)listBox_dolgozok.SelectedItem;
            textBox_Nev.Text = dolgozo.nev;
            textBox_Nem.Text = dolgozo.neme;
            textBox_Reszleg.Text = dolgozo.reszleg;
            numericUpDown_BelepesEve.Value = dolgozo.belepesev;
            numericUpDown_Ber.Value = dolgozo.ber;
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            string nev = textBox_Nev.Text;
            string nem = textBox_Nem.Text;
            string reszleg = textBox_Reszleg.Text;
            int belepes = (int)numericUpDown_BelepesEve.Value;
            int ber = (int)numericUpDown_Ber.Value;
            db.insertDolgozo(nev, nem, reszleg, belepes, ber);
        }
    }
}
