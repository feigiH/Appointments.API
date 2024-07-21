using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.Models
{
    [Table("Appointments")]
    public class Appointment
    {
        
        public int Id { get; set; }

        [ForeignKey("Custoner")]
        public string CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("Calendar")]
        public int CalendarId { get; set; }
       
        public virtual Calendar Calendar { get; set; }
        public DateTime Start { get; set; }
    }
}
