
using Entities;
using System.ComponentModel.DataAnnotations;

public class TicketDTO
{
    //public TicketDTO(int id, string title, string description, int submittedBy)
    //{
    //    Id = id;
    //    Title = title;
    //    Description = description;
    //    SubmittedBy = submittedBy;
    //}

    [Display(Name = "شناسه")]
    public int Id { get; set; }

    [Display(Name = "عنوان")]
    public string Title { get; set; }

    [Display(Name = "توضیحات")]
    public string Description { get; set; }

    //[Display(Name = "اولویت")]
    //public PriorityEnum Priority { get; set; }


    //[Display(Name = "ارجاع به واحد")]
    //public string DepartmentName { get; set; }

    //[Display(Name = "زمان ارسال")]
    //public DateTime SubmittedAt { get; set; }

    [Display(Name = "شناسه ارسال کننده")]
    public int SubmittedBy { get; set; }

    [Display(Name = "پاسخ :")]
    public string? TicketResponse { get; set; }
}