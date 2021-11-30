using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Biglietteria.Visitor;
using Biglietteria.Composite;
using Biglietteria.Builder;


namespace Biglietteria.Singleton
{
    public interface IScrittura
    {
        void SalvaDati(IOrder ordine, Cliente cliente);
    }
}
