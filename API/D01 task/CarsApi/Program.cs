
using CarsApi.Models;

namespace CarsApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car._requestCounter = 0;
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //increase counter if any request is requested (this or in add action)
            //app.Use(async (context, next) =>
            //{
            //    //before request
            //    await next(context);
            //    //after request
            //    Car._requestCounter++;
            //});
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}