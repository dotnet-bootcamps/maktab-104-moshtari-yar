using Contracts;
using Entities;

namespace Data;

public class FileRepository : IRepository
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

    public bool DeleteTicket(int id)
    {
        throw new NotImplementedException();
    }

    public Ticket GetTicketById(int id)
    {
        throw new NotImplementedException();
    }

    public bool AddTicketResponse(int ticketId, string ticketResponse)
    {
        throw new NotImplementedException();
    }
}