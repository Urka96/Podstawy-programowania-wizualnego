namespace Projekt
{
    partial class OknoPrzedmiotów
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ListaPrzedmiotów = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NazwaPrz = new System.Windows.Forms.TextBox();
            this.TypPrz = new System.Windows.Forms.TextBox();
            this.OpisPrz = new System.Windows.Forms.TextBox();
            this.WymaganiaPrz = new System.Windows.Forms.TextBox();
            this.BonusPrz = new System.Windows.Forms.TextBox();
            this.WłaściwościPrz = new System.Windows.Forms.TextBox();
            this.WagaPrz = new System.Windows.Forms.TextBox();
            this.DodajPrz = new System.Windows.Forms.Button();
            this.EdytujPrz = new System.Windows.Forms.Button();
            this.UsuńPrz = new System.Windows.Forms.Button();
            this.OdczytPrz = new System.Windows.Forms.Button();
            this.ZapisPrz = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ListaPrzedmiotów
            // 
            this.ListaPrzedmiotów.FormattingEnabled = true;
            this.ListaPrzedmiotów.Location = new System.Drawing.Point(137, 12);
            this.ListaPrzedmiotów.Name = "ListaPrzedmiotów";
            this.ListaPrzedmiotów.Size = new System.Drawing.Size(201, 21);
            this.ListaPrzedmiotów.TabIndex = 0;
            this.ListaPrzedmiotów.SelectedIndexChanged += new System.EventHandler(this.ListaPrzedmiotów_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista przedmiotów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Wymagania";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bonus";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Właściwości";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Waga";
            // 
            // NazwaPrz
            // 
            this.NazwaPrz.Location = new System.Drawing.Point(102, 51);
            this.NazwaPrz.Name = "NazwaPrz";
            this.NazwaPrz.Size = new System.Drawing.Size(100, 20);
            this.NazwaPrz.TabIndex = 9;
            this.toolTip1.SetToolTip(this.NazwaPrz, "Od 4 do 30 znaków. ");
            // 
            // TypPrz
            // 
            this.TypPrz.Location = new System.Drawing.Point(102, 77);
            this.TypPrz.Name = "TypPrz";
            this.TypPrz.Size = new System.Drawing.Size(100, 20);
            this.TypPrz.TabIndex = 10;
            this.toolTip1.SetToolTip(this.TypPrz, "Dostępne typy przedmiotu:\r\nbroń,\r\npancerz,\r\nrękawice,\r\nbuty,\r\nspodnie,\r\nhełm.");
            // 
            // OpisPrz
            // 
            this.OpisPrz.Location = new System.Drawing.Point(102, 103);
            this.OpisPrz.Name = "OpisPrz";
            this.OpisPrz.Size = new System.Drawing.Size(100, 20);
            this.OpisPrz.TabIndex = 11;
            this.toolTip1.SetToolTip(this.OpisPrz, "Od 3 do 100 znaków.");
            // 
            // WymaganiaPrz
            // 
            this.WymaganiaPrz.Location = new System.Drawing.Point(102, 129);
            this.WymaganiaPrz.Name = "WymaganiaPrz";
            this.WymaganiaPrz.Size = new System.Drawing.Size(100, 20);
            this.WymaganiaPrz.TabIndex = 12;
            this.toolTip1.SetToolTip(this.WymaganiaPrz, "Dostępne wymagania:\r\nWojownik,\r\nMag,\r\nTropiciel.");
            // 
            // BonusPrz
            // 
            this.BonusPrz.Location = new System.Drawing.Point(102, 156);
            this.BonusPrz.Name = "BonusPrz";
            this.BonusPrz.Size = new System.Drawing.Size(100, 20);
            this.BonusPrz.TabIndex = 13;
            this.toolTip1.SetToolTip(this.BonusPrz, "Wartość ataku/pancerza.\r\nZakres 0-999.");
            // 
            // WłaściwościPrz
            // 
            this.WłaściwościPrz.Location = new System.Drawing.Point(102, 182);
            this.WłaściwościPrz.Name = "WłaściwościPrz";
            this.WłaściwościPrz.Size = new System.Drawing.Size(100, 20);
            this.WłaściwościPrz.TabIndex = 14;
            this.toolTip1.SetToolTip(this.WłaściwościPrz, "np. pozwala widzieć w ciemnościach, pozwala rzucać zaklęcia, itd.\r\nOd 5 do 30 zna" +
        "ków.");
            // 
            // WagaPrz
            // 
            this.WagaPrz.Location = new System.Drawing.Point(102, 208);
            this.WagaPrz.Name = "WagaPrz";
            this.WagaPrz.Size = new System.Drawing.Size(100, 20);
            this.WagaPrz.TabIndex = 15;
            this.toolTip1.SetToolTip(this.WagaPrz, "Wartości od 0.2 do 50");
            // 
            // DodajPrz
            // 
            this.DodajPrz.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DodajPrz.Location = new System.Drawing.Point(263, 54);
            this.DodajPrz.Name = "DodajPrz";
            this.DodajPrz.Size = new System.Drawing.Size(75, 23);
            this.DodajPrz.TabIndex = 16;
            this.DodajPrz.Text = "Dodaj";
            this.toolTip1.SetToolTip(this.DodajPrz, "Dodaje stworzony przedmiot do listy.");
            this.DodajPrz.UseVisualStyleBackColor = false;
            this.DodajPrz.Click += new System.EventHandler(this.DodajPrz_Click);
            // 
            // EdytujPrz
            // 
            this.EdytujPrz.Location = new System.Drawing.Point(247, 83);
            this.EdytujPrz.Name = "EdytujPrz";
            this.EdytujPrz.Size = new System.Drawing.Size(102, 23);
            this.EdytujPrz.TabIndex = 17;
            this.EdytujPrz.Text = "Potwierdź zmiany";
            this.toolTip1.SetToolTip(this.EdytujPrz, "Aktualizuje zmienione dane o przedmiocie.");
            this.EdytujPrz.UseVisualStyleBackColor = true;
            this.EdytujPrz.Click += new System.EventHandler(this.EdytujPrz_Click);
            // 
            // UsuńPrz
            // 
            this.UsuńPrz.Location = new System.Drawing.Point(263, 112);
            this.UsuńPrz.Name = "UsuńPrz";
            this.UsuńPrz.Size = new System.Drawing.Size(75, 23);
            this.UsuńPrz.TabIndex = 18;
            this.UsuńPrz.Text = "Usuń";
            this.toolTip1.SetToolTip(this.UsuńPrz, "Usuwa przedmiot z listy.");
            this.UsuńPrz.UseVisualStyleBackColor = true;
            this.UsuńPrz.Click += new System.EventHandler(this.UsuńPrz_Click);
            // 
            // OdczytPrz
            // 
            this.OdczytPrz.Location = new System.Drawing.Point(263, 141);
            this.OdczytPrz.Name = "OdczytPrz";
            this.OdczytPrz.Size = new System.Drawing.Size(75, 23);
            this.OdczytPrz.TabIndex = 19;
            this.OdczytPrz.Text = "Wczytaj";
            this.toolTip1.SetToolTip(this.OdczytPrz, "Wczytuje przedmioty z pliku.");
            this.OdczytPrz.UseVisualStyleBackColor = true;
            this.OdczytPrz.Click += new System.EventHandler(this.OdczytPrz_Click);
            // 
            // ZapisPrz
            // 
            this.ZapisPrz.Location = new System.Drawing.Point(263, 170);
            this.ZapisPrz.Name = "ZapisPrz";
            this.ZapisPrz.Size = new System.Drawing.Size(75, 23);
            this.ZapisPrz.TabIndex = 20;
            this.ZapisPrz.Text = "Zapisz";
            this.toolTip1.SetToolTip(this.ZapisPrz, "Zapisuje przedmioty do pliku.");
            this.ZapisPrz.UseVisualStyleBackColor = true;
            this.ZapisPrz.Click += new System.EventHandler(this.ZapisPrz_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // OknoPrzedmiotów
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 249);
            this.Controls.Add(this.ZapisPrz);
            this.Controls.Add(this.OdczytPrz);
            this.Controls.Add(this.UsuńPrz);
            this.Controls.Add(this.EdytujPrz);
            this.Controls.Add(this.DodajPrz);
            this.Controls.Add(this.WagaPrz);
            this.Controls.Add(this.WłaściwościPrz);
            this.Controls.Add(this.BonusPrz);
            this.Controls.Add(this.WymaganiaPrz);
            this.Controls.Add(this.OpisPrz);
            this.Controls.Add(this.TypPrz);
            this.Controls.Add(this.NazwaPrz);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaPrzedmiotów);
            this.Name = "OknoPrzedmiotów";
            this.Text = "Okno przedmiotów";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OknoPrzedmiotów_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaPrzedmiotów;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NazwaPrz;
        private System.Windows.Forms.TextBox TypPrz;
        private System.Windows.Forms.TextBox OpisPrz;
        private System.Windows.Forms.TextBox WymaganiaPrz;
        private System.Windows.Forms.TextBox BonusPrz;
        private System.Windows.Forms.TextBox WłaściwościPrz;
        private System.Windows.Forms.TextBox WagaPrz;
        private System.Windows.Forms.Button DodajPrz;
        private System.Windows.Forms.Button EdytujPrz;
        private System.Windows.Forms.Button UsuńPrz;
        private System.Windows.Forms.Button OdczytPrz;
        private System.Windows.Forms.Button ZapisPrz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}