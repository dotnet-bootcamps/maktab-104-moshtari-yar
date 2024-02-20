using Contracts;
using Entities;

namespace Data
{
    public class InMemoryDatabase : IDatabase
    {
        private static List<Ticket> _tickets = new List<Ticket>();
        private static List<TicketResponse> _ticketResponses = new List<TicketResponse>();

        public Ticket GetTicketById(int id)
        {
            return _tickets.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateTicket(Ticket ticket)
        {
            var pintedTicket = _tickets.FirstOrDefault(t => t.Id == ticket.Id);
            if (pintedTicket == null)
                return false;

            pintedTicket.Title = ticket.Title;
            pintedTicket.Description = ticket.Description;
            pintedTicket.DepartmentName = ticket.DepartmentName;
            pintedTicket.Priority = ticket.Priority;
            pintedTicket.SubmittedAt = ticket.SubmittedAt;
            pintedTicket.SubmittedBy = ticket.SubmittedBy;
            return true;
        }

        public List<Ticket> GetTickets()
        {
            //var tickets = _tickets.Where(x=>x.IsActive).ToList();
            //return tickets;
            return _tickets;
        }

        public int AddTicket(Ticket model)
        {
            model.Id = 1;
            if (_tickets.Any())
                model.Id = _tickets.Max(s => s.Id) + 1;
            _tickets.Add(model);
            return model.Id;
        }


        public bool AddTicketResponse(int ticketId, string ticketResponse,int SubmittedBy)
        {
            var targetTicket = GetTicketById(ticketId);
            if (targetTicket != null)
            {
                TicketResponse NewResponse = new TicketResponse()
                {
                    Id = GenerateResponseId(ticketId),
                    Text = ticketResponse
                };
                targetTicket.ResponseList.Add(NewResponse);
                return true;
            }

            else
                return false;
        }


        public bool DeleteTicket(int id)
        {
            var targetTicket = GetTicketById(id);

            if (targetTicket != null)
            {
                targetTicket.IsActive = false;
                _tickets.Remove(targetTicket);
                return true;
            }

            else
            {
                return false;
            }
        }

        public int GenerateResponseId(int TicketId)
        {
            var targetTicket = _tickets.First(x => x.Id == TicketId);
            if (targetTicket.ResponseList.Any())
            {
                return targetTicket.ResponseList.Max(x => x.Id) + 1;
            }

            return 1;
        }
    }
}
