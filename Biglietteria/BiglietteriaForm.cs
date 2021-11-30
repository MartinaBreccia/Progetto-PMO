using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biglietteria.Visitor;
using Biglietteria.Composite;
using Biglietteria.Builder;
using Biglietteria.Controllo;
using Biglietteria.Singleton;

namespace Biglietteria
{
    public partial class Biglietteria : Form, IVisualizzaBig
    {
        private ControlloCliente controlloCliente;
        private ControlloComboBox controlloComboBox;
        Controller controller_;


        public Biglietteria()
        {

            InitializeComponent();
            controlloComboBox = new ControlloComboBox(cmbSettore, cmbStadio);
            controlloCliente = new ControlloCliente(txtNome, txtCognome, txtIndirizzo, txtCitta, txtTelefono);

            //creo una lista per i nomi degli stadi 
            List<string> NomeStadio = new List<string>();
            NomeStadio.Add(new string("Milano - SanSiro"));
            NomeStadio.Add(new string("Torino - Allianz Stadio"));
            NomeStadio.Add(new string("Roma - Stadio Olimpico"));
            // ciclo che aggiunge al combobox i vari nomi degli stadi
            for (int i = 0; i < NomeStadio.Count; i++)
            {
                cmbStadio.Items.Add(NomeStadio[i]);
            }

            //creo una lista per i nomi dei settori
            List<string> NomeSettore = new List<string>();
            NomeSettore.Add(new string("Settore A"));
            NomeSettore.Add(new string("Settore B"));
            NomeSettore.Add(new string("Settore C"));
            NomeSettore.Add(new string("Settore D"));
            // ciclo che aggiunge al combobox i vari nomi dei settori
            for (int i = 0; i < NomeSettore.Count; i++)
            {
                cmbSettore.Items.Add(NomeSettore[i]);
                
            }

        }
        
        private void ResetCarrello()
        {
            controlloComboBox.ResetComboBox();
            txtPrezzo.Text = "";
            lblFila.Text = "";
        }

        private void btnBiglietto_Click(object sender, EventArgs e)
        {

            if (cmbSettore.Text != "" && cmbStadio.Text != "")
            {
                this.controller_.AggiungiCarrello();
                ResetCarrello();
            }
            else
            {
                MessageBox.Show(" IMMETTERE LO STADIO E/O IL SETTORE CORRETTAMENTE!!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnRimuovi_Click(object sender, EventArgs e)
        {
            this.controller_.RimuoviCarrello();
        }

        private void btnConfermaAcquisto_Click(object sender, EventArgs e)
        {
            if (ListViewCarrello.Items.Count > 0)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = true;
                ResetCarrello();

            }
            else
            {
                MessageBox.Show("AGGIUNGERE AL CARRELLO ALMENO UN BIGLIETTO !!", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnConfermaD_Click(object sender, EventArgs e)
        {
            if (controlloCliente.ControlloTextBox())
            {
                if (controlloCliente.ControlloTelefono())
                {
                    this.controller_.CreoCliente();
                }
                else
                {
                    MessageBox.Show(" NUMERO DI TELEFONO NON VALIDO !!", " ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(" INSERIRE TUTTI I CAMPI CORRETTAMENTE !!", " ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbSettore_SelectedIndexChanged(object sender, EventArgs e)//piu o meno
        {
            txtPrezzo.Text = controlloComboBox.ControlloPrezzoSettore(cmbSettore).ToString();
            lblFila.Text = controlloComboBox.ControlloDescrizione(cmbSettore).ToString();
        }




        #region METHODS
        public void ImpostaController(Controller controller)
        {
            controller_ = controller;
        }

        public void AggiungiInLista(IOrder articolo, Settore settore, Stadio stadio)
        {
            ListViewItem item;
            item = articolo.InListViewItem(settore, stadio);
            ListViewCarrello.Items.Add(item);
        }

        public void StampaCalcolatore(IVisitor totalePrezzo, IVisitor prezzoMedio, IVisitor totQuantita)
        {
            txtImportoTot.Text = totalePrezzo.TotaleBiglietti().ToString();

            txtPMedio.Text = prezzoMedio.TotaleBiglietti().ToString();

            txtQta.Text = totQuantita.TotaleBiglietti().ToString();
        }


        public void RimuoviDallaLista()
        {
            foreach(ListViewItem listItem in this.ListViewCarrello.SelectedItems)
            {
                ListViewCarrello.Items.Remove(ListViewCarrello.SelectedItems[0]);
                
            }
        }

        public void StampaCarrello(IOrder articolo)
        {
            MessageBox.Show(articolo.Mostra());
        }

        public bool StampaRicevuta(IOrder ordine, Cliente cliente)
        {
            bool conferma = false;

            if(MessageBox.Show(ordine.ReturnDescrizione() + "\n\n" + ordine.Mostra() + cliente.Mostra() + "\n\nImporto totale : " + txtImportoTot.Text + " euro", "CONFERMARE L'ORDINE ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (MessageBox.Show("Grazie per l'acquisto. \nIl suo ordine verrà consegnato entro 5 giorni ", "ACQUISTO CONFERMATO", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    conferma = true;
                }
            }
            return conferma;
        }

        public string ReturnNomeArticoloSelected()
        {
            if(this.ListViewCarrello.SelectedItems.Count > 0)
            {
                return this.ListViewCarrello.SelectedItems[0].Text;
            }
            else
            {
                return "";
            }
        }

        public void ChiudiProgramma()
        {
            Close();
        }

        public void ModificaOrdine()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = false;
        }






#endregion

        #region PROPERTY

        public string NomeSettore => this.cmbSettore.Text;

        public string NomeStadio => this.cmbStadio.Text;

        public double Prezzo => double.Parse(this.txtPrezzo.Text);


        public string NomeCliente => this.txtNome.Text;

        public string CognomeCliente => this.txtCognome.Text;

        public string CittaCliente => this.txtCitta.Text;

        public string IndirizzoCliente => this.txtIndirizzo.Text;

        public long TelefonoCliente => long.Parse(this.txtTelefono.Text);



        #endregion


    }//end public partial class Biglietteria : Form
}