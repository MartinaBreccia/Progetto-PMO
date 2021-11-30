using System;
using System.Collections.Generic;
using System.Text;
using Biglietteria.Composite;
using Biglietteria.Builder;
using Biglietteria.Visitor;
using System.Windows.Forms;
using Biglietteria.Singleton;

namespace Biglietteria
{
    public class Controller
    {
        IOrder ordine = new Articolo("Ordine Finale");
        IOrder articolo;
        Stadio stadio;
        Settore settore;
        Cliente cliente;

        private int numOrdine;

        IVisitor totalePrezzo;
        IVisitor prezzoMedio;
        IVisitor totQuantita;

        IVisualizzaBig visualizza;
        private Scrittura file;


        //costruttore
        public Controller(IVisualizzaBig visua, string flink)
        {
            this.visualizza = visua;
            visualizza.ImpostaController(this);
            numOrdine = 0;
            totalePrezzo = new TotalePrezzo();
            prezzoMedio = new PrezzoMedio();
            totQuantita = new TotQuantita();
            file = Scrittura.Instance(flink);
            cliente = new Cliente();
        }//end costruttore

        public void AggiungiCarrello()
        {
            settore = CreazioneSettore(visualizza.NomeSettore);
            stadio = new Stadio(visualizza.NomeStadio);

            articolo = CreaCarrello(settore, stadio);
            Calcolatore();
            visualizza.AggiungiInLista(articolo, settore, stadio);

        }

        private void Calcolatore()
        {
            totalePrezzo.Reset();
            totQuantita.Reset();
            prezzoMedio.Reset();
            
            foreach (IOrder elemento in ordine.ReturnArticolo())
            {
                elemento.Accetta(totalePrezzo);
                elemento.Accetta(prezzoMedio);
                elemento.Accetta(totQuantita);

                foreach (IOrder articolo in elemento.ReturnArticolo())
                {
                    articolo.Accetta(totalePrezzo);
                    articolo.Accetta(prezzoMedio);
                    articolo.Accetta(totQuantita);
                }
            }

            visualizza.StampaCalcolatore(totalePrezzo, prezzoMedio, totQuantita);

        }//end calcolatore()

        private Settore CreazioneSettore(string nomeSettore)
        {
            var director = new CreaSettore(nomeSettore);
            var builder = new ConcreteBuilder();

            director.Builder = builder;
            director.CreaBiglietto();
            
            return builder.GetProduct();

        }
        private IOrder CreaCarrello(Settore settore, Stadio stadio)
        {
            numOrdine++;
            IOrder articolo = new Articolo("Articolo "+ numOrdine);
            articolo.AggiungiArticolo(stadio);
            articolo.AggiungiArticolo(settore);
            ordine.AggiungiArticolo(articolo);

            return articolo;

        }

        public void RimuoviCarrello()
        {
            IOrder elemento;
            string nomeArticolo;
            

            nomeArticolo = visualizza.ReturnNomeArticoloSelected();

            elemento = ordine.CercaArticolo(nomeArticolo);
            ordine.RimuoviArticolo(elemento);

            visualizza.RimuoviDallaLista();
            
            Calcolatore();
            
        }


        //creo cliente
        public void CreoCliente()
        {
            cliente.Nome = visualizza.NomeCliente;
            cliente.Cognome = visualizza.CognomeCliente;
            cliente.Citta = visualizza.CittaCliente;
            cliente.Indirizzo = visualizza.IndirizzoCliente;
            cliente.Telefono = visualizza.TelefonoCliente;

            CreaRicevuta();
        }

        public void CreaRicevuta()
        {
            bool conferma;
            conferma = visualizza.StampaRicevuta(ordine, cliente);

            if (conferma == true)
            {
                file.SalvaDati(ordine, cliente);
                visualizza.ChiudiProgramma();
            }
            else
            {
                visualizza.ModificaOrdine();
            }
        }
    }
}
