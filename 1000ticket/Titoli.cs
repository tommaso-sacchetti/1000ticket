using System;
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
        protected float Prezzo { get; set; }
        protected DateTime OrarioVendita { get; }
        protected string UsernameVenditore { get; }

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

        private TipoAbbonamento TipoTitolo { get; }
        private int IngressiTotali { get; }
        private int IngressiRimanenti { get; set; }
        private DateTime? OrarioUltimoAccesso { get; set; }

        public Abbonamento(TipoAbbonamento tipo, string id, DateTime orarioVendita, string usernameVenditore) :
             base(id, orarioVendita, usernameVenditore)
        {
            TipoTitolo = tipo;
            switch (TipoTitolo)
            {
                case (TipoAbbonamento.abbonamentoDue):
                    {
                        Prezzo = PREZZOABBDUE;
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


        public class Biglietto : TitoloAccesso
        {
            public readonly float PREZZOINTERO = 8;
            public readonly float PREZZORIDOTTO = 6;
            public readonly float PREZZORIDOTTOCONAD = 4.2f;
            public readonly float PREZZORIDOTTOCARTOLINA = 3.8f;
            public readonly float PREZZOOMAGGIO = 0;

            private Boolean stato;
            private TipoBiglietto tipoTitolo;

            public Biglietto(TipoBiglietto tipo, string id,  DateTime orarioVendita, string usernameVenditore): 
                base(id, orarioVendita, usernameVenditore)
            {
                this.stato = false; //false = NON CONVALIDATO, true = GIA' CONVALIDATO
                switch (tipo)
                {
                    case (TipoBiglietto.intero):
                        {
                            this.Prezzo = PREZZOINTERO;
                            break;
                        }
                    case (TipoBiglietto.ridotto):
                        {
                            this.Prezzo = PREZZORIDOTTO;
                            break;
                        }
                    case (TipoBiglietto.ridottoConad):
                        {
                            this.Prezzo = PREZZORIDOTTOCONAD;
                            break;
                        }
                    case (TipoBiglietto.ridottoCartolina):
                        {
                            this.Prezzo = PREZZORIDOTTOCARTOLINA;
                            break;
                        }
                    case (TipoBiglietto.omaggio):
                        {
                            this.Prezzo = PREZZOOMAGGIO;
                            break;
                        }
                }
            }
        }

    }
}
