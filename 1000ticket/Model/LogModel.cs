using System;
namespace _1000ticket.Model
{
    public class Operazione
    {
        private DateTime orario;
        private string tipoOperazione;
        private string descrizione;

        public DateTime Orario { get { return this.orario; } set { this.orario = value; } }
        public string TipoOperazione { get { return this.tipoOperazione; } set { this.tipoOperazione = value; } }
        public string Descrizione { get { return this.descrizione; } set { this.descrizione = value; } }

    }
}
