using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Composite;
using Biglietteria.Builder;

namespace Biglietteria.Visitor
{
    public class TotalePrezzo : IVisitor
    {
        private double totaleBiglietti = 0;

        public void Visit(Settore settore)
        {
            totaleBiglietti += settore.ReturnPrezzo();
        }
        public void Visit(Stadio stadio) { }
        public void Visit(Articolo articolo) { }
        public void Reset()
        {
            totaleBiglietti = 0;
           
        }

        public object TotaleBiglietti()
        {
            return totaleBiglietti;
        }


    }//end class
}
