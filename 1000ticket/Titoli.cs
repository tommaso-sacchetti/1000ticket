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
        protected string id;
        public string Id { get { return id; } }
        protected float prezzo;
        public float Prezzo { get { return prezzo; } set { prezzo = value; } }
        protected DateTime orarioVendita;
        public DateTime OrarioVendita { get { return orarioVendita; } set { orarioVendita = value; } }
        protected string usernameVenditore;
        public string UsernameVenditore { get { return usernameVenditore; } set { usernameVenditore = value; } }

        protected TitoloAccesso(string Id, DateTime OrarioVendita, string UsernameVenditore)
        {
            this.id = Id;
            this.orarioVendita = OrarioVendita;
            this.usernameVenditore = UsernameVenditore;
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
                        ingressiTotali = 2;
                        Prezzo = PREZZOABBDUE;  //qua bisogna usare il 
                        break;
                    }
                case (TipoAbbonamento.abbonamentoCinque):
                    {
                        ingressiTotali = 5;
                        Prezzo = PREZZOABBCINQUE;
                        break;
                    }
                case (TipoAbbonamento.abbonamentoDieci):
                    {
                        ingressiTotali = 10;
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

        private Boolean stato;
        public Boolean Stato { get { return stato; } set { stato = value; } }
        private TipoBiglietto tipoTitolo;
        public TipoBiglietto TipoTitolo { get { return tipoTitolo; } set { tipoTitolo = value; } }

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
        private string id;
        public string Id { get { return id; } set { id = value; } }
        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }
        private string cognome;
        public string Cognome { get { return cognome; } set { cognome = value; } }
        private string codFisc;
        public string CodFisc { get { return codFisc; } set { codFisc = value; } }
        private string azienda;
        public string Azienda { get { return azienda; } set { azienda = value; } }
        private Object foto;
        public Object Foto { get { return foto; } set { foto = value; } }

    }
}
