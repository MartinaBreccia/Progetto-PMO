using System;
using System.Collections.Generic;
using System.Text;

namespace Biglietteria.Builder
{
    class CreaSettore
    {
        private IBuilder builder;
        public string tipoSettore;
        public IBuilder Builder 
        { 
            set 
            {
                builder = value;
            }
        }

        public CreaSettore(string tiposettore)
        {
            this.tipoSettore = tiposettore;
        }

        public void CreaBiglietto()
        {
            if(tipoSettore == "Settore A")
            {
                builder.ImpostaSettore("SETTORE A");
                builder.AggiungiDescrizione("Tribuna VIP");
                builder.ImpostaPrezzo(90.00);
            }
            if (tipoSettore == "Settore B")
            {
                builder.ImpostaSettore("SETTORE B");
                builder.AggiungiDescrizione("Curva Nord");
                builder.ImpostaPrezzo(70.00);
            }
            if (tipoSettore == "Settore C")
            {
                builder.ImpostaSettore("SETTORE C");
                builder.AggiungiDescrizione("Tribuna Ubi");
                builder.ImpostaPrezzo(50.00);
            }
            if (tipoSettore == "Settore D")
            {
                builder.ImpostaSettore("SETTORE D");
                builder.AggiungiDescrizione("Curva Sud");
                builder.ImpostaPrezzo(30.00);
            }

        }
        
    }//end class Biglietti
}
