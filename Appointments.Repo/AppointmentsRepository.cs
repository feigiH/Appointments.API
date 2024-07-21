using Appointments.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointments.Repo
{

    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext context;

        public AppointmentRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<List<Appointment>> GetAppointmentsByCalendarId(int calendarId)
        {
            return await context.Appointments.Where(
                a => a.CalendarId == calendarId).ToListAsync();
        }

        public async Task<List<Appointment>> GetAppointmentsByCustomerId(string customerId)
        {
            return await context.Appointments.Where(
                a => a.CustomerId == customerId).ToListAsync();
        }

        public async Task<int> AddAppoinment(Appointment appointment)
        {
            var a = context.Appointments.Add(appointment);
            await context.SaveChangesAsync();
            return a.Entity.Id;

        }

        public async Task<bool> DeleteAppoinment(int appointmentId)
        {
            Appointment a = await context.Appointments.FirstOrDefaultAsync(a => a.Id == appointmentId);
            if (a == null)
            {
                return false;
            }
            
            context.Appointments.Remove(a);
            await context.SaveChangesAsync();
            return true;
        }
    }
}

   
