using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Postać 
    {
        //Postać(pola: ID, Imię, lvl, Moc, Obrona, Opis, Udźwig, klasaPostaci)
        public int ID;
        public string Imię;
        public int Level;
        public double Moc;
        public double Obrona;
        public string Opis;
        public double Udźwig;
        public string klasaPostaci;

        public Postać(int ID, string Imię, int Level, string Opis, string klasaPostaci, double Moc, double Obrona, double Udźwig) 
        {
            this.ID = ID;
            this.Imię = Imię;
            this.Level = Level;
            this.Opis = Opis;
            this.klasaPostaci = klasaPostaci;
            this.Moc = Moc;
            this.Obrona = Obrona;
            this.Udźwig = Udźwig;
        }

        public void ZwiekszWartosc(int Level) //metoda zwiekszajaca bazowa wartosc mocy/obrony/udzwigu 
        {
            if (Level == 0) //jak zerowy lvl to wartosci sie nie zmieniaja
            {
                return;
            }
            else //jak wiekszy to każdy kolejny lvl zwieksza bazowe wartosci o 5% od aktualnej wartosci
            {
                double moc = Moc;
                double obrona = Obrona;
                double udźwig = Udźwig;
                for (int i = 0; i < Level; i++)
                {
                    double wartosc1 = Math.Round(((5 * moc) / 100), 1);
                    moc += wartosc1;
                    double wartosc2 = Math.Round(((5 * obrona) / 100), 1);
                    obrona += wartosc2;
                    double wartosc3 = Math.Round(((5 * udźwig) / 100), 1);
                    udźwig += wartosc3;
                }
                Moc = moc;
                Obrona = obrona;
                Udźwig = udźwig;
            }
        }

    }
}
