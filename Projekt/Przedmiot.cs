using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Przedmiot
    {
        // (pola: ID, Nazwa, Typ, Opis, Wymagania, Bonus, Właściwości, Waga)
        public int ID;
        public string Nazwa;
        public string Typ;
        public string Opis;
        public string Wymagania;
        public double Bonus;
        public string Właściwości;
        public double Waga; 

        public Przedmiot(int ID, string Nazwa, string Typ, string Opis, string Wymagania, double Bonus, string Właściwości, double Waga)
        {
            this.ID = ID;
            this.Nazwa = Nazwa;
            this.Typ = Typ;
            this.Opis = Opis;
            this.Wymagania = Wymagania;
            this.Bonus = Bonus;
            this.Właściwości = Właściwości;
            this.Waga = Waga;
        }


    }
}
