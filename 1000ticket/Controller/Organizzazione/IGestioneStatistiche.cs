using System;
namespace _1000ticket.Controller.Organizzazione
{
    public interface IGestioneStatistiche
    {
        void CalcolaStatistica(string nomeOperatore, DateTime giorno, DateTime inizio, DateTime fine);
    }
}
