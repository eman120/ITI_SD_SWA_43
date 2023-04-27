
using Microsoft.EntityFrameworkCore;
using TicketsReservation.BL.Managers;
using TicketsReservation.DAL.Data.Context;
using TicketsReservation.DAL.Repos;

namespace TicketsReservation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            #endregion

            #region Repos
            builder.Services.AddScoped<ITicketRepo, TicketRepo>();
            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();
            builder.Services.AddScoped<IDeveloperRepo, DeveloperRepo>();
            #endregion

            #region Manager
            builder.Services.AddScoped<ITicketManager, TicketManager>();
            builder.Services.AddScoped<IDepartmentManager, DepartmentManager>();
            //builder.Services.AddScoped<IDeveloperManager, DeveloperManager>();
            #endregion

            #region Database
            var connectionString = builder.Configuration.GetConnectionString("TicketCon");
            builder.Services.AddDbContext<TicketReservationContext>(options
                => options.UseSqlServer(connectionString));

            //builder.Services.AddDbContext<TicketReservationContext>(option =>
            //option.UseSqlServer(builder.Configuration.GetConnectionString("TicketCon")));
            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}