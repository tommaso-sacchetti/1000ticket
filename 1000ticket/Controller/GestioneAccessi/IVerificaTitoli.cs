using System;
namespace _1000ticket.Controller.GestioneAccessi
{
    public interface IVerificaTitoli
    {
        Boolean VerificaBiglietto(string id);
        Boolean VerificaAbb(string id);
        Boolean VerificaPass(string id);
        
    }
}
