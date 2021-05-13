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

namespace Projekt //dodatkowe Tooltip'y dla przycisków i textboxów we wszystkich oknach
{
    public partial class OknoGłówne : Form
    {
        private Postać nowy;    //wybrana postac
        private List<Przedmiot> listaPrzedm = new List<Przedmiot>(); //lista do odbierania danych z okna przedmiotow
        List<Przedmiot> listaWybrPrz = new List<Przedmiot>(); //lista juz wybranych przez uzytkownika przedmiotow
        OknoPrzedmiotów lista_przedmiotow;
        OknoPostaci lista_postaci;

        public OknoGłówne()
        {
            InitializeComponent();
            lista_postaci = new OknoPostaci(this);
            lista_postaci.Show();
            lista_przedmiotow = new OknoPrzedmiotów(this);
            lista_przedmiotow.Show();
        }

        public Postać Wybrana  //wlasciwosc do ustawienia wybranej postaci (komunikacja z oknem postaci)
        {
            get { return nowy; }
            set {
                nowy = value;  //przypisanie danych obiektu klasy wybranej przez uzytkownika (komunikacja z oknem postaci)
                string text = ("Imię: " + nowy.Imię + Environment.NewLine + "Level: " + nowy.Level.ToString() + Environment.NewLine + "Opis: " + nowy.Opis + Environment.NewLine + "Klasa postaci: " + nowy.klasaPostaci + Environment.NewLine + "Moc: " + nowy.Moc.ToString() + Environment.NewLine + "Obrona: " + nowy.Obrona.ToString() + Environment.NewLine + "Udźwig: " + nowy.Udźwig.ToString());
                Info.Text = text; //wypisanie informacji o postaci w oknie głównym
                Wyczyść();
            }
        }

        public List<Przedmiot> Lista //wlasciwosc do ustawienia listy przedmiotow (komunikacja z oknem przedmiotow)
        {
            get { return listaPrzedm; }
            set
            {
                listaPrzedm = value; //przypisanie zmiennej globalnej wartosci listy z okna przedmiotow-komunikacja miedzy oknami
            }
        }

        private void WczytajPrzedmioty_Click(object sender, EventArgs e) //dostawa - wczytanie przedmiotow z okna przedmiotow
        {
            if(Info.Text == "") { MessageBox.Show("Najpierw wybierz postać!"); return; }
            lista_przedmiotow.WyślijListę(); //wczytanie listy przedmiotow
            ListaPrzedmiotówSklep.Items.Clear();
            if (listaPrzedm.Count == 0) 
            {
                MessageBox.Show("Brak dostawy!");
                return;
            }

            if (listaWybrPrz.Count == 0) //jesli nie ma zadnych wybranych przedmiotow to po prostu wpisujemy kolejno przedmioty do listboxa
            {
                for (int i = 0; i < listaPrzedm.Count; i++)
                {
                    ListaPrzedmiotówSklep.Items.Add(listaPrzedm[i].Nazwa + " [" + listaPrzedm[i].Wymagania + "]"); //dodajemy przedmioty do listboxa w zakładce sklepu (dostepne przedmioty w sklepie)
                }
            }
            else //jesli sa juz jakies wybrane przedmioty dla postaci
            {
                int tmp = listaPrzedm.Count;
                for(int i = tmp-1; i >= 0; i--) //idziemy od konca listy z okna przedmiotow
                {
                    bool czy_istnieje = false;
                    for(int j = 0; j < listaWybrPrz.Count; j++)
                    {
                        if(listaPrzedm[i].ID == listaWybrPrz[j].ID) //jesli przedmioty sa takie same (unikalne id)
                        {
                            czy_istnieje = true;
                            break;
                        }
                    }
                    if(czy_istnieje == false) //jesli nie ma przedmiotu na liscie wybranych, wstawiamy go do listboxa
                    {
                        ListaPrzedmiotówSklep.Items.Insert(0, listaPrzedm[i].Nazwa + " [" + listaPrzedm[i].Wymagania + "]");
                    }
                    else { listaPrzedm.RemoveAt(i); } //jesli przedmiot z listy juz istnieje na liscie wybranych to usuwamy go ze sklepu 
                }
            }
        }

