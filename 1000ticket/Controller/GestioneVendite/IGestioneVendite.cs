using System;
using _1000Ticket.Model;

namespace _1000ticket.Controller.GestioneVendite
{
    public interface IGestioneVendite
    {
        Biglietto AcquistoBiglietto(TipoBiglietto tipo);
        Abbonamento AcquistoAbb(TipoAbbonamento tipo);
        void FineSessione();
    }
}
