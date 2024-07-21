
using Appointments.Models;
using Appointments.Repo;
using Appointments.Services;
using Microsoft.EntityFrameworkCore;

namespace Appointments.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuration
            builder.Configuration.AddJsonFile("appsettings.json", optional: false);

            // Database context
            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AppointmentsDB")));
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
            builder.Services.AddScoped<IAppointmentService, AppointmentService>();
            // Learn more about configuring Swagger)
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/V1/swagger.json", "Api"));
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
