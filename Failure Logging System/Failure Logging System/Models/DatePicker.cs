using System.ComponentModel.DataAnnotations;

namespace Failure_Logging_System.Models
{
    public class DatePicker
    {
        [Required]
        [Display(Name = "RegisterDate")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}")]
        public DateTime RegisterDate { get; set; }
    }
}
