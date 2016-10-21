using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ZenithDataLib.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public DateTime EventFrom { get; set; }
        public DateTime EventTo { get; set; }
        public string EnteredBy { get; set; }
        public int Activity { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
    }
}