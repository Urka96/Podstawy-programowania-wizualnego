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
    public partial class OknoPostaci : Form
    {
        List<Postać> listaPos = new List<Postać>();  //lista obiektów klasy Postać
        List<KlasaPostaci> listaKlas = new List<KlasaPostaci>(); //lista przechowująca bazowe klasy postaci
        public int Id = 0;  //zmienna "automatyczny identyfikator postaci"
        Postać wybrany; //obiekt klasy postac - wysylany do okna glownego

        public OknoPostaci()
        {
            InitializeComponent();
            StwórzKlasyPostaci();
        }

        public void StwórzKlasyPostaci() //metoda na tworzenie odgornie 3 klas postaci i dodająca je do comboboxa (z którego użytkownik od razu może wybrać klase) oraz listy przechowujacej wszystkie dane
        {
            KlasaPostaci mag = new KlasaPostaci(0, "Magowie to potężni czarownicy, używający wszelakich przedmiotów magicznych do walki, niebezpieczni w bezpośrednim starciu z nie-magami.", 30, 15, 16);
            listaKlas.Add(mag);
            WybórKlasaPostaci.Items.Add("Mag");
            KlasaPostaci tropiciel = new KlasaPostaci(1, "Tropiciel profesjonalnie posługuje się łukami oraz kuszami, dzięki czemu może eliminować przeciwników z ukrycia.", 25, 15, 20);
            listaKlas.Add(tropiciel);
            WybórKlasaPostaci.Items.Add("Tropiciel");
            KlasaPostaci wojownik = new KlasaPostaci(2, "Wojownik jest najskuteczniejszy w walce wręcz dzięki swojej niebywałej sile, może używać broni jednoręcznych i dwuręcznych.", 20, 25, 20);
            listaKlas.Add(wojownik);
            WybórKlasaPostaci.Items.Add("Wojownik");
        }

        private void StwórzPostać_Click(object sender, EventArgs e) //przycisk tworzenia postaci
        {//Postać(pola: ID, Imię, lvl, Moc, Obrona, Opis, Udźwig, klasaPostaci)
            bool czydobre = Sprawdz();
            if(!czydobre) { return; } //sprawdzenie czy podane wartosci sa prawidlowe, jesli nie-zakoncz działanie
            string imię = ImięPos.Text;
            int lvl = Int32.Parse(LevelPos.Text);
            string opis = OpisPos.Text;
            string klasa = WybórKlasaPostaci.SelectedItem.ToString(); //do zmiennych lokalnych przypisujemy wartosci wprowadzone/wybrane przez użytkownika
            double moc = listaKlas[WybórKlasaPostaci.SelectedIndex].moc;
            double obrona = listaKlas[WybórKlasaPostaci.SelectedIndex].obrona;
            double udźwig = listaKlas[WybórKlasaPostaci.SelectedIndex].udźwig; //bazowe wartosci pochodzace z klas postaci
           // MessageBox.Show(moc.ToString(), obrona.ToString());
            Postać nowaPostać = new Postać(Id, imię, lvl, opis, klasa, moc, obrona, udźwig);
            nowaPostać.ZwiekszWartosc(lvl); //wywołanie metody zwiekszajacej bazowe wartosci na podstawie lvl
            listaPos.Add(nowaPostać);
            ListaPostaci.Items.Add(imię);
            Id++;
        }

        private void ListaPostaci_SelectedIndexChanged(object sender, EventArgs e) //wybor elementu (postaci) z comboboxa i wyswietlenie go w textboxach
        {
            Postać wyswietlony = listaPos[ListaPostaci.SelectedIndex];
            ImięPos.Text = wyswietlony.Imię;
            LevelPos.Text = wyswietlony.Level.ToString();
            OpisPos.Text = wyswietlony.Opis;
            WybórKlasaPostaci.Text = wyswietlony.klasaPostaci;
            MocPos.Text = wyswietlony.Moc.ToString();
            ObronaPos.Text = wyswietlony.Obrona.ToString();
            UdźwigPos.Text = wyswietlony.Udźwig.ToString();
        }

        private void Usuń_Click(object sender, EventArgs e) //przycisk usuwania wybranej postaci
        {
            if(listaPos.Count == 0 || ListaPostaci.SelectedItem == null)
            { MessageBox.Show("Brak elementu do usunięcia!"); return; }
            listaPos.RemoveAt(ListaPostaci.SelectedIndex);
            ListaPostaci.Items.Remove(ListaPostaci.SelectedItem);
            WyczyśćTextBoxyiComboboxy();
        }

        private void Edytuj_Click(object sender, EventArgs e) //przycisk edycji postaci - aktualizuje dane 
        {
            if(listaPos.Count == 0 || ListaPostaci.SelectedItem == null) //sprawdzenie czy wybrano postac z listy
            { MessageBox.Show("Brak postaci do edycji!"); return; }
            bool czydobre = Sprawdz(); //sprawdzenie czy pola są uzupełnione odpowiednimi wartosciami
            if (!czydobre) { return; }
            Postać edytowana = listaPos[ListaPostaci.SelectedIndex]; //aktualizacja danych
            edytowana.Imię = ImięPos.Text;
            edytowana.Level = Int32.Parse(LevelPos.Text);
            edytowana.Opis = OpisPos.Text;
            edytowana.klasaPostaci = WybórKlasaPostaci.SelectedItem.ToString();
            edytowana.Moc = listaKlas[WybórKlasaPostaci.SelectedIndex].moc;
            edytowana.Obrona = listaKlas[WybórKlasaPostaci.SelectedIndex].obrona;
            edytowana.Udźwig = listaKlas[WybórKlasaPostaci.SelectedIndex].udźwig;
            edytowana.ZwiekszWartosc(edytowana.Level);
            ListaPostaci.Items[ListaPostaci.SelectedIndex] = edytowana.Imię; //jesli zmienione imie - jego aktualizacja w comboboxie (+ jesli zmieniony lvl, to pola mocy obrony udzwigu tez sie zaktualizuja)
            if (wybrany != null && wybrany.ID == edytowana.ID) //jesli edytowana postac byla wczesniej wybrana i wyswietlona w oknie glownym to wyswietl komunikat o zmianie (info w oknie głownym sie nie zmieni dopoki jeszcze raz nie wybierze sie przycisku wyboru postaci)
            { MessageBox.Show("Uwaga: zmieniono dane wybranej wcześniej postaci." + Environment.NewLine + "Jeśli chcesz zaktualizować te dane w oknie głównym, kliknij ponownie \"Wybierz postać\" (bieżące ustawienia w oknie głównym zostaną usunięte)."); }
        }

        private void Odczyt_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Encoding enc = Encoding.GetEncoding("Windows-1250");//zmiana kodowania do prawidlowego wczytania polskich znakow
                try
                {
                    if (listaPos != null) //wczytujac plik, czyscimy textboxy itd  
                    {
                        ListaPostaci.DropDownHeight = 106;
                        WyczyśćTextBoxyiComboboxy();
                    }
                    List<Postać> tmp = new List<Postać>(listaPos); //lista przechowujaca stan sprzed dodawania postaci
                    string[] filelines = File.ReadAllLines(file, enc); //kazda linia jest kolejnym elementem tablicy, jedna linia-jedna postac
                    size = filelines.Length;
                    if (size == 0) { MessageBox.Show("Pusty plik!"); return; }
                    for (int i = 0; i < size; i++) //petla po tablicy z liniami pliku 
                    {
                        string[] dane = filelines[i].Split(';'); //tablica przechowujaca kolejne dane przedmiotow, dzieli po ';'
                        if(dane.Length != 7) { MessageBox.Show("Nieprawidłowy format pliku!"); return; }
                        bool czydobre = SprawdzPlik(dane);
                        if (!czydobre)
                        { //jesli jakas postac jest zle zapisana w pliku - usun dotychczas dodane dane
                            listaPos = tmp;
                            ListaPostaci.Items.Clear();
                            for (int j = 0; j < listaPos.Count; j++)
                            { ListaPostaci.Items.Add(listaPos[j].Imię); }
                            ListaPostaci.DropDownHeight = 106;
                            return; } 
                        Postać nowy = new Postać(Id, dane[0], Int32.Parse(dane[1]), dane[2], dane[3], double.Parse(dane[4]), double.Parse(dane[5]), double.Parse(dane[6]));
                        Id++;
                        ListaPostaci.Items.Add(dane[0]);
                        listaPos.Add(nowy);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Błąd odczytu pliku!");
                    return;
                }
            }
        }

        private void Zapis_Click(object sender, EventArgs e)
        {
            if(listaPos.Count == 0)
            { MessageBox.Show("Brak postaci do zapisu!"); return; }
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            string text = "";
            string[] tab = new string[listaPos.Count];

            for (int i = 0; i < listaPos.Count; i++)
            {
                Postać nowy = listaPos[i];
                text = (nowy.Imię + ';' + nowy.Level.ToString() + ';' + nowy.Opis + ';' + nowy.klasaPostaci + ';' + nowy.Moc.ToString() + ';' + nowy.Obrona.ToString() + ';' + nowy.Udźwig.ToString());
                tab[i] = text;
            }
            File.WriteAllLines(name, tab, Encoding.UTF8); //zapis do pliku z odpowiednim kodowaniem (by przy otwieraniu pliku były polskie znaki)
        }

        private void WyczyśćTextBoxyiComboboxy() //czyszczenie textboxów (przy usuwaniu elementu i wczytywaniu pliku)
        {
            ImięPos.Clear();
            LevelPos.Clear();
            OpisPos.Clear();
            MocPos.Clear();
            ObronaPos.Clear();
            UdźwigPos.Clear();
            ListaPostaci.Text = "";
            WybórKlasaPostaci.Text = "";
        }

        private void OknoPostaci_FormClosing(object sender, FormClosingEventArgs e) //user nie moze zamknac okna postaci
        {
            e.Cancel = true;
        }

        private OknoGłówne mainForm = null;

        public OknoPostaci(Form callform) //konstruktor - komunikacja z oknem głównym
        {
            mainForm = callform as OknoGłówne;   
            InitializeComponent();
            StwórzKlasyPostaci();
        }

        private void WybierzPos_Click(object sender, EventArgs e) //przycisk wyboru postaci - user wybiera postać z listy (combobox), która jest nastepnie wysyłana i wyświetlana w oknie głównym
        {           
            if(listaPos.Count == 0)
            { MessageBox.Show("Brak postaci na liście! Nie ma z czego wybierać!"); return; }
            if(ListaPostaci.SelectedItem == null)
            { MessageBox.Show("Wybierz postać z listy!"); return; }
            wybrany = listaPos[ListaPostaci.SelectedIndex];
            //string text = (nowy.Imię + ';' + nowy.Level.ToString() + ';' + nowy.Opis + ';' + nowy.klasaPostaci + ';' + nowy.Moc.ToString() + ';' + nowy.Obrona.ToString() + ';' + nowy.Udźwig.ToString());
            this.mainForm.Wybrana = wybrany;
        }

        public void WczytajPostać(Postać nowa) //metoda dodająca postac z okna głównego do listy postaci w przypadku wczytywania gotowej postaci z pliku 
        {
            Postać nowaPostać = nowa;
            listaPos.Add(nowaPostać);
            ListaPostaci.Items.Add(nowaPostać.Imię);
        }

        public bool Sprawdz() //metoda sprawdzajaca textboxy, comboboxy
        {
            if(ImięPos.Text == "" || LevelPos.Text == "" || OpisPos.Text == "" || WybórKlasaPostaci.SelectedItem == null)
            { MessageBox.Show("Pole nie może być puste!"); return false; }
            if(ImięPos.Text.Length < 4 || ImięPos.Text.Length > 15) { MessageBox.Show("Podaj imię od 4 do 15 liter"); return false; }
            int result;
            if (!Int32.TryParse(LevelPos.Text, out result)) { MessageBox.Show("Level musi być liczbą!"); return false; }
            if (Int32.Parse(LevelPos.Text) < 0 || Int32.Parse(LevelPos.Text) > 99) { MessageBox.Show("Niepoprawny level! (0-99)"); return false; }
            if(OpisPos.Text.Length < 3 || OpisPos.Text.Length > 100) { MessageBox.Show("Długość opisu spoza zakresu (3-100 znaków)!"); return false; }
            if(ImięPos.Text.Contains(";") || OpisPos.Text.Contains(";")) { MessageBox.Show("Pola nie mogą zawierać znaku \";\""); return false; }
            return true;
        }

        public bool SprawdzPlik(string[] dane)
        {
            if (dane[0] == "" || dane[1] == "" || dane[2] == "" || dane[3] == "" || dane[4] == "" || dane[5] == "" || dane[6] == "")
            { MessageBox.Show("Brak wartości pola postaci!"); return false; }
            if (dane[0].Length < 4 || dane[0].Length > 15) { MessageBox.Show("Nieprawidłowa długość imienia!"); return false; }
            int result;
            if (!Int32.TryParse(dane[1], out result)) { MessageBox.Show("Level musi być liczbą!"); return false; }
            if (Int32.Parse(dane[1]) < 0 || Int32.Parse(dane[1]) > 99) { MessageBox.Show("Niepoprawny level! (0-99)"); return false; }
            if (dane[2].Length < 3 || dane[2].Length > 100) { MessageBox.Show("Długość opisu spoza zakresu (3-100 znaków)!"); return false; }
            if (dane[3] != "Tropiciel" && dane[3] != "Mag" && dane[3] != "Wojownik") { MessageBox.Show("Niepoprawna klasa postaci!"); return false; }
            double result2;
            if (!double.TryParse(dane[4], out result2) || !double.TryParse(dane[5], out result2) || !double.TryParse(dane[6], out result2)) { MessageBox.Show("Nieprawidłowa wartość mocy/obrony/udźwigu!"); return false; }
            int id = 0;
            if(dane[3] == "Tropiciel") { id = 1; }
            if(dane[3] == "Wojownik") { id = 2; } //w zaleznosci od wybranej klasy, bierzemy jej wartosci bazowe mocy/obrony/udzwigu do stworzenia nowej postaci
            Postać nowy = new Postać(0, dane[0], Int32.Parse(dane[1]), dane[2], dane[3], listaKlas[id].moc, listaKlas[id].obrona, listaKlas[id].udźwig);      //tworzymy nową postac na podstawie wartosci z tablicy i porownujemy moc/obrone/udzwig jakie powinny być na postawie levelu postaci a wartosciami z pliku, czy sa takie same
            nowy.ZwiekszWartosc(Int32.Parse(dane[1]));
            if ((nowy.Moc.ToString() != dane[4]) || (nowy.Obrona.ToString() != dane[5]) || (nowy.Udźwig.ToString() != dane[6])) { MessageBox.Show("Niepoprawne wartości mocy/obrony/udźwigu w zależności od levelu postaci!"); return false; }
            return true;
        }
    }
}
