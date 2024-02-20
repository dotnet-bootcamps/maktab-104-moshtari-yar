using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Ticket
    {
        public Ticket()
        {
            SubmittedAt = DateTime.Now;
        }

        [Display(Name = "شناسه")]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }

        /// <summary>
        /// توضیحات متنی تیکت یا درخواست
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        [Display(Name = "اولویت")]
        public PriorityEnum Priority { get; set; }

        //public int DepartmentId { get; set; }
        [Display(Name = "ارجاع به واحد")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// زمان ثبت تیکت
        /// </summary>
        ///
        [Display(Name = "زمان ارسال")]
        public DateTime SubmittedAt { get; set; }

        /// <summary>
        /// آی دی شخصی که تیکت را ثبت کرده است
        /// </summary>
        ///
        [Display(Name = "شناسه ارسال کننده")]
        public int SubmittedBy { get; set; }

        //[Display(Name = "پاسخ :")]
        //public string? TicketResponse { get; set; }

        [DisplayName("پاسخ ها")]
        public List<TicketResponse>? ResponseList { get; set; } = new List<TicketResponse>();

        public bool IsActive { get; set; } = true;
    }

    //public class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
