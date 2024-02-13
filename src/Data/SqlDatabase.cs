using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities;

namespace Data
{
    public class SqlDatabase : IDatabase
    {
        public List<Ticket> GetTickets()
        {
            throw new NotImplementedException();
        }

        public int AddTicket(Ticket model)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
