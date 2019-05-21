using System;
using System.Data.Common;

namespace _1000ticket.Controller.Persistence
{
    public class PersistenceController
    {
        private readonly DbConnection connection;
        public DbConnection GetConnection { get { return this.connection; } }

        public PersistenceController()
        {
        }

    }
}
