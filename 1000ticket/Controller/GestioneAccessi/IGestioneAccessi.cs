using System;
namespace _1000ticket.Controller.GestioneAccessi
{
    public interface IGestioneAccessi
    {
        Boolean VerificaTitolo(string ID);
        void MostraNotifica(Boolean verifica);
    }
}
