
namespace Biglietteria
{
    partial class Biglietteria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStadio = new System.Windows.Forms.ComboBox();
            this.cmbSettore = new System.Windows.Forms.ComboBox();
            this.btnBiglietto = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfermaD = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ListViewCarrello = new System.Windows.Forms.ListView();
            this.CArticolo = new System.Windows.Forms.ColumnHeader();
            this.CStadio = new System.Windows.Forms.ColumnHeader();
            this.CSettore = new System.Windows.Forms.ColumnHeader();
            this.CPrezzo = new System.Windows.Forms.ColumnHeader();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPMedio = new System.Windows.Forms.TextBox();
            this.txtQta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtImportoTot = new System.Windows.Forms.TextBox();
            this.btnRimuovi = new System.Windows.Forms.Button();
            this.btnConfermaAcquisto = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFila = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selezionare il biglietto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inserire Dati Personali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Settore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stadio";
            // 
            // cmbStadio
            // 
            this.cmbStadio.FormattingEnabled = true;
            this.cmbStadio.Location = new System.Drawing.Point(96, 73);
            this.cmbStadio.Name = "cmbStadio";
            this.cmbStadio.Size = new System.Drawing.Size(182, 23);
            this.cmbStadio.TabIndex = 5;
            // 
            // cmbSettore
            // 
            this.cmbSettore.FormattingEnabled = true;
            this.cmbSettore.Location = new System.Drawing.Point(96, 131);
            this.cmbSettore.Name = "cmbSettore";
            this.cmbSettore.Size = new System.Drawing.Size(182, 23);
            this.cmbSettore.TabIndex = 6;
            this.cmbSettore.SelectedIndexChanged += new System.EventHandler(this.cmbSettore_SelectedIndexChanged);
            // 
            // btnBiglietto
            // 
            this.btnBiglietto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBiglietto.Location = new System.Drawing.Point(96, 208);
            this.btnBiglietto.Name = "btnBiglietto";
            this.btnBiglietto.Size = new System.Drawing.Size(182, 36);
            this.btnBiglietto.TabIndex = 7;
            this.btnBiglietto.Text = "Aggiungi al carrello";
            this.btnBiglietto.UseVisualStyleBackColor = true;
            this.btnBiglietto.Click += new System.EventHandler(this.btnBiglietto_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(96, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 23);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(96, 163);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(121, 23);
            this.txtCitta.TabIndex = 10;
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(96, 134);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(121, 23);
            this.txtIndirizzo.TabIndex = 11;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(96, 105);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(121, 23);
            this.txtCognome.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Città";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Indirizzo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cognome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nome";
            // 
            // btnConfermaD
            // 
            this.btnConfermaD.Location = new System.Drawing.Point(284, 119);
            this.btnConfermaD.Name = "btnConfermaD";
            this.btnConfermaD.Size = new System.Drawing.Size(112, 52);
            this.btnConfermaD.TabIndex = 17;
            this.btnConfermaD.Text = "Conferma dati";
            this.btnConfermaD.UseVisualStyleBackColor = true;
            this.btnConfermaD.Click += new System.EventHandler(this.btnConfermaD_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(22, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Carrello";
            // 
            // ListViewCarrello
            // 
            this.ListViewCarrello.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CArticolo,
            this.CStadio,
            this.CSettore,
            this.CPrezzo});
            this.ListViewCarrello.FullRowSelect = true;
            this.ListViewCarrello.GridLines = true;
            this.ListViewCarrello.HideSelection = false;
            this.ListViewCarrello.Location = new System.Drawing.Point(22, 67);
            this.ListViewCarrello.Name = "ListViewCarrello";
            this.ListViewCarrello.Size = new System.Drawing.Size(468, 155);
            this.ListViewCarrello.TabIndex = 20;
            this.ListViewCarrello.UseCompatibleStateImageBehavior = false;
            this.ListViewCarrello.View = System.Windows.Forms.View.Details;
            // 
            // CArticolo
            // 
            this.CArticolo.Text = "Articolo";
            this.CArticolo.Width = 100;
            // 
            // CStadio
            // 
            this.CStadio.Text = "Nome Stadio";
            this.CStadio.Width = 130;
            // 
            // CSettore
            // 
            this.CSettore.Text = "Settore";
            this.CSettore.Width = 130;
            // 
            // CPrezzo
            // 
            this.CPrezzo.Text = "Prezzo";
            this.CPrezzo.Width = 100;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(99, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Prezzo Medio dei Biglietti";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Quantità dei Biglietti Prenotati";
            // 
            // txtPMedio
            // 
            this.txtPMedio.Enabled = false;
            this.txtPMedio.Location = new System.Drawing.Point(257, 393);
            this.txtPMedio.Name = "txtPMedio";
            this.txtPMedio.Size = new System.Drawing.Size(121, 23);
            this.txtPMedio.TabIndex = 23;
            // 
            // txtQta
            // 
            this.txtQta.Enabled = false;
            this.txtQta.Location = new System.Drawing.Point(257, 291);
            this.txtQta.Name = "txtQta";
            this.txtQta.Size = new System.Drawing.Size(121, 23);
            this.txtQta.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(153, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 28;
            this.label14.Text = "Importo Totale";
            // 
            // txtImportoTot
            // 
            this.txtImportoTot.Enabled = false;
            this.txtImportoTot.Location = new System.Drawing.Point(257, 322);
            this.txtImportoTot.Name = "txtImportoTot";
            this.txtImportoTot.Size = new System.Drawing.Size(121, 23);
            this.txtImportoTot.TabIndex = 27;
            // 
            // btnRimuovi
            // 
            this.btnRimuovi.Location = new System.Drawing.Point(22, 228);
            this.btnRimuovi.Name = "btnRimuovi";
            this.btnRimuovi.Size = new System.Drawing.Size(188, 31);
            this.btnRimuovi.TabIndex = 29;
            this.btnRimuovi.Text = "Rimuovi Biglietto Selezionato";
            this.btnRimuovi.UseVisualStyleBackColor = true;
            this.btnRimuovi.Click += new System.EventHandler(this.btnRimuovi_Click);
            // 
            // btnConfermaAcquisto
            // 
            this.btnConfermaAcquisto.Location = new System.Drawing.Point(141, 446);
            this.btnConfermaAcquisto.Name = "btnConfermaAcquisto";
            this.btnConfermaAcquisto.Size = new System.Drawing.Size(237, 36);
            this.btnConfermaAcquisto.TabIndex = 30;
            this.btnConfermaAcquisto.Text = "Conferma Acquisto";
            this.btnConfermaAcquisto.UseVisualStyleBackColor = true;
            this.btnConfermaAcquisto.Click += new System.EventHandler(this.btnConfermaAcquisto_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(384, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 15);
            this.label15.TabIndex = 31;
            this.label15.Text = "€";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(384, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 15);
            this.label16.TabIndex = 32;
            this.label16.Text = "€";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtIndirizzo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtCitta);
            this.panel3.Controls.Add(this.txtCognome);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnConfermaD);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(12, 365);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 254);
            this.panel3.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFila);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPrezzo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbStadio);
            this.panel1.Controls.Add(this.cmbSettore);
            this.panel1.Controls.Add(this.btnBiglietto);
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 260);
            this.panel1.TabIndex = 34;
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(96, 173);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(0, 15);
            this.lblFila.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(62, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 15);
            this.label19.TabIndex = 36;
            this.label19.Text = "Fila:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(362, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 15);
            this.label18.TabIndex = 35;
            this.label18.Text = "€";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Enabled = false;
            this.txtPrezzo.Location = new System.Drawing.Point(284, 131);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(72, 23);
            this.txtPrezzo.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnConfermaAcquisto);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnRimuovi);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtImportoTot);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtPMedio);
            this.panel2.Controls.Add(this.txtQta);
            this.panel2.Controls.Add(this.ListViewCarrello);
            this.panel2.Location = new System.Drawing.Point(451, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 520);
            this.panel2.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gill Sans MT", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(277, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(406, 65);
            this.label17.TabIndex = 36;
            this.label17.Text = "Biglietteria Online";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biglietteria.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Biglietteria.Properties.Resources.download1;
            this.pictureBox3.Location = new System.Drawing.Point(883, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // Biglietteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 632);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Biglietteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biglietteria Online";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStadio;
        private System.Windows.Forms.ComboBox cmbSettore;
        private System.Windows.Forms.Button btnBiglietto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfermaD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView ListViewCarrello;
        private System.Windows.Forms.ColumnHeader CStadio;
        private System.Windows.Forms.ColumnHeader CSettore;
        private System.Windows.Forms.ColumnHeader CPrezzo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPMedio;
        private System.Windows.Forms.TextBox txtQta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtImportoTot;
        private System.Windows.Forms.Button btnRimuovi;
        private System.Windows.Forms.Button btnConfermaAcquisto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ColumnHeader CArticolo;
    }
}

