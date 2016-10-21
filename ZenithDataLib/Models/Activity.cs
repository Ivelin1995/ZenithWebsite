using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZenithDataLib.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime CreationDate { get; set; }
    }
}