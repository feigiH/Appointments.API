using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Models;

namespace Appointments.Repo
{
    public interface IAppointmentRepository
    {
        Task<List<Appointment>> GetAppointmentsByCustomerId(string customerId);
        Task<List<Appointment>> GetAppointmentsByCalendarId(int calendarId);

        Task<int> AddAppoinment(Appointment appointment);

        Task<bool> DeleteAppoinment(int appointmentId);
    }
}
