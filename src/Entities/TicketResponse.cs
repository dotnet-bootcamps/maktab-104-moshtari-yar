using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TicketResponse
    {
        public TicketResponse()
        {
            ResponseDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Text { get; set; }
        public DateTime ResponseDate { get; set; }
        public int SubmittedBy { get; set; }
    }
}
