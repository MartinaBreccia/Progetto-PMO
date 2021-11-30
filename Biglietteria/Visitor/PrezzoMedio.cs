using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Composite;
using System.Linq;
using Biglietteria.Builder;

namespace Biglietteria.Visitor
{
    public class PrezzoMedio : IVisitor
    {
        private List<double> totaleSettore = new List<double>();
        

        public object TotaleBiglietti()
        {
            if(totaleSettore.Count > 0)
            {
                return totaleSettore.Average();
            }
            else
            {
                return 0;
            }

        }

        public void Visit(Settore settore)
        {
            totaleSettore.Add(settore.ReturnPrezzo());
        }

        public void Visit(Stadio stadio) { }
        public void Visit(Articolo articolo) { }
 
        public void Reset()
        {
            totaleSettore.Clear();
            
        }

    }//end class

}
