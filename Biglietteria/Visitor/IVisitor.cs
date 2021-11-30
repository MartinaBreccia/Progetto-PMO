using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Builder;
using Biglietteria.Composite;

namespace Biglietteria.Visitor
{
    public interface IVisitor
    {
        void Visit(Settore settore);
        void Visit(Stadio stadio);
        void Visit(Articolo articolo);

        object TotaleBiglietti();

        void Reset();

    }
}
