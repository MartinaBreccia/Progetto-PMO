using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Composite;


namespace Biglietteria.Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Settore settore;
        public ConcreteBuilder()
        {
            this.Reset();
        }
        private void Reset()
        {
            settore = new Settore();
        }

        public void ImpostaSettore(string lettera)
        {
            settore.settore = lettera;
        }
        public void AggiungiDescrizione(string nome)
        {
            settore.descrizione = nome;
        }
        public void ImpostaPrezzo(double prezzo)
        {
            settore.prezzo = prezzo;
        }

        public Settore GetProduct()
        {
            Settore risultato = settore;
            this.Reset();
            return risultato;
        }

    }
}