        private void ListaPrzedmiotówSklep_SelectedIndexChanged(object sender, EventArgs e) { }
        
        private void DodajDoListy_Click(object sender, EventArgs e) //przycisk przenoszenia przedmiotu ze sklepu do "plecaka" - wybor przedmiotow dla postaci
        {
            if (listaPrzedm.Count == 0)     //jesli nie ma nic w sklepie lub user nic nie wybral z listy, wyswietl odpowiednie komunikaty
            { MessageBox.Show("Brak dostępnych przedmiotów w sklepie!"); return; }
            if (ListaPrzedmiotówSklep.SelectedItem == null)
            { MessageBox.Show("Wybierz przedmiot!"); return; }
            Przedmiot wybrany = listaPrzedm[ListaPrzedmiotówSklep.SelectedIndex];
            if(!SprawdzPrzedmiot(wybrany))  //sprawdz czy zgodny z klasą/udźwigiem/listą wybranych
            { return; }
            ListaWybranychPrzedmiotów.Items.Add(wybrany.Nazwa);         //dodanie przedmiotu do listy wybranych i usuniecie go ze sklepu
            listaWybrPrz.Add(wybrany);
            listaPrzedm.RemoveAt(ListaPrzedmiotówSklep.SelectedIndex);
            ListaPrzedmiotówSklep.Items.RemoveAt(ListaPrzedmiotówSklep.SelectedIndex);
        }

        private void UsuńzListy_Click(object sender, EventArgs e) //przycisk przenoszenia przedmiotu z 'plecaka' do sklepu
        {
            if (ListaWybranychPrzedmiotów.Items.Count == 0)     //jesli nie ma nic w plecaku lub user nic nie wybral z listy, wyswietl odpowiednie komunikaty
            { MessageBox.Show("Brak dostępnych przedmiotów w ekwipunku!"); return; }
            if (ListaWybranychPrzedmiotów.SelectedItem == null)
            { MessageBox.Show("Wybierz przedmiot!"); return; }
            Przedmiot wybrany = listaWybrPrz[ListaWybranychPrzedmiotów.SelectedIndex]; //przenoszenie jak przy dodawaniu
            listaPrzedm.Add(wybrany);
            ListaPrzedmiotówSklep.Items.Add(wybrany.Nazwa + "[" + wybrany.Wymagania + "]");
            listaWybrPrz.RemoveAt(ListaWybranychPrzedmiotów.SelectedIndex);
            ListaWybranychPrzedmiotów.Items.RemoveAt(ListaWybranychPrzedmiotów.SelectedIndex);
        }

