using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Biglietteria.Composite;
using Biglietteria.Builder;
using Biglietteria.Visitor;



namespace Biglietteria
{
    public static class Estensione
    {

        public static ListViewItem InListViewItem(this IOrder articolo, Settore settore, Stadio stadio)
        {
            string[] riga = { articolo.ReturnDescrizione(), stadio.ReturnDescrizione(), settore.ReturnSettore(), articolo.ReturnPrezzo().ToString() };
            return new ListViewItem(riga);
        }

    }
}
