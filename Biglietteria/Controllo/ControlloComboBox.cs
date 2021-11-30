using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Biglietteria.Controllo
{
    public class ControlloComboBox
    {
        private ComboBox settore;
        private ComboBox cmbStadio;
        private string descrizione;

        //costruttore
        public ControlloComboBox(ComboBox settore, ComboBox stadio)
        {
            this.settore = settore;
            this.cmbStadio = stadio;
            
        }
        //fine costruttore
        public double ControlloPrezzoSettore(ComboBox settore)
        {
            double prezzo = 0.00;

            switch (settore.SelectedIndex)
            {
                case 0:
                    prezzo = 90.00;
                    break;
                case 1:
                    prezzo = 70.00;
                    break;
                case 2:
                    prezzo = 50.00;
                    break;
                case 3:
                    prezzo = 30.00;
                    break;
            }

            return prezzo;
        }

        public string ControlloDescrizione(ComboBox settore)
        {
            if(this.settore.Text == "Settore A")
            {
                descrizione = "Tribuna Vip";
            }
            if (this.settore.Text == "Settore B")
            {
                descrizione = "Curva Nord";
            }
            if (this.settore.Text == "Settore C")
            {
                descrizione = "Tribuna UBI";
            }
            if (this.settore.Text == "Settore D")
            {
                descrizione = "Curva Sud";
            }
            return descrizione;
        }

        public void ResetComboBox()
        {
            settore.Text = "";
            cmbStadio.Text = "";
        }
    
    }//end ControlloComboBox
}
