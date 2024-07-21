using Appointments.CDTO.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Repo;
using AutoMapper;
using Appointments.CDTO.Commands;
using Appointments.Models;

namespace Appointments.Services
{
    public class AppointmentService:IAppointmentService
    {
        private IAppointmentRepository _repository;
        private readonly IMapper _mapper;
        public AppointmentService(IAppointmentRepository repo, IMapper mapper) {
            _repository = repo;
            _mapper = mapper;
        }

        public async Task<List<AppointmentDTO>> GetAppointmentsByCalendar(int id)
        {
            return _mapper.Map<List<AppointmentDTO>>(
                _repository.GetAppointmentsByCalendarId(id));
        }

        public async Task<List<AppointmentDTO>> GetAppointmentsByCustomer(string id)
        {
            return _mapper.Map<List<AppointmentDTO>>(
                _repository.GetAppointmentsByCustomerId(id));
        }

        public async Task<int> SetAppointment(SetAppointmentCommand setAppointmentCommand)
        {
            return await _repository.AddAppoinment(
                _mapper.Map<Appointment>(setAppointmentCommand));
        }

        public async Task<bool> DeleteAppointment(DeleteAppointmentCommand deleteAppointmentCommand)
        {
            return await _repository.DeleteAppoinment(deleteAppointmentCommand.Id);
        }
    }
}
