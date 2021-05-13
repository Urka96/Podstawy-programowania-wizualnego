using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Wykres : Form
    {
        public Wykres()
        {
            InitializeComponent();
        }

        public Wykres(double[] wartosci)
        {
            double[] elementy = wartosci; //wczytanie tablicy z wartosciami mocy i obrony
            InitializeComponent();
            string bazowy = "Wartość bazowa";
            string zmodyfikowany = "Modyfikacja";
            WykresPrz.Series["Moc"].Points.AddXY(bazowy, elementy[0]);
            WykresPrz.Series["Obrona"].Points.AddXY(bazowy, elementy[1]);
            if (elementy[3] == 1) //jesli przedmiot wplywa na moc to tylko ona sie zmienia
            {
                WykresPrz.Series["Moc"].Points.AddXY(zmodyfikowany, elementy[2]);
                WykresPrz.Series["Obrona"].Points.AddXY(zmodyfikowany, elementy[1]);
            }
            else //zmienia sie tylko obrona
            {
                WykresPrz.Series["Moc"].Points.AddXY(zmodyfikowany, elementy[0]);
                WykresPrz.Series["Obrona"].Points.AddXY(zmodyfikowany, elementy[2]);
            }
        }
    }
}
