using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<CalendarTimeSpan> CalendarTimeSpan { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}
