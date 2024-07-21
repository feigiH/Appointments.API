using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.CDTO.Commands;
using Appointments.CDTO.DTOS;

namespace Appointments.Services
{
    public interface IAppointmentService
    {
        Task<List<AppointmentDTO>> GetAppointmentsByCustomer(string id);

        Task<List<AppointmentDTO>> GetAppointmentsByCalendar(int id);

        Task<int> SetAppointment(SetAppointmentCommand setAppointmentCommand);

        Task<bool> DeleteAppointment(DeleteAppointmentCommand deleteAppointmentCommand);


    }
}
