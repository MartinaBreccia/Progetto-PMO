using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Builder;
using Biglietteria.Visitor;

namespace Biglietteria.Composite
{
    public class Stadio : IOrder
    {
        private string nome;

        //costruttore
        public Stadio(string nome)
        {
            this.nome = nome;
        }

        public double ReturnPrezzo() 
        { 
            return 0; 
        }
        public string ReturnDescrizione()
        {
            return nome;
        }

        public string Mostra()
        {
            return ReturnDescrizione();
        }

        public IOrder CercaArticolo(string nome) { return null; }
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
    }
}
