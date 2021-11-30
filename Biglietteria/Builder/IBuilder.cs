using System;
using System.Collections.Generic;
using System.Text;

namespace Biglietteria.Builder
{
    public interface IBuilder
    {
        void ImpostaSettore(string lettera);
        void AggiungiDescrizione(string nome);
        void ImpostaPrezzo(double prezzo);
        
    }
}
