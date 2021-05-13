namespace Projekt
{
    partial class OknoPostaci
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
            this.ListaPostaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImięPos = new System.Windows.Forms.TextBox();
            this.LevelPos = new System.Windows.Forms.TextBox();
            this.OpisPos = new System.Windows.Forms.TextBox();
            this.MocPos = new System.Windows.Forms.TextBox();
            this.ObronaPos = new System.Windows.Forms.TextBox();
            this.UdźwigPos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WybórKlasaPostaci = new System.Windows.Forms.ComboBox();
            this.StwórzPostać = new System.Windows.Forms.Button();
            this.Edytuj = new System.Windows.Forms.Button();
            this.Usuń = new System.Windows.Forms.Button();
            this.Odczyt = new System.Windows.Forms.Button();
            this.Zapis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.WybierzPos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ListaPostaci
            // 
            this.ListaPostaci.FormattingEnabled = true;
            this.ListaPostaci.Location = new System.Drawing.Point(117, 12);
            this.ListaPostaci.Name = "ListaPostaci";
            this.ListaPostaci.Size = new System.Drawing.Size(221, 21);
            this.ListaPostaci.TabIndex = 0;
            this.ListaPostaci.SelectedIndexChanged += new System.EventHandler(this.ListaPostaci_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista postaci";
            // 
            // ImięPos
            // 
            this.ImięPos.Location = new System.Drawing.Point(88, 64);
            this.ImięPos.Name = "ImięPos";
            this.ImięPos.Size = new System.Drawing.Size(100, 20);
            this.ImięPos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.ImięPos, "Od 4 do 15 znaków.");
            // 
            // LevelPos
            // 
            this.LevelPos.Location = new System.Drawing.Point(88, 90);
            this.LevelPos.Name = "LevelPos";
            this.LevelPos.Size = new System.Drawing.Size(100, 20);
            this.LevelPos.TabIndex = 3;
            this.toolTip1.SetToolTip(this.LevelPos, "Wartości od 0 do 99.");
            // 
            // OpisPos
            // 
            this.OpisPos.Location = new System.Drawing.Point(88, 116);
            this.OpisPos.Name = "OpisPos";
            this.OpisPos.Size = new System.Drawing.Size(100, 20);
            this.OpisPos.TabIndex = 4;
            this.toolTip1.SetToolTip(this.OpisPos, "Od 3 do 100 znaków.");
            // 
            // MocPos
            // 
            this.MocPos.Location = new System.Drawing.Point(88, 169);
            this.MocPos.Name = "MocPos";
            this.MocPos.ReadOnly = true;
            this.MocPos.Size = new System.Drawing.Size(100, 20);
            this.MocPos.TabIndex = 5;
            // 
            // ObronaPos
            // 
            this.ObronaPos.Location = new System.Drawing.Point(88, 196);
            this.ObronaPos.Name = "ObronaPos";
            this.ObronaPos.ReadOnly = true;
            this.ObronaPos.Size = new System.Drawing.Size(100, 20);
            this.ObronaPos.TabIndex = 6;
            // 
            // UdźwigPos
            // 
            this.UdźwigPos.Location = new System.Drawing.Point(88, 222);
            this.UdźwigPos.Name = "UdźwigPos";
            this.UdźwigPos.ReadOnly = true;
            this.UdźwigPos.Size = new System.Drawing.Size(100, 20);
            this.UdźwigPos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imię";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Klasa postaci";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Moc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Obrona";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Udźwig";
            // 
            // WybórKlasaPostaci
            // 
            this.WybórKlasaPostaci.FormattingEnabled = true;
            this.WybórKlasaPostaci.Location = new System.Drawing.Point(88, 142);
            this.WybórKlasaPostaci.Name = "WybórKlasaPostaci";
            this.WybórKlasaPostaci.Size = new System.Drawing.Size(100, 21);
            this.WybórKlasaPostaci.TabIndex = 15;
            // 
            // StwórzPostać
            // 
            this.StwórzPostać.Location = new System.Drawing.Point(249, 64);
            this.StwórzPostać.Name = "StwórzPostać";
            this.StwórzPostać.Size = new System.Drawing.Size(75, 23);
            this.StwórzPostać.TabIndex = 16;
            this.StwórzPostać.Text = "Stwórz";
            this.toolTip1.SetToolTip(this.StwórzPostać, "Dodaje stworzoną postać do listy.");
            this.StwórzPostać.UseVisualStyleBackColor = true;
            this.StwórzPostać.Click += new System.EventHandler(this.StwórzPostać_Click);
            // 
            // Edytuj
            // 
            this.Edytuj.Location = new System.Drawing.Point(249, 93);
            this.Edytuj.Name = "Edytuj";
            this.Edytuj.Size = new System.Drawing.Size(106, 23);
            this.Edytuj.TabIndex = 17;
            this.Edytuj.Text = "Potwierdź zmiany";
            this.toolTip1.SetToolTip(this.Edytuj, "Aktualizuje zmienione informacje o postaci.");
            this.Edytuj.UseVisualStyleBackColor = true;
            this.Edytuj.Click += new System.EventHandler(this.Edytuj_Click);
            // 
            // Usuń
            // 
            this.Usuń.Location = new System.Drawing.Point(249, 122);
            this.Usuń.Name = "Usuń";
            this.Usuń.Size = new System.Drawing.Size(75, 23);
            this.Usuń.TabIndex = 18;
            this.Usuń.Text = "Usuń";
            this.toolTip1.SetToolTip(this.Usuń, "Usuwa postać z listy.");
            this.Usuń.UseVisualStyleBackColor = true;
            this.Usuń.Click += new System.EventHandler(this.Usuń_Click);
            // 
            // Odczyt
            // 
            this.Odczyt.Location = new System.Drawing.Point(249, 151);
            this.Odczyt.Name = "Odczyt";
            this.Odczyt.Size = new System.Drawing.Size(75, 23);
            this.Odczyt.TabIndex = 19;
            this.Odczyt.Text = "Wczytaj";
            this.toolTip1.SetToolTip(this.Odczyt, "Wczytuje postacie z pliku.");
            this.Odczyt.UseVisualStyleBackColor = true;
            this.Odczyt.Click += new System.EventHandler(this.Odczyt_Click);
            // 
            // Zapis
            // 
            this.Zapis.Location = new System.Drawing.Point(249, 180);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(75, 23);
            this.Zapis.TabIndex = 20;
            this.Zapis.Text = "Zapisz";
            this.toolTip1.SetToolTip(this.Zapis, "Zapisuje postacie do pliku.");
            this.Zapis.UseVisualStyleBackColor = true;
            this.Zapis.Click += new System.EventHandler(this.Zapis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // WybierzPos
            // 
            this.WybierzPos.Location = new System.Drawing.Point(249, 225);
            this.WybierzPos.Name = "WybierzPos";
            this.WybierzPos.Size = new System.Drawing.Size(89, 23);
            this.WybierzPos.TabIndex = 21;
            this.WybierzPos.Text = "Wybierz postać";
            this.toolTip1.SetToolTip(this.WybierzPos, "Po wybraniu postaci z listy, dane o niej wyświetlane są w oknie głównym.");
            this.WybierzPos.UseVisualStyleBackColor = true;
            this.WybierzPos.Click += new System.EventHandler(this.WybierzPos_Click);
            // 
            // OknoPostaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 273);
            this.Controls.Add(this.WybierzPos);
            this.Controls.Add(this.Zapis);
            this.Controls.Add(this.Odczyt);
            this.Controls.Add(this.Usuń);
            this.Controls.Add(this.Edytuj);
            this.Controls.Add(this.StwórzPostać);
            this.Controls.Add(this.WybórKlasaPostaci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UdźwigPos);
            this.Controls.Add(this.ObronaPos);
            this.Controls.Add(this.MocPos);
            this.Controls.Add(this.OpisPos);
            this.Controls.Add(this.LevelPos);
            this.Controls.Add(this.ImięPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaPostaci);
            this.Name = "OknoPostaci";
            this.Text = "Okno postaci";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OknoPostaci_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaPostaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImięPos;
        private System.Windows.Forms.TextBox LevelPos;
        private System.Windows.Forms.TextBox OpisPos;
        private System.Windows.Forms.TextBox MocPos;
        private System.Windows.Forms.TextBox ObronaPos;
        private System.Windows.Forms.TextBox UdźwigPos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox WybórKlasaPostaci;
        private System.Windows.Forms.Button StwórzPostać;
        private System.Windows.Forms.Button Edytuj;
        private System.Windows.Forms.Button Usuń;
        private System.Windows.Forms.Button Odczyt;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button WybierzPos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}