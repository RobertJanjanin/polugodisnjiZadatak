using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polugodisnjiZadatak
{
    public partial class Form1 : Form
    {
        List<Unos> Unos = new List<Unos>();

        string format = "{0, -30} {1, -30} {2, -30} {3, -30} {4, -30}";
        public Form1()
        {
            InitializeComponent();
        }





        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(textBoxIme.Text) || string.IsNullOrWhiteSpace(textBoxPrezime.Text) || string.IsNullOrWhiteSpace(textBoxGodiste.Text) || string.IsNullOrWhiteSpace(comboBoxSpol.Text)) 
            {
                MessageBox.Show("Unjeli ste krive podatke", "Greska", MessageBoxButtons.OK);
                return;            }

            string Ime = textBoxIme.Text;

            string Prezime = textBoxPrezime.Text;

            int Godiste;

            string Spol = comboBoxSpol.Text;

            bool jeliGodisteBroj = int.TryParse(textBoxGodiste.Text, out Godiste);

            if (jeliGodisteBroj == false)
            {
                MessageBox.Show("Uijeli ste neispravne podatke.", "Greška", MessageBoxButtons.OK);
                return;
            }

            Unos.Add(new Unos(Ime, Prezime, Godiste, Spol));
        }

        private void buttonIspisi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format(format, "Ime", "Prezime", "Godiste", "Spol", "Status"));
            
            foreach(Unos unos in Unos)
            {
                listBox1.Items.Add(unos.Ispis());
            
            }
        }

        private void buttonObradi_Click(object sender, EventArgs e)
        {
            foreach (Unos unos in Unos)
            {
                unos.Provjera();
            }
        }
    }
}
