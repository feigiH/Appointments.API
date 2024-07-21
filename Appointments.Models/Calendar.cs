using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.Models
{
    [Table("Calendars")]
    public class Calendar
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan AppointmentDuration {  get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<CalendarTimeSpan> CalendarTimeSpans { get; set; }
    }
}
