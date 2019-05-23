using System;
using System.Net;
using _1000Ticket.Model;

namespace _1000ticket.Controller.GestioneVendite
{
    public class GestioneVenditeController : IGestioneVendite
    {


        private readonly IPEndPoint server;
        public IPEndPoint GetServerEP { get { return this.server; } }

        //scrivo queste cose per prova, se vuoi puoi cambiare

        public GestioneVenditeController()
        {
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];
            this.server = new IPEndPoint(ipAddress, 11000);
            
        }

        public Biglietto AcquistoBiglietto(TipoBiglietto tipo)
        {
            return null;
        }

        public Abbonamento AcquistoAbb(TipoAbbonamento tipo)
        {
            return null;
        }

        public void FineSessione() { }

    }
}
