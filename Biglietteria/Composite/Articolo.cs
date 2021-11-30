using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Visitor;
using System.Linq;


namespace Biglietteria.Composite
{
    public class Articolo : IOrder
    {
        private IList<IOrder> articolo = new List<IOrder>();
        private string nome;

        //costruttore
        public Articolo(string nome)
        {
            this.nome = nome;
        }

        public void AggiungiArticolo(IOrder articolo)
        {
            this.articolo.Add(articolo); 
        }

        public IOrder CercaArticolo(string nome)
        {
            foreach (var elemento in articolo)
            {
                if(elemento.ReturnDescrizione() == nome)
                {
                    return elemento;
                }
            }

            return null;
        }


        public IEnumerable<IOrder> ReturnArticolo()
        {
            return articolo;
        }

        public string ReturnDescrizione()
        {
            return nome;
        }

        public double ReturnPrezzo()
        {
            double totalePrezzo = 0.00;
            foreach (var elemento in articolo)
            {
                totalePrezzo += elemento.ReturnPrezzo();
            }

            return totalePrezzo;
        }

        public void RimuoviArticolo(IOrder elemento)
        {
            articolo.Remove(elemento);
            
        }

        public string Mostra()
        {
            string ordine = "";

            foreach (var elemento in articolo)
            {
                ordine = ordine + elemento.Mostra() + "\n";
            }

            return ordine;
        }

        public void Accetta(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
