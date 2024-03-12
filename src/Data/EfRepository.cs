using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Databases;
using Entities;

namespace Data
{
    public class EfRepository : IRepository
    {
        private AppDbContext _db;
        public EfRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Ticket> GetTickets()
        {
            return _db.Tickets.ToList();
        }

        public int AddTicket(Ticket model)
        {
            _db.Tickets.Add(model);
            _db.SaveChanges();
            return model.Id;
        }

        public bool UpdateTicket(Ticket model)
        {
            var dbRecord = _db.Tickets.FirstOrDefault(f => f.Id == model.Id);
            if (dbRecord != null)
            {
                dbRecord.Title = model.Title;
                dbRecord.Description = model.Description;
                dbRecord.Priority = model.Priority;

                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteTicket(int id)
        {
            var dbRecord = _db.Tickets.FirstOrDefault(f => f.Id == id);
            if (dbRecord != null)
            {
                _db.Tickets.Remove(dbRecord);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public Ticket GetTicketById(int id)
        {
            var dbRecord = _db.Tickets.FirstOrDefault(f => f.Id == id);
            return dbRecord;
        }

        public bool AddTicketResponse(int ticketId, string ticketResponse)
        {
            var dbRecord = _db.Tickets.FirstOrDefault(f => f.Id == ticketId);
            if (dbRecord != null)
            {
                dbRecord.TicketResponse = ticketResponse;

                _db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
