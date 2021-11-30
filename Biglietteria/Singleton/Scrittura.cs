using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using Biglietteria.Visitor;
using Biglietteria.Composite;
using Biglietteria.Builder;

namespace Biglietteria.Singleton
{

    public class Scrittura : IScrittura
    {
        private static Scrittura instance;
        private readonly string FilePath;

        public static Scrittura Instance(string FP)
        {
            if (instance == null)
            {
                instance = new Scrittura(FP);
            }
            return instance;
        }

        protected Scrittura(string FP) 
        {
            FilePath = FP;
        }

        public void SalvaDati(IOrder ordine, Cliente cliente)
        {
            
            string[] righe =
            {
                "--------------------------------------------------------",
                ordine.ReturnDescrizione() + " di " + cliente.Nome + " " + cliente.Cognome,
                "",
                "Totale Ordine: " + ordine.ReturnPrezzo() + " €",
                "",

                cliente.Mostra(),
                "",
                ordine.ReturnDescrizione(),
                ordine.Mostra()
            };

            File.AppendAllLines(Path.Combine(FilePath, "FileP.txt"), righe);

            

        }//end salvadati

    }
}
