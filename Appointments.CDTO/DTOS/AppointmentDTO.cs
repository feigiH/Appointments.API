using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.CDTO.DTOS
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public CustomerDTO Customer { get; set; }
        public int CalendarId { get; set; }
        public CalendarDTO Calendar { get; set; }
        public DateTime Start { get; set; }
    }
}
