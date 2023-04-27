using CarsApi.Validations;
using System.ComponentModel.DataAnnotations;

namespace CarsApi.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        [PastProductionDate]
        public DateTime ProductionDate { get; set; }

        public static int _requestCounter = 0;
    }
}