        private void DodajPrzedmiotyDoPostaci_Click(object sender, EventArgs e) //przycisk dodawania wybranych przedmiotow ze sklepu do ekwipunku postaci
        {
            if(Info.Text == "")
            {
                MessageBox.Show("Najpierw wybierz postać!");
                return;
            }
            if (listaWybrPrz.Count == 0)
            {
                MessageBox.Show("Wybierz przedmioty ze sklepu!");
                return;
            }
            if(PrzedmiotyPostaci.Items.Count > 0) //jesli user zmienia wybor przedmiotow po wczesniejszym ich potwierdzeniu - usun przedmioty znajdujace sie aktualnie w ekwipunku (aktualizacja)
            {
                PrzedmiotyPostaci.Items.Clear();
            }
            double udzwig = 0;
            double moc = nowy.Moc;
            double obrona = nowy.Obrona; //zmienne opisujące postac w zakładce ekwipunku
            for(int i = 0; i < listaWybrPrz.Count; i++)
            {
                PrzedmiotyPostaci.Items.Add(listaWybrPrz[i].Nazwa); //dodanie przedmiotow do listy posiadanych przedmiotow w zakładce ekwipunku
                udzwig += listaWybrPrz[i].Waga; //waga wszystkich wybranych przedmiotow
                if(listaWybrPrz[i].Typ == "broń") //jesli typ = bron, zwiekszamy moc na podstawie bonusu. w przeciwnym razie obrone
                { moc += listaWybrPrz[i].Bonus; }
                else { obrona += listaWybrPrz[i].Bonus; }
            }
            IlośćPrzedmiotów.Text = PrzedmiotyPostaci.Items.Count.ToString(); //wyswietlanie informacji o postaci(ilosc przedmiotow, udzwig, moc i obrona)
            UdźwigPostaci.Text = udzwig.ToString() + "/" + nowy.Udźwig.ToString();
            MocIObrona.Text = moc.ToString() + " ; " + obrona.ToString();
        }

        private void Wykres_Click(object sender, EventArgs e) //przycisk do wyswietlania wykresu dla wybranego przedmiotu ze sklepu w nowym oknie
        { //przyjmujemy ze za wzrost wartosci mocy i obrony jest odpowiedzialna wartosc bonusu (w zaleznosci od typu przedmiotu, dla broni zwiększa tylko moc, dla reszty (czesci pancerza) - obrone)
            if(ListaPrzedmiotówSklep.Items.Count == 0)
            { MessageBox.Show("Brak przedmiotów w sklepie!"); return; }
            if(ListaPrzedmiotówSklep.SelectedItem == null)
            {
                MessageBox.Show("Wybierz przedmiot z listy wyżej!"); return;
            }
            Przedmiot wybrany = listaPrzedm[ListaPrzedmiotówSklep.SelectedIndex];
            if (wybrany.Wymagania != nowy.klasaPostaci) //jesli przedmiot nie jest dla danej klasy - nie ma po co wyswietlac wykresu
            { MessageBox.Show("Wybrany przedmiot nie jest przeznaczony dla klasy postaci " + nowy.klasaPostaci); return; }
            double[] tab = new double[4]; //tworzymy tablice dla mocy i obrony
            if(MocIObrona.Text != "") //jesli juz mamy jakies wybrane przedmioty w ekwipunku, wartosciami bazowymi dla wykresu sa powiekszone moc i obrona (wartosci bazowe postaci + bonusy z przedmiotow) 
            {
                string[] tmp = MocIObrona.Text.Split(';');
                tab[0] = double.Parse(tmp[0]);
                tab[1] = double.Parse(tmp[1]);
                if (wybrany.Typ == "broń") { tab[2] = wybrany.Bonus + double.Parse(tmp[0]); tab[3] = 1; } //jesli bonus zmienia tylko moc, to ostatni element tablicy jest rowny 1
                else { tab[2] = wybrany.Bonus + double.Parse(tmp[1]); tab[3] = 2; }  //jesli zmienia obrone, tab[3]=2
            }
            else //w przeciwnym razie bierzemy bazowe wartosci mocy i obrony postaci przeslanej z okna postaci
            {
                tab[0] = nowy.Moc;
                tab[1] = nowy.Obrona;   //bazowe wartosci
                if (wybrany.Typ == "broń") { tab[2] = wybrany.Bonus + nowy.Moc; tab[3] = 1; } //jak wyzej
                else { tab[2] = wybrany.Bonus + nowy.Obrona; tab[3] = 2; }  
            }
            
            Wykres wykres = new Wykres(tab);
            wykres.Show();
        }

        public void Wyczyść() //metoda do czyszczenia textboxow, listboxow i list
        {
            Wyszukiwarka.Clear();
            PrzedmiotyPostaci.Items.Clear();
            ListaWybranychPrzedmiotów.Items.Clear();
            ListaPrzedmiotówSklep.Items.Clear();
            IlośćPrzedmiotów.Text = "";
            UdźwigPostaci.Text = "";
            MocIObrona.Text = "";
            listaWybrPrz.Clear();
        }

