using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Builder;
using Biglietteria.Composite;
using Biglietteria.Visitor;

namespace Biglietteria
{
    public interface IVisualizzaBig
    {
        void ImpostaController(Controller controller);
        void AggiungiInLista(IOrder articolo, Settore settore , Stadio stadio);
        void StampaCalcolatore(IVisitor totalePrezzo, IVisitor totQuantita, IVisitor prezzoMedio);
        void RimuoviDallaLista();
        void StampaCarrello(IOrder articolo);
        bool StampaRicevuta(IOrder ordine, Cliente cliente);
        string ReturnNomeArticoloSelected();
        void ChiudiProgramma();
        void ModificaOrdine();


        
        string NomeSettore { get; }
        string NomeStadio { get; }
        double Prezzo { get; }

        string NomeCliente { get; }
        string CognomeCliente { get; }
        string CittaCliente { get; }
        string IndirizzoCliente { get; }
        long TelefonoCliente { get; }


    }
}
