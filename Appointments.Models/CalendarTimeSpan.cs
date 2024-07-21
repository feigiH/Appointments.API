using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.Models
{
    [Table("CalendarTimeSpans")]
    public class CalendarTimeSpan
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public TimeOnly FromHour { get; set; }
        public TimeOnly ToHour { get; set; }
        [ForeignKey("Calendar")]
        public int CalendarId { get; set; }
        public virtual Calendar Calendar { get; set; }
    }
}
