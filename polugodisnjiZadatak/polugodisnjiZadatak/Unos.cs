using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polugodisnjiZadatak
{
    class Unos
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public int Godiste { get; set; }

        public string Spol { get; set; }

        public string Status { get; set; }

        public Unos(string ime, string prezime, int godiste, string spol)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Godiste = godiste;
            this.Spol = spol;
        

        }

        public void Provjera()
        {
            if (2020 - this.Godiste < 18)
            {
                this.Status = "Mulac";
            }
            else if (this.Ime == "Ana")
            {
                this.Status = "Banana";
            }
            else if (this.Spol == "M")
            {
                this.Status = "Gaser";
            }
        }

        public string Ispis()
        {
            string format = "{0, -30} {1, -30} {2, -30} {3, -30} {4, -30}";

            string ispis = string.Format(format, this.Ime, this.Prezime, this.Godiste, this.Spol, this.Status);

            return ispis;
        }
    }
}
