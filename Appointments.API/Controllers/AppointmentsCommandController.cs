using Microsoft.AspNetCore.Mvc;
using Appointments.Services;

using Appointments.CDTO.Commands;

namespace Appointments.API.Controllers
{
    public class AppointmentsCommandController : Controller
    {
        private readonly IAppointmentService _appointmentsService;

        public AppointmentsCommandController(IAppointmentService appointmentsService)
        {
            _appointmentsService = appointmentsService;
        }

        //[HttpPost]
        //public async Task<IActionResult> AddApointment(SetAppointmentCommand setAppointmentCommand)
        //{
           
        //}
    }
}
