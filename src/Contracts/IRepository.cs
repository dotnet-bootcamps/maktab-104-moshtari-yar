using Entities;

namespace Contracts
{
    public interface IRepository
    {
        List<Ticket> GetTickets();
        int AddTicket(Ticket model);
        bool UpdateTicket(Ticket ticket);
        bool DeleteTicket(int id);
        Ticket GetTicketById(int id);
        bool AddTicketResponse(int ticketId, string ticketResponse);
    }
}
