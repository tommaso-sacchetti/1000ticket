using System;
namespace _1000ticket.Controller.Organizzazione
{
    public interface IGestioneModifica
    {
        void ModificaPass(string ID, string nomeEsp, string cognomeEsp, string asiendaEsp, string codFiscEsp, object foto);
    }
}
