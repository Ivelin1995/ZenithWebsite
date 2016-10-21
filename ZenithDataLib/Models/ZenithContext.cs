using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Text;
using System.Runtime.Remoting.Contexts;

namespace ZenithDataLib.Models
{
    public class ZenithContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}