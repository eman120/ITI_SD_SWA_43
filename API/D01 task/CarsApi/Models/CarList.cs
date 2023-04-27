namespace CarsApi.Models
{
    public class CarList
    {
        public static readonly List<Car> cars = new List<Car>()
        {
            new Car { Id = 1, Name ="car1", Model = "Tesla"},
            new Car { Id = 2, Name ="car2", Model = "Sony"},
            new Car { Id = 3, Name ="car3", Model = "Ford"},
            new Car { Id = 4, Name ="car4", Model = "BMW"},
        };
    }
}
