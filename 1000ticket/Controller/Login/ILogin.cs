using System;
namespace _1000ticket.Controller.Login
{
    public interface ILogin
    {
        Boolean VerificaCredenziali(string username, string password);
        Boolean VerificaSessione(string username, string password);
    }
}
