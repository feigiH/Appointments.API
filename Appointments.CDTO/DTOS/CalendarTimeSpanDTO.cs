using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.CDTO.DTOS
{
    public class CalendarTimeSpanDTO
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public TimeOnly FromHour { get; set; }
        public TimeOnly ToHour { get; set; }
        public int CalendarId { get; set; }
        public  CalendarDTO  Calendar { get; set; }
    }
}
