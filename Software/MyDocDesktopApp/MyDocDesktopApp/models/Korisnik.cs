using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocDesktopApp.models
{
    public abstract class Korisnik : Object
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Kontakt { get; set; }
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
