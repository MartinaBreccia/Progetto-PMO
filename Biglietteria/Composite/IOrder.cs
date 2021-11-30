using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Visitor;

namespace Biglietteria.Composite
{
    public interface IOrder
    {
        void AggiungiArticolo(IOrder articolo);
        IOrder CercaArticolo(string nome);        
        IEnumerable<IOrder> ReturnArticolo();
        double ReturnPrezzo();
        string ReturnDescrizione();
        
        void RimuoviArticolo(IOrder articolo);
        string Mostra();

        
        
        void Accetta(IVisitor visitor);

    }
}
