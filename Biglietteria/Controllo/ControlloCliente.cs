using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Biglietteria.Controllo
{
    public class ControlloCliente
    {
        private TextBox txtNome;
        private TextBox txtCognome;
        private TextBox txtIndirizzo;
        private TextBox txtCitta;
        private TextBox txtTelefono;

        //costruttore
        public ControlloCliente(TextBox nome, TextBox cognome, TextBox ind, TextBox citta, TextBox tel)
        {
            this.txtNome = nome;
            this.txtCognome = cognome;
            this.txtIndirizzo = ind;
            this.txtCitta = citta;
            this.txtTelefono = tel;

        }//end costruttore


        public bool ControlloTextBox()
        {
            return !string.IsNullOrEmpty(txtNome.Text)
                && !string.IsNullOrEmpty(txtCognome.Text)
                && !string.IsNullOrEmpty(txtIndirizzo.Text)
                && !string.IsNullOrEmpty(txtCitta.Text)
                && !string.IsNullOrEmpty(txtTelefono.Text);
        }

        public bool ControlloTelefono()
        {
            if (txtTelefono.Text.Length < 10)
            {
                return false;
            }
            else return true;
        }

    }//end ControlloCliente
}
