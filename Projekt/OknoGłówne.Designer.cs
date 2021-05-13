namespace Projekt
{
    partial class OknoGłówne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Zakładki = new System.Windows.Forms.TabControl();
            this.EkwipunekGracza = new System.Windows.Forms.TabPage();
            this.MocIObrona = new System.Windows.Forms.Label();
            this.UdźwigPostaci = new System.Windows.Forms.Label();
            this.IlośćPrzedmiotów = new System.Windows.Forms.Label();
            this.PrzedmiotyPostaci = new System.Windows.Forms.ListBox();
            this.Zapisz = new System.Windows.Forms.Button();
            this.Wczytaj = new System.Windows.Forms.Button();
            this.Wyszukaj = new System.Windows.Forms.Button();
            this.Wyszukiwarka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.TextBox();
            this.Sklep = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Wykres = new System.Windows.Forms.Button();
            this.ListaWybranychPrzedmiotów = new System.Windows.Forms.ListBox();
            this.ListaPrzedmiotówSklep = new System.Windows.Forms.ListBox();
            this.DodajPrzedmiotyDoPostaci = new System.Windows.Forms.Button();
            this.DodajDoListy = new System.Windows.Forms.Button();
            this.UsuńzListy = new System.Windows.Forms.Button();
            this.WczytajPrzedmioty = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Zakładki.SuspendLayout();
            this.EkwipunekGracza.SuspendLayout();
            this.Sklep.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zakładki
            // 
            this.Zakładki.Controls.Add(this.EkwipunekGracza);
            this.Zakładki.Controls.Add(this.Sklep);
            this.Zakładki.Location = new System.Drawing.Point(-5, -1);
            this.Zakładki.Name = "Zakładki";
            this.Zakładki.SelectedIndex = 0;
            this.Zakładki.Size = new System.Drawing.Size(393, 333);
            this.Zakładki.TabIndex = 1;
            // 
            // EkwipunekGracza
            // 
            this.EkwipunekGracza.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EkwipunekGracza.Controls.Add(this.MocIObrona);
            this.EkwipunekGracza.Controls.Add(this.UdźwigPostaci);
            this.EkwipunekGracza.Controls.Add(this.IlośćPrzedmiotów);
            this.EkwipunekGracza.Controls.Add(this.PrzedmiotyPostaci);
            this.EkwipunekGracza.Controls.Add(this.Zapisz);
            this.EkwipunekGracza.Controls.Add(this.Wczytaj);
            this.EkwipunekGracza.Controls.Add(this.Wyszukaj);
            this.EkwipunekGracza.Controls.Add(this.Wyszukiwarka);
            this.EkwipunekGracza.Controls.Add(this.label4);
            this.EkwipunekGracza.Controls.Add(this.label3);
            this.EkwipunekGracza.Controls.Add(this.label2);
            this.EkwipunekGracza.Controls.Add(this.label1);
            this.EkwipunekGracza.Controls.Add(this.Info);
            this.EkwipunekGracza.Location = new System.Drawing.Point(4, 22);
            this.EkwipunekGracza.Name = "EkwipunekGracza";
            this.EkwipunekGracza.Padding = new System.Windows.Forms.Padding(3);
            this.EkwipunekGracza.Size = new System.Drawing.Size(385, 307);
            this.EkwipunekGracza.TabIndex = 0;
            this.EkwipunekGracza.Text = "Ekwipunek Gracza";
            // 
            // MocIObrona
            // 
            this.MocIObrona.AutoSize = true;
            this.MocIObrona.Location = new System.Drawing.Point(119, 209);
            this.MocIObrona.Name = "MocIObrona";
            this.MocIObrona.Size = new System.Drawing.Size(0, 13);
            this.MocIObrona.TabIndex = 14;
            // 
            // UdźwigPostaci
            // 
            this.UdźwigPostaci.AutoSize = true;
            this.UdźwigPostaci.Location = new System.Drawing.Point(119, 187);
            this.UdźwigPostaci.Name = "UdźwigPostaci";
            this.UdźwigPostaci.Size = new System.Drawing.Size(0, 13);
            this.UdźwigPostaci.TabIndex = 13;
            // 
            // IlośćPrzedmiotów
            // 
            this.IlośćPrzedmiotów.AutoSize = true;
            this.IlośćPrzedmiotów.Location = new System.Drawing.Point(119, 163);
            this.IlośćPrzedmiotów.Name = "IlośćPrzedmiotów";
            this.IlośćPrzedmiotów.Size = new System.Drawing.Size(0, 13);
            this.IlośćPrzedmiotów.TabIndex = 12;
            // 
            // PrzedmiotyPostaci
            // 
            this.PrzedmiotyPostaci.FormattingEnabled = true;
            this.PrzedmiotyPostaci.Location = new System.Drawing.Point(193, 57);
            this.PrzedmiotyPostaci.Name = "PrzedmiotyPostaci";
            this.PrzedmiotyPostaci.Size = new System.Drawing.Size(162, 160);
            this.PrzedmiotyPostaci.TabIndex = 11;
            this.PrzedmiotyPostaci.SelectedIndexChanged += new System.EventHandler(this.PrzedmiotyPostaci_SelectedIndexChanged);
            // 
            // Zapisz
            // 
            this.Zapisz.Location = new System.Drawing.Point(9, 245);
            this.Zapisz.Name = "Zapisz";
            this.Zapisz.Size = new System.Drawing.Size(75, 23);
            this.Zapisz.TabIndex = 10;
            this.Zapisz.Text = "Zapisz";
            this.toolTip1.SetToolTip(this.Zapisz, "Zapisuje gotową postać do pliku.");
            this.Zapisz.UseVisualStyleBackColor = true;
            this.Zapisz.Click += new System.EventHandler(this.Zapisz_Click);
            // 
            // Wczytaj
            // 
            this.Wczytaj.Location = new System.Drawing.Point(112, 245);
            this.Wczytaj.Name = "Wczytaj";
            this.Wczytaj.Size = new System.Drawing.Size(75, 23);
            this.Wczytaj.TabIndex = 9;
            this.Wczytaj.Text = "Wczytaj";
            this.toolTip1.SetToolTip(this.Wczytaj, "Wczytuje gotową postać z pliku.");
            this.Wczytaj.UseVisualStyleBackColor = true;
            this.Wczytaj.Click += new System.EventHandler(this.Wczytaj_Click);
            // 
            // Wyszukaj
            // 
            this.Wyszukaj.Location = new System.Drawing.Point(299, 28);
            this.Wyszukaj.Name = "Wyszukaj";
            this.Wyszukaj.Size = new System.Drawing.Size(75, 23);
            this.Wyszukaj.TabIndex = 8;
            this.Wyszukaj.Text = "Wyszukaj";
            this.toolTip1.SetToolTip(this.Wyszukaj, "Wyszukuje przedmioty z listy.");
            this.Wyszukaj.UseVisualStyleBackColor = true;
            this.Wyszukaj.Click += new System.EventHandler(this.Wyszukaj_Click);
            // 
            // Wyszukiwarka
            // 
            this.Wyszukiwarka.Location = new System.Drawing.Point(193, 30);
            this.Wyszukiwarka.Name = "Wyszukiwarka";
            this.Wyszukiwarka.Size = new System.Drawing.Size(100, 20);
            this.Wyszukiwarka.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Moc i Obrona: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Udźwig: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ilość przedmiotów: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.MaximumSize = new System.Drawing.Size(115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bazowe informacje o postaci:";
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(9, 46);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Info.Size = new System.Drawing.Size(156, 105);
            this.Info.TabIndex = 2;
            // 
            // Sklep
            // 
            this.Sklep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sklep.Controls.Add(this.label6);
            this.Sklep.Controls.Add(this.label5);
            this.Sklep.Controls.Add(this.Wykres);
            this.Sklep.Controls.Add(this.ListaWybranychPrzedmiotów);
            this.Sklep.Controls.Add(this.ListaPrzedmiotówSklep);
            this.Sklep.Controls.Add(this.DodajPrzedmiotyDoPostaci);
            this.Sklep.Controls.Add(this.DodajDoListy);
            this.Sklep.Controls.Add(this.UsuńzListy);
            this.Sklep.Controls.Add(this.WczytajPrzedmioty);
            this.Sklep.Location = new System.Drawing.Point(4, 22);
            this.Sklep.Name = "Sklep";
            this.Sklep.Padding = new System.Windows.Forms.Padding(3);
            this.Sklep.Size = new System.Drawing.Size(385, 307);
            this.Sklep.TabIndex = 1;
            this.Sklep.Text = "Sklep";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Wybrane przedmioty:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dostępne przedmioty:";
            // 
            // Wykres
            // 
            this.Wykres.Location = new System.Drawing.Point(27, 258);
            this.Wykres.Name = "Wykres";
            this.Wykres.Size = new System.Drawing.Size(93, 23);
            this.Wykres.TabIndex = 6;
            this.Wykres.Text = "Wyświetl wykres";
            this.toolTip1.SetToolTip(this.Wykres, "Wyświetla wykres w nowym oknie, porównujący wartości bazowe Mocy i Obrony postaci" +
        "\r\nwraz z ich zmodyfikowanymi wartościami (zwiększone poprzez wartość Bonusu dane" +
        "go przedmiotu). ");
            this.Wykres.UseVisualStyleBackColor = true;
            this.Wykres.Click += new System.EventHandler(this.Wykres_Click);
            // 
            // ListaWybranychPrzedmiotów
            // 
            this.ListaWybranychPrzedmiotów.FormattingEnabled = true;
            this.ListaWybranychPrzedmiotów.HorizontalScrollbar = true;
            this.ListaWybranychPrzedmiotów.Location = new System.Drawing.Point(249, 69);
            this.ListaWybranychPrzedmiotów.Name = "ListaWybranychPrzedmiotów";
            this.ListaWybranychPrzedmiotów.Size = new System.Drawing.Size(122, 173);
            this.ListaWybranychPrzedmiotów.TabIndex = 5;
            // 
            // ListaPrzedmiotówSklep
            // 
            this.ListaPrzedmiotówSklep.FormattingEnabled = true;
            this.ListaPrzedmiotówSklep.HorizontalScrollbar = true;
            this.ListaPrzedmiotówSklep.Location = new System.Drawing.Point(13, 69);
            this.ListaPrzedmiotówSklep.Name = "ListaPrzedmiotówSklep";
            this.ListaPrzedmiotówSklep.Size = new System.Drawing.Size(125, 173);
            this.ListaPrzedmiotówSklep.TabIndex = 4;
            this.ListaPrzedmiotówSklep.SelectedIndexChanged += new System.EventHandler(this.ListaPrzedmiotówSklep_SelectedIndexChanged);
            // 
            // DodajPrzedmiotyDoPostaci
            // 
            this.DodajPrzedmiotyDoPostaci.Location = new System.Drawing.Point(285, 258);
            this.DodajPrzedmiotyDoPostaci.Name = "DodajPrzedmiotyDoPostaci";
            this.DodajPrzedmiotyDoPostaci.Size = new System.Drawing.Size(75, 23);
            this.DodajPrzedmiotyDoPostaci.TabIndex = 3;
            this.DodajPrzedmiotyDoPostaci.Text = "Akceptuj";
            this.toolTip1.SetToolTip(this.DodajPrzedmiotyDoPostaci, "Zatwierdza wybór przedmiotów.");
            this.DodajPrzedmiotyDoPostaci.UseVisualStyleBackColor = true;
            this.DodajPrzedmiotyDoPostaci.Click += new System.EventHandler(this.DodajPrzedmiotyDoPostaci_Click);
            // 
            // DodajDoListy
            // 
            this.DodajDoListy.Location = new System.Drawing.Point(203, 69);
            this.DodajDoListy.Name = "DodajDoListy";
            this.DodajDoListy.Size = new System.Drawing.Size(31, 23);
            this.DodajDoListy.TabIndex = 2;
            this.DodajDoListy.Text = ">";
            this.toolTip1.SetToolTip(this.DodajDoListy, "Dodaj do listy Wybranych przedmiotów. ");
            this.DodajDoListy.UseVisualStyleBackColor = true;
            this.DodajDoListy.Click += new System.EventHandler(this.DodajDoListy_Click);
            // 
            // UsuńzListy
            // 
            this.UsuńzListy.Location = new System.Drawing.Point(154, 69);
            this.UsuńzListy.Name = "UsuńzListy";
            this.UsuńzListy.Size = new System.Drawing.Size(30, 23);
            this.UsuńzListy.TabIndex = 1;
            this.UsuńzListy.Text = "<";
            this.toolTip1.SetToolTip(this.UsuńzListy, "Usuń z listy Wybranych przedmiotów.");
            this.UsuńzListy.UseVisualStyleBackColor = true;
            this.UsuńzListy.Click += new System.EventHandler(this.UsuńzListy_Click);
            // 
            // WczytajPrzedmioty
            // 
            this.WczytajPrzedmioty.Location = new System.Drawing.Point(27, 18);
            this.WczytajPrzedmioty.Name = "WczytajPrzedmioty";
            this.WczytajPrzedmioty.Size = new System.Drawing.Size(75, 23);
            this.WczytajPrzedmioty.TabIndex = 0;
            this.WczytajPrzedmioty.Text = "Dostawa";
            this.toolTip1.SetToolTip(this.WczytajPrzedmioty, "Przesyła listę dostępnych przedmiotów do sklepu.");
            this.WczytajPrzedmioty.UseVisualStyleBackColor = true;
            this.WczytajPrzedmioty.Click += new System.EventHandler(this.WczytajPrzedmioty_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OknoGłówne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 313);
            this.Controls.Add(this.Zakładki);
            this.Name = "OknoGłówne";
            this.Text = "Okno główne";
            this.Zakładki.ResumeLayout(false);
            this.EkwipunekGracza.ResumeLayout(false);
            this.EkwipunekGracza.PerformLayout();
            this.Sklep.ResumeLayout(false);
            this.Sklep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Zakładki;
        private System.Windows.Forms.TabPage EkwipunekGracza;
        private System.Windows.Forms.TabPage Sklep;
        private System.Windows.Forms.TextBox Info;
        private System.Windows.Forms.ListBox ListaWybranychPrzedmiotów;
        private System.Windows.Forms.ListBox ListaPrzedmiotówSklep;
        private System.Windows.Forms.Button DodajPrzedmiotyDoPostaci;
        private System.Windows.Forms.Button DodajDoListy;
        private System.Windows.Forms.Button UsuńzListy;
        private System.Windows.Forms.Button WczytajPrzedmioty;
        private System.Windows.Forms.Button Wczytaj;
        private System.Windows.Forms.Button Wyszukaj;
        private System.Windows.Forms.TextBox Wyszukiwarka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Zapisz;
        private System.Windows.Forms.ListBox PrzedmiotyPostaci;
        private System.Windows.Forms.Button Wykres;
        private System.Windows.Forms.Label MocIObrona;
        private System.Windows.Forms.Label UdźwigPostaci;
        private System.Windows.Forms.Label IlośćPrzedmiotów;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