        private void Zapisz_Click(object sender, EventArgs e) //zapis gotowej postaci do pliku
        {
            if (Info.Text == "") { MessageBox.Show("Brak postaci do zapisu!"); return; }
            if (PrzedmiotyPostaci.Items.Count == 0) { MessageBox.Show("Brak gotowej postaci do zapisu!"); return; } //lub listaWybrPrz.count == 0
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            string text = "";
            string[] tab = new string[listaWybrPrz.Count+4]; //musimy zapisac wszystkie wybrane przedmioty + 4 informacje z okna glownego wyswietlane po lewej stronie 
            tab[0] = (nowy.Imię + ';' + nowy.Level.ToString() + ';' + nowy.Opis + ';' + nowy.klasaPostaci + ';' + nowy.Moc.ToString() + ';' + nowy.Obrona.ToString() + ';' + nowy.Udźwig.ToString());
            tab[1] = IlośćPrzedmiotów.Text;
            tab[2] = UdźwigPostaci.Text; 
            tab[3] = MocIObrona.Text;
            for (int i = 0; i < listaWybrPrz.Count; i++)
            {
                Przedmiot nowy = listaWybrPrz[i];
                text = (nowy.Nazwa + ';' + nowy.Typ + ';' + nowy.Opis + ';' + nowy.Wymagania + ';' + nowy.Bonus.ToString() + ';' + nowy.Właściwości + ';' + nowy.Waga.ToString());// + Environment.NewLine);
                tab[i+4] = text;
            }
            File.WriteAllLines(name, tab, Encoding.UTF8); //zapis do pliku z odpowiednim kodowaniem (by przy otwieraniu pliku były polskie znaki)
        }

