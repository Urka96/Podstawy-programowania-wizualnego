using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Projekt
{
    public partial class OknoPrzedmiotów : Form
    {
        List<Przedmiot> listaPrz = new List<Przedmiot>(); //lista obiektow klasy Przedmiot
        public int Id = 0;  //automatyczny identyfikator

        public OknoPrzedmiotów()
        {
            InitializeComponent();
        }

        private OknoGłówne mainForm = null;

        public OknoPrzedmiotów(Form callform) // komunikacja
        {
            mainForm = callform as OknoGłówne;
            InitializeComponent();
        }

        public void WyślijListę() //metoda z której korzysta okno główne - 'pobiera' aktualną listę przedmiotów do sklepu
        {
            List<Przedmiot> lista = new List<Przedmiot>(listaPrz); //duplikacja listy - aby nie modyfikowac oryginalnej (w oknie glownym)
            this.mainForm.Lista = lista;
        }
      
        // (pola: ID, Nazwa, Typ, Opis, Wymagania, Bonus, Właściwości, Waga)
        private void DodajPrz_Click(object sender, EventArgs e) //przycisk stworzenia nowego przedmiotu
        {
            bool czydobre = Sprawdz();
            if (!czydobre) { return; }
            string nazwa = NazwaPrz.Text;
            string typ = TypPrz.Text;
            string opis = OpisPrz.Text;             //przypisanie do zmiennych określonych textboxow
            string wymagania = WymaganiaPrz.Text;
            double bonus = double.Parse(BonusPrz.Text);
            string właściwości = WłaściwościPrz.Text;
            double waga = double.Parse(WagaPrz.Text);
            Przedmiot nowyPrzedmiot = new Przedmiot(Id, nazwa, typ, opis, wymagania, bonus, właściwości, waga); //stworzenie obiektu klasy i dodanie go do listy
            ListaPrzedmiotów.Items.Add(nazwa); //combobox
            listaPrz.Add(nowyPrzedmiot);    //lista przedmiotow
           // MessageBox.Show(Id.ToString() + Environment.NewLine + nazwa + Environment.NewLine + typ + Environment.NewLine + opis + Environment.NewLine + wymagania + Environment.NewLine + bonus.ToString() + Environment.NewLine + właściwości + Environment.NewLine + waga.ToString());
            Id++;
        }

        private void EdytujPrz_Click(object sender, EventArgs e) //przycisk edycji przedmiotu - aktualizacja danych
        {
            if (listaPrz.Count == 0 || ListaPrzedmiotów.SelectedItem == null) //sprawdzenie czy wybrano przedmiot z listy
            { MessageBox.Show("Brak przedmiotu do edycji!"); return; }
            bool czydobre = Sprawdz(); //sprawdzenie czy pola są uzupełnione odpowiednimi wartosciami
            if (!czydobre) { return; }
            Przedmiot edytowany = listaPrz[ListaPrzedmiotów.SelectedIndex];
            edytowany.Nazwa = NazwaPrz.Text;
            edytowany.Typ = TypPrz.Text;
            edytowany.Opis = OpisPrz.Text;              //jak z postaciami
            edytowany.Wymagania = WymaganiaPrz.Text;
            edytowany.Bonus = double.Parse(BonusPrz.Text);
            edytowany.Właściwości = WłaściwościPrz.Text;
            edytowany.Waga = double.Parse(WagaPrz.Text);
            ListaPrzedmiotów.Items[ListaPrzedmiotów.SelectedIndex] = edytowany.Nazwa;
        }

        private void ListaPrzedmiotów_SelectedIndexChanged(object sender, EventArgs e) //na podstawie wybranego przedmiotu wyświetlenie jego parametrów w textboxach
        {
            Przedmiot wyswietlony = listaPrz[ListaPrzedmiotów.SelectedIndex];
            NazwaPrz.Text = wyswietlony.Nazwa;
            TypPrz.Text = wyswietlony.Typ;
            OpisPrz.Text = wyswietlony.Opis;
            WymaganiaPrz.Text = wyswietlony.Wymagania;
            BonusPrz.Text = wyswietlony.Bonus.ToString();
            WłaściwościPrz.Text = wyswietlony.Właściwości;
            WagaPrz.Text = wyswietlony.Waga.ToString();
            // MessageBox.Show(wyswietlony.ID.ToString() + Environment.NewLine + ListaPrzedmiotów.SelectedIndex.ToString());
        }

        private void UsuńPrz_Click(object sender, EventArgs e) //przycisk usuwania przedmiotu
        {
            if (listaPrz.Count == 0 || ListaPrzedmiotów.SelectedItem == null)
            { MessageBox.Show("Brak elementu do usunięcia!"); return; }
            listaPrz.RemoveAt(ListaPrzedmiotów.SelectedIndex);  //usuwanie z listy, comboboxa i wyczyszczenie textboxow
            ListaPrzedmiotów.Items.Remove(ListaPrzedmiotów.SelectedItem);
            WyczyśćTextBoxy();
        }

        private void OdczytPrz_Click(object sender, EventArgs e) //wczytywanie pliku
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Encoding enc = Encoding.GetEncoding("Windows-1250"); //zmiana kodowania do prawidlowego wczytania polskich znakow
                try
                {
                    if (listaPrz != null) //wczytujac plik, dopisujemy do istniejacych danych 
                    {
                        ListaPrzedmiotów.DropDownHeight = 106; //zmienia rozmiar comboboxa, nie wyswietla sie dluga lista tylko scroll
                        WyczyśćTextBoxy();
                        ListaPrzedmiotów.Text = "";
                    }
                    List<Przedmiot> tmp = new List<Przedmiot>(listaPrz); //lista przechowujaca stan sprzed dodawania przedmiotow
                    string[] filelines = File.ReadAllLines(file, enc); //kazda linia jest kolejnym elementem tablicy
                    size = filelines.Length;
                    if (size == 0) { MessageBox.Show("Pusty plik!"); return; }
                    for (int i = 0; i < size; i++) //petla po tablicy z liniami pliku
                    {
                        string[] dane = filelines[i].Split(';'); //tablica przechowujaca kolejne dane przedmiotow, dzieli po ';'
                        if (dane.Length != 7) { MessageBox.Show("Nieprawidłowy format pliku!"); return; }
                        bool czydobre = SprawdzPlik(dane);
                        if (!czydobre)
                        { //jak ktorykolwiek przedmiot zle zapisany w pliku - usun wszystkie dotychczas dodane dane
                            listaPrz = tmp;
                            ListaPrzedmiotów.Items.Clear();
                            for(int j = 0; j < listaPrz.Count; j++)
                            { ListaPrzedmiotów.Items.Add(listaPrz[j].Nazwa); }
                            ListaPrzedmiotów.DropDownHeight = 106;
                            return; } 
                        Przedmiot nowy = new Przedmiot(Id, dane[0], dane[1], dane[2], dane[3], double.Parse(dane[4]), dane[5], double.Parse(dane[6]));
                        Id++;
                        ListaPrzedmiotów.Items.Add(dane[0]);
                        listaPrz.Add(nowy);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Błąd odczytu pliku!");
                    return;
                }
            }
        }

        private void ZapisPrz_Click(object sender, EventArgs e) //zapis do pliku
        {
            if (listaPrz.Count == 0)
            { MessageBox.Show("Brak przedmiotu do zapisu!"); return; }
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            string text = "";
            string[] tab = new string[listaPrz.Count];

            for (int i = 0; i < listaPrz.Count; i++)
            {
                Przedmiot nowy = listaPrz[i];
                text = (nowy.Nazwa + ';' + nowy.Typ + ';' + nowy.Opis + ';' + nowy.Wymagania + ';' + nowy.Bonus.ToString() + ';' + nowy.Właściwości + ';' + nowy.Waga.ToString());// + Environment.NewLine);
                tab[i] = text;
            }
            File.WriteAllLines(name, tab, Encoding.UTF8); //zapis do pliku z odpowiednim kodowaniem (by przy otwieraniu pliku były polskie znaki)
        }

        private void WyczyśćTextBoxy() //czyszczenie textboxów
        {
            NazwaPrz.Clear();
            TypPrz.Clear();
            OpisPrz.Clear();
            WymaganiaPrz.Clear();
            BonusPrz.Clear();
            WłaściwościPrz.Clear();
            WagaPrz.Clear();
        }

        private void OknoPrzedmiotów_FormClosing(object sender, FormClosingEventArgs e) //user nie moze zamknac okna przedmiotow
        {
            e.Cancel = true;
        }

        public void WczytajPrzedmioty(List<Przedmiot> lista) //metoda dodająca przedmioty do listy przedmiotów przy wczytywaniu gotowej postaaci z pliku
        {
            List<Przedmiot> nowa = new List<Przedmiot>(lista);
            for(int i = 0; i < nowa.Count; i++)
            {
                Przedmiot nowyPrzedmiot = new Przedmiot(nowa[i].ID, nowa[i].Nazwa, nowa[i].Typ, nowa[i].Opis, nowa[i].Wymagania, nowa[i].Bonus, nowa[i].Właściwości, nowa[i].Waga);
                ListaPrzedmiotów.Items.Add(nowa[i].Nazwa); //combobox
                listaPrz.Add(nowyPrzedmiot);    //lista przedmiotow
            }
        }

        public bool Sprawdz() //metoda sprawdzajaca textboxy
        {
            if (NazwaPrz.Text == "" || TypPrz.Text == "" || OpisPrz.Text == "" || WymaganiaPrz.Text == "" || BonusPrz.Text == "" || WłaściwościPrz.Text == "" || WagaPrz.Text == "")
            { MessageBox.Show("Pole nie może być puste!"); return false; }
            if (NazwaPrz.Text.Length < 4 || NazwaPrz.Text.Length > 30){ MessageBox.Show("Podaj nazwę od 4 do 15 liter!"); return false; }
            if (TypPrz.Text != "broń" && TypPrz.Text != "pancerz" && TypPrz.Text != "rękawice" && TypPrz.Text != "hełm" && TypPrz.Text != "spodnie" && TypPrz.Text != "buty") { MessageBox.Show("Nieprawidłowy typ przedmiotu!"); return false; }
            if (OpisPrz.Text.Length < 3 || OpisPrz.Text.Length > 100) { MessageBox.Show("Długość opisu spoza zakresu (3-100 znaków)!"); return false; }
            if (WymaganiaPrz.Text != "Tropiciel" && WymaganiaPrz.Text != "Mag" && WymaganiaPrz.Text != "Wojownik") { MessageBox.Show("Dostępne wymagania: Wojownik, Mag, Tropiciel!"); return false; }
            if (WłaściwościPrz.Text.Length < 5 || WłaściwościPrz.Text.Length > 30) { MessageBox.Show("Opis właściwości od 5 do 30 znaków!"); return false; }
            double result;
            if (!double.TryParse(BonusPrz.Text, out result) || !double.TryParse(WagaPrz.Text, out result)) { MessageBox.Show("Niepoprawny format bonusu/wagi!"); return false; }
            if (double.Parse(BonusPrz.Text) < 0 || double.Parse(BonusPrz.Text) > 999) { MessageBox.Show("Niepoprawna wartość bonusu! (0-999)"); return false; }
            if (double.Parse(WagaPrz.Text) < 0.2 || double.Parse(WagaPrz.Text) > 50) { MessageBox.Show("Niepoprawna wartość wagi! (0.2-50)"); return false; }
            if (NazwaPrz.Text.Contains(";") || OpisPrz.Text.Contains(";") || WłaściwościPrz.Text.Contains(";")) { MessageBox.Show("Pola nie mogą zawierać znaku \";\""); return false; }
            return true;
        }

        public bool SprawdzPlik(string[] dane) //metoda sprawdzająca dane z pliku, wszystko jak wyżej
        {
            if (dane[0] == "" || dane[1] == "" || dane[2] == "" || dane[3] == "" || dane[4] == "" || dane[5] == "" || dane[6] == "")
            { MessageBox.Show("Brak wartości pola przedmiotu!"); return false; }
            if (dane[0].Length < 4 || dane[0].Length > 30) { MessageBox.Show("Nieprawidłowa długość nazwy!"); return false; }
            if (dane[1] != "broń" && dane[1] != "pancerz" && dane[1] != "rękawice" && dane[1] != "hełm" && dane[1] != "spodnie" && dane[1] != "buty") { MessageBox.Show("Nieprawidłowy typ przedmiotu!" + dane[1]); return false; }
            if (dane[2].Length < 3 || dane[2].Length > 100) { MessageBox.Show("Nieprawidłowa długość opisu!"); return false; }
            if (dane[3] != "Tropiciel" && dane[3] != "Mag" && dane[3] != "Wojownik") { MessageBox.Show("Nieprawidłowa wartość wymagania!"); return false; }
            if (dane[5].Length < 5 || dane[5].Length > 30) { MessageBox.Show("Nieprawidłowa długość opisu właściwości!"); return false; }
            double result;
            if (!double.TryParse(dane[4], out result) || !double.TryParse(dane[6], out result)) { MessageBox.Show("Niepoprawny format bonusu/wagi!"); return false; }
            if (double.Parse(dane[4]) < 0 || double.Parse(dane[4]) > 999) { MessageBox.Show("Niepoprawna wartość bonusu!"); return false; }
            if (double.Parse(dane[6]) < 0.2 || double.Parse(dane[6]) > 50) { MessageBox.Show("Niepoprawna wartość wagi!"); return false; }
            return true;
        }
    }
}
