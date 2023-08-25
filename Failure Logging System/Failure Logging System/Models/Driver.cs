using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Failure_Logging_System.Models
{
    public class Driver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string driverName { get; set; }
        public string? BatchCode { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string? Type { get; set; }
        public string? Location { get; set; }
        public string FailureFault { get; set; }
        public bool Discarded { get; set; }
        public string? Notes { get; set; }
        public Driver() { }
    }
}
