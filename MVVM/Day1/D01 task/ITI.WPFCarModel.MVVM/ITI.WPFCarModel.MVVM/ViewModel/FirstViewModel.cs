using ITI.WPFCarModel.MVVM.Commands;
using ITI.WPFCarModel.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ITI.WPFCarModel.MVVM.ViewModel
{
    public class FirstViewModel
    {
        public ObservableCollection<Car> CarList { get; set; }
        public ICommand AddCommand { get; set; }
        public Car NewCar { get; set; }

        public FirstViewModel()
        {
            AddCommand = new AddCarCommand(Add, CanAdd);

            NewCar = new();
            CarList = new ObservableCollection<Car>()
            {
                new Car { Name = "Toyota Camry", Id = 1, Price = 25000, Model = "2022" , Color = "Red"},
                new Car { Name = "Honda Accord", Id = 2, Price = 28000, Model = "2022" , Color = "LightBlue"},
                new Car { Name = "Ford Mustang", Id = 3, Price = 40000, Model = "2022" , Color = "LightPink"},
                new Car { Name = "Chevrolet Corvette", Id = 4, Price = 70000, Model = "2022" , Color = "Yellow"}
                //new Car { Name = "Tesla Model S", Id = 5, Price = 90000, Model = "2022", Color = "White" }
        };

        }

        private bool CanAdd(object obj)
        {
            return true;
        }

        private void Add(object obj)
        {
            Car NCar = obj as Car;
            var car = new Car();
            car.Color = NCar.Color;
            car.Name = NCar.Name;
            car.Model = NCar.Model;
            car.Price = NCar.Price;
            car.Id = NCar.Id;
            CarList.Add(car);
            MessageBox.Show("Added");

        }
    }
}
