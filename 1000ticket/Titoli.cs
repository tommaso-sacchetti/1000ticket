using System;
namespace _1000ticket
{
    public enum TipoAbbonamento
    {
        abbonamentoDue = 0,
        abbonamentoCinque = 1,
        abbonamentoDieci = 2,
    }

    public abstract class TitoloAccesso
    {
        protected string Id { get; }
        protected int Prezzo { get; }
        protected DateTime OrarioVendita { get; }
        protected string UsernameVenditore { get; }

        public TitoloAccesso(string Id, int Prezzo, DateTime OrarioVendita, string UsernameVenditore)
        {
            this.Id = Id;
            this.Prezzo = Prezzo;
            this.OrarioVendita = OrarioVendita;
            this.UsernameVenditore = UsernameVenditore;
        }
    }


    public class Abbonamento : TitoloAccesso
    {
        protected int prezzoAbbonamentoDue { get; } = 18;
        protected int prezzoAbbonamentoCinque { get; } = 45;
        protected int prezzoAbbonamentoDieci { get; } = 90;

        protected TipoAbbonamento TipoTitolo { get; }
        protected int IngressiTotali { get; }
        protected int IngressiRimanenti { get; set; }
        protected DateTime? OrarioUltimoAccesso { get; set; }

        public Abbonamento(TipoAbbonamento tipo, string id, int prezzo, DateTime orarioVendita, string usernameVenditore) :
             base(id, prezzo, orarioVendita, usernameVenditore)
        {
            TipoTitolo = tipo;
            IngressiTotali = (int)TipoTitolo == 0 ? prezzoAbbonamentoDue : 
                (int)TipoTitolo == 1 ? prezzoAbbonamentoCinque : prezzoAbbonamentoDieci;
            IngressiRimanenti = IngressiTotali;
            OrarioUltimoAccesso = null;
            /*
            Id = id;
            Prezzo = prezzo;
            OrarioVendita = orarioVendita;
            UsernameVenditore = usernameVenditore;
            */           
        }


    }
}
