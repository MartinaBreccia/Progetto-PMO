using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Builder;
using System.Linq;
using Biglietteria.Visitor;

namespace Biglietteria.Composite
{
    public class Settore : IOrder
    {
        public string settore;
        public string descrizione;
        public double prezzo;


        public string ReturnSettore()
        {
            return settore;
        }
        public string ReturnDescrizione()
        {
            return descrizione;
        }
        public double ReturnPrezzo()
        {
            return prezzo;
        }

        public string Mostra()
        {
            return  ReturnSettore()+ "\n" + ReturnDescrizione() + "\nPrezzo : " + ReturnPrezzo() + "€";
        }

        public IOrder CercaArticolo(string nome) 
        {
            return null; 
        }

        public void AggiungiArticolo(IOrder articolo) { }
        public void RimuoviArticolo(IOrder articolo) { } 

        public void Accetta(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public IEnumerable<IOrder> ReturnArticolo()
        {
            return null;
        }


    }//end class
}
