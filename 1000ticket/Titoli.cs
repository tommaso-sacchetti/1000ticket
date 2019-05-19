using System;
using System.IO

namespace _1000ticket
{

    public enum TipoAbbonamento
    {
        abbonamentoDue = 1,
        abbonamentoCinque = 2,
        abbonamentoDieci = 3,
    }

    public enum TipoBiglietto
    {
        intero = 1,
        ridotto = 2,
        ridottoConad = 3,
        ridottoCartolina = 4,
        omaggio = 5
    }

    public abstract class TitoloAccesso
    {
        protected string Id { get; }
        //public string Id { get { return id; } }
        protected float Prezzo { get; set; }
        //public float Prezzo { get { return prezzo; } set { prezzo = value; } }
        protected DateTime OrarioVendita { get; set; }
        //public DateTime OrarioVendita { get { return orarioVendita; } set { orarioVendita = value; } }
        protected string UsernameVenditore { get; set; }
        //public string UsernameVenditore { get { return usernameVenditore; } set { usernameVenditore = value; } }

        protected TitoloAccesso(string Id, DateTime OrarioVendita, string UsernameVenditore)
        {
            this.Id = Id;
            this.OrarioVendita = OrarioVendita;
            this.UsernameVenditore = UsernameVenditore;
        }

    }


    public class Abbonamento : TitoloAccesso
    {
        public readonly int PREZZOABBDUE = 10;
        public readonly int PREZZOABBCINQUE = 15;
        public readonly int PREZZOABBDIECI = 20;

        private TipoAbbonamento tipoTitolo;
        public TipoAbbonamento TipoTitolo { get { return tipoTitolo; } set { tipoTitolo = value; } }
        private readonly int ingressiTotali;
        public int IngressiTotali { get { return ingressiTotali; } }
        private int ingressiRimanenti;
        public int IngressiRimanenti { get { return ingressiRimanenti; } set { ingressiRimanenti = value; } }
        private DateTime? orarioUltimoAccesso;
        public DateTime? OrarioUltimoAccesso { get { return orarioUltimoAccesso; } set { orarioUltimoAccesso = value; } }

        public Abbonamento(TipoAbbonamento tipo, string id, DateTime orarioVendita, string usernameVenditore) :
             base(id, orarioVendita, usernameVenditore)
        {
            TipoTitolo = tipo;

            switch (tipo)
            {
                case (TipoAbbonamento.abbonamentoDue):
                    {
                        Prezzo = PREZZOABBDUE;  //qua bisogna usare il 
                        break;
                    }
                case (TipoAbbonamento.abbonamentoCinque):
                    {
                        Prezzo = PREZZOABBCINQUE;
                        break;
                    }
                case (TipoAbbonamento.abbonamentoDieci):
                    {
                        Prezzo = PREZZOABBDIECI;
                        break;
                    }

            }
            IngressiRimanenti = IngressiTotali;
            OrarioUltimoAccesso = null;
        }
    }


    public class Biglietto : TitoloAccesso
    {
        public readonly float PREZZOINTERO = 8;
        public readonly float PREZZORIDOTTO = 6;
        public readonly float PREZZORIDOTTOCONAD = 4.2f;
        public readonly float PREZZORIDOTTOCARTOLINA = 3.8f;
        public readonly float PREZZOOMAGGIO = 0;

        private Boolean Stato { get; set; }
        private TipoBiglietto TipoTitolo { get; set; }

        public Biglietto(TipoBiglietto tipo, string id, DateTime orarioVendita, string usernameVenditore) :
            base(id, orarioVendita, usernameVenditore)
        {
            this.Stato = false; //false = NON CONVALIDATO, true = GIA' CONVALIDATO
            switch (tipo)
            {
                case (TipoBiglietto.intero):
                    {
                        Prezzo = PREZZOINTERO;
                        break;
                    }
                case (TipoBiglietto.ridotto):
                    {
                        Prezzo = PREZZORIDOTTO;
                        break;
                    }
                case (TipoBiglietto.ridottoConad):
                    {
                        Prezzo = PREZZORIDOTTOCONAD;
                        break;
                    }
                case (TipoBiglietto.ridottoCartolina):
                    {
                        Prezzo = PREZZORIDOTTOCARTOLINA;
                        break;
                    }
                case (TipoBiglietto.omaggio):
                    {
                        Prezzo = PREZZOOMAGGIO;
                        break;
                    }
            }
        }
    }

    public class PassEspositore
    {
        private string Id { get; }
        private string Nome;
        private string Cognome;
        private string CodFisc;
        private string Azienda;
        private Object Foto;

    }
}
