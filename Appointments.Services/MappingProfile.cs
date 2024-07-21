using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.CDTO.Commands;
using Appointments.CDTO.DTOS;
using Appointments.Models;
using AutoMapper;

namespace Appointments.Services
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Appointment, AppointmentDTO>();
            CreateMap<CalendarTimeSpan, CalendarTimeSpanDTO>();
            CreateMap<Calendar, CalendarDTO>();
            CreateMap<Customer, CustomerDTO>();

            CreateMap<SetAppointmentCommand, Appointment>();
        }
    }
}
