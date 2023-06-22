using Microsoft.AspNetCore.Components.Routing;
using System;

namespace Failure_Logging_System.Models
{
    public class Driver
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string BatchCode { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string FailureFault { get; set; }
        public bool Discarded { get; set; }
        public Driver() { }
    }
}