        private void Wczytaj_Click(object sender, EventArgs e) //odczyt gotowej postaci z pliku + "dostawa" czyli wczytanie aktualnego stanu sklepu(listy przedmiotow z okna przedmiotow)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                Encoding enc = Encoding.GetEncoding("Windows-1250");//zmiana kodowania do prawidlowego wczytania polskich znakow
                try
                {
                    if (Info.Text != "") //wczytujac plik, usuwamy wszystkie dotychczasowe dane w oknie gł - nadpisanie danych  
                    {
                        Info.Text = "";
                        Wyczyść();
                    }
                    string[] filelines = File.ReadAllLines(file, enc); //kazda linia jest kolejnym elementem tablicy
                    size = filelines.Length;
                    if(size == 0 || size < 4) { MessageBox.Show("Zły format pliku!"); return; }
                    string[] dane = filelines[0].Split(';'); //tablica przechowujaca kolejne dane przedmiotow (1 linia pliku), dzieli po ';'
                    if (dane.Length != 7) { MessageBox.Show("Nieprawidłowy format pliku!"); return; }
                    if (!lista_postaci.SprawdzPlik(dane)) { return; } //sprawdzamy info o postaci z pliku za pomoca metody z okna postaci

                    if (nowy == null)    //jeśli od razu odpalamy wczytywanie, bez wczesniejszego wyboru postaci, musimy stworzyć jakąkolwiek postać żeby nie była z wartością null
                    { nowy = new Postać(0, "Arya", 10, "przykładowy opis", "Tropiciel", 30, 30, 30); }
                    nowy.Imię = dane[0]; nowy.Level = Int32.Parse(dane[1]); nowy.Opis = dane[2];  nowy.klasaPostaci = dane[3]; nowy.Moc = double.Parse(dane[4]); nowy.Obrona = double.Parse(dane[5]); nowy.Udźwig = double.Parse(dane[6]);
                    Info.Text = ("Imię: " + nowy.Imię + Environment.NewLine + "Level: " + nowy.Level.ToString() + Environment.NewLine + "Opis: " + nowy.Opis + Environment.NewLine + "Klasa postaci: " + nowy.klasaPostaci + Environment.NewLine + "Moc: " + nowy.Moc.ToString() + Environment.NewLine + "Obrona: " + nowy.Obrona.ToString() + Environment.NewLine + "Udźwig: " + nowy.Udźwig.ToString());

                    for (int i = 4; i < size; i++) //petla po tablicy z liniami pliku, licznik 'i' bedzie takze ID kolejnych elementow 
                    {
                        string[] danep = filelines[i].Split(';'); //tablica przechowujaca kolejne dane przedmiotow, dzieli po ';'
                        if (danep.Length != 7) { Info.Text = ""; MessageBox.Show("Nieprawidłowy format pliku!"); return; }
                        if(!lista_przedmiotow.SprawdzPlik(danep)) { Info.Text = ""; Wyczyść(); return; } //jak wyzej - sprawdzenie przedmiotow za pomoca metody z okna przedmiotow, jak ktorys zły to usun wszystkie dodane wczesniej dane
                        Przedmiot nowyPrz = new Przedmiot(i-4, danep[0], danep[1], danep[2], danep[3], Int32.Parse(danep[4]), danep[5], Int32.Parse(danep[6]));
                        PrzedmiotyPostaci.Items.Add(danep[0]);
                        listaWybrPrz.Add(nowyPrz);
                    }
                    
                    if(!SprawdzDane(nowy, listaWybrPrz, filelines)) { Info.Text = ""; Wyczyść(); return; }
                    IlośćPrzedmiotów.Text = filelines[1];
                    UdźwigPostaci.Text = filelines[2];
                    MocIObrona.Text = filelines[3];
                    for (int i = 0; i < listaWybrPrz.Count; i++) //jesli wszystkie przedmioty i reszta pliku sa ok, zmieniamy im unikalne id na postawie id z okna przedmiotow
                    {
                        listaWybrPrz[i].ID = lista_przedmiotow.Id;
                        lista_przedmiotow.Id++;
                        ListaWybranychPrzedmiotów.Items.Add(listaWybrPrz[i].Nazwa);
                    }
                    
                    nowy.ID = lista_postaci.Id; //to samo z postacia
                    lista_postaci.Id++;
                    
                    lista_przedmiotow.WyślijListę(); //wczytanie listy przedmiotow do sklepu
                    for(int i = 0; i < listaPrzedm.Count; i++) //wczytujemy do sklepu wszystkie dostepne przedmioty z wyjatkiem tych ostatnio wczytanych i dodanych do wybranych
                    {
                        ListaPrzedmiotówSklep.Items.Add(listaPrzedm[i].Nazwa + " [" + listaPrzedm[i].Wymagania + "]"); //dodajemy przedmioty do listboxa w zakładce sklepu (dostepne przedmioty w sklepie)
                    }
                    //dodajemy postac i przedmioty do odpowiednich okienek tylko gdy caly plik jest w porzadku
                    lista_postaci.WczytajPostać(nowy);  //metoda - dodanie postaci do listy postaci w oknie postaci
                    lista_przedmiotow.WczytajPrzedmioty(listaWybrPrz);  //metoda - dodanie wszystkich przedmiotow z listy wybranych przedmiotow do listy z okna przedmiotów

                }
                catch (IOException)
                {
                    MessageBox.Show("Błąd odczytu pliku!");
                    return;
                }
            }
        }

        private void Wyszukaj_Click(object sender, EventArgs e) //przycisk do wyszukiwania postaci po nazwie w zakładce ekwipunku
        {
            if(PrzedmiotyPostaci.Items.Count == 0)
            {
                MessageBox.Show("Brak elementów na liście!"); return;
            }
            string szukany = Wyszukiwarka.Text;
            int index = PrzedmiotyPostaci.Items.IndexOf(szukany); //szukamy indeksu wpisanej nazwy (na liscie wybranych przedmiotow)
            if(index == -1) //jesli nie istnieje na liscie
            {
                MessageBox.Show("Nie znaleziono przedmiotu!"); return;
            }
            PrzedmiotyPostaci.SelectedIndex = index; //jak istnieje to zostanie zaznaczony i wyswietla sie informacje o nim
        }

        private void PrzedmiotyPostaci_SelectedIndexChanged(object sender, EventArgs e) //po kliknieciu na przedmiot z listy wyswietli nam sie wiadomosc z informacjami o tym przedmiocie
        {
            Przedmiot wybrany = listaWybrPrz[PrzedmiotyPostaci.SelectedIndex];
            MessageBox.Show("Nazwa: " + wybrany.Nazwa + Environment.NewLine + "Typ: " + wybrany.Typ + Environment.NewLine + "Opis: " + wybrany.Opis + Environment.NewLine + "Wymagania: " + wybrany.Wymagania + Environment.NewLine + "Bonus: " + wybrany.Bonus.ToString() + Environment.NewLine + "Właściwości: " + wybrany.Właściwości + Environment.NewLine + "Waga: " + wybrany.Waga.ToString());
        }

        public bool SprawdzDane(Postać nowa, List<Przedmiot> lista, string[] dane)
        {
            double udzwig = 0;
            double moc = nowa.Moc;
            double obrona = nowa.Obrona; //zmienne opisujące postac 
            for (int i = 0; i < lista.Count; i++)
            {
                udzwig += lista[i].Waga; //waga wszystkich wybranych przedmiotow
                if (lista[i].Typ == "broń") //jesli typ = bron, zwiekszamy moc na podstawie bonusu. w przeciwnym razie obrone
                { moc += lista[i].Bonus; }
                else { obrona += lista[i].Bonus; }
            }

            if(lista.Count.ToString() != dane[1]) { MessageBox.Show("Różna ilość przedmiotów!"); return false; }
            string text = (udzwig.ToString() + "/" + nowa.Udźwig.ToString());
            if(text != dane[2]) { MessageBox.Show("Różna wartość udźwigu!"); return false; }
            string text2 = (moc.ToString() + " ; " + obrona.ToString());
            if(text2 != dane[3]) { MessageBox.Show("Różna wartość mocy/obrony!"); return false; }
            return true;
        }

        public bool SprawdzPrzedmiot(Przedmiot przedmiot) //metoda na sprawdzenie czy postac moze wybrac dany przedmiot
        {
            if(przedmiot.Wymagania != nowy.klasaPostaci) //jesli klasa postaci nie jest rowna wymaganiom przedmiotu (dla jakiej klasy jest przedmiot)
            { MessageBox.Show("Przedmiot dostępny dla klasy " + przedmiot.Wymagania); return false; }
            for(int i = 0; i < listaWybrPrz.Count; i++)
            {
                if(przedmiot.Typ == listaWybrPrz[i].Typ) //przyjmujemy że postac nie moze nosic wiecej niz 1 helm/pancerz/bron/spodnie czy 1 pare rekawic/butow
                { MessageBox.Show("Na liście wybranych znajduje/ą się już " + przedmiot.Typ); return false; } 
            }
            double waga = 0;
            for(int i = 0; i < listaWybrPrz.Count; i++) //zliczamy wage wszystkich przedmiotow z listy wybranych
            {
                waga += listaWybrPrz[i].Waga;
            }
            if(nowy.Udźwig < waga+przedmiot.Waga)
            { MessageBox.Show("Nie można dodać przedmiotu - przekroczono udźwig postaci. (" + (waga+przedmiot.Waga).ToString() + "/" + nowy.Udźwig.ToString() + ")"); return false; }

            return true; 
        }
    }
}
