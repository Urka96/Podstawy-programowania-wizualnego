using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class KlasaPostaci
    {
        //KlasaPostaci(ID, opis, moc, obrona udźwig).
        public int ID;
        public string opis;
        public double moc;
        public double obrona;
        public double udźwig;

        public KlasaPostaci()
        { }

        public KlasaPostaci(int ID, string opis, double moc, double obrona, double udźwig) //glowny konstruktor tworzenia klasy w oknie postaci
        {
            this.ID = ID;
            this.opis = opis;
            this.moc = moc;
            this.obrona = obrona;
            this.udźwig = udźwig;
        }

    }
}
