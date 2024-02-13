using Contracts;
using Entities;

namespace Data;

public class RedisDatabase : IDatabase
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