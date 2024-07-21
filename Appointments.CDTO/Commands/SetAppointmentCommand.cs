using Appointments.CDTO.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.CDTO.Commands
{
    public class SetAppointmentCommand
    {
        public string CustomerId { get; set; }
        public int CalendarId { get; set; }
        public DateTime Start { get; set; }
    }
}
