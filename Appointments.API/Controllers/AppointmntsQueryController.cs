using Appointments.CDTO.DTOS;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Appointments.Services;

namespace Appointments.API.Controllers
{
    [Route("AppointmntsQueryController")]
    [ApiController]
    public class AppointmntsQueryController : Controller
    {
        private readonly IAppointmentService _appointmentsService;

        public AppointmntsQueryController(IAppointmentService appointmentsService) 
        { 
            _appointmentsService = appointmentsService;
        }

        [HttpGet]
        [Route("GetAppointmentsByCustomerId")]
        public async Task<List<AppointmentDTO>> GetAppointmentsByCustomerId(string customerId)
        {
            try
            {
                return await _appointmentsService.GetAppointmentsByCustomer(customerId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetAppointmentsByCalendarId")]
        public async Task<List<AppointmentDTO>> GetAppointmentsByCalendarId(int calendarId)
        {
            try
            {
                return await _appointmentsService.GetAppointmentsByCalendar(calendarId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
