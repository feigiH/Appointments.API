using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.CDTO.DTOS
{
    public class CalendarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan AppointmentDuration { get; set; }
        public virtual ICollection<AppointmentDTO> Appointments { get; set; }
        public virtual ICollection<CalendarTimeSpanDTO> CalendarTimeSpans { get; set; }
    }
}
