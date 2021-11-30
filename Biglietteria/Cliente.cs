using System;
using System.Collections.Generic;
using System.Text;

namespace Biglietteria
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string Citta { get; set; }
        public long Telefono { get; set; }


        public string Mostra()
        {
            return "DATI CLIENTE :\nNome : " + Nome + "\nCognome : " + Cognome + "\nIndirizzo : " + Indirizzo + "\nCittà : " + Citta + "\nTelefono : " + Telefono;
        }
    }
}
