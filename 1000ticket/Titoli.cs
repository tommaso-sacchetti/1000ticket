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
        public string Id { get; }
        public int Prezzo { get; }
        public DateTime OrarioVendita { get; }
        public string UsernameVenditore { get; }

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
        public TipoAbbonamento TipoTitolo { get; }
        public int IngressiTotali { get; }
        public int IngressiRimanenti { get; set; }
        public DateTime? OrarioUltimoAccesso { get; set; }

        public Abbonamento(TipoAbbonamento tipo, string id, int prezzo, DateTime orarioVendita, string usernameVenditore) :
             base(id, prezzo, orarioVendita, usernameVenditore)
        {
            TipoTitolo = tipo;
            IngressiTotali = (int)TipoTitolo == 0 ? 2 : (int)TipoTitolo == 1 ? 5 : 10;
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
