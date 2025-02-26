using Microsoft.AspNetCore.Mvc;
using CarStore.Models;

namespace CarStore.Controllers
{
    public class CarController : Controller
    {
        private static readonly List<Car> Cars = new List<Car>
    {
        new Car { Brand = "Mercedes", Model = "S-Class", Year = 2023, Price = 120000, Rating = 4.8, Description = "Luxury sedan" },
        new Car {Brand = "BMW", Model = "7 Series", Year = 2022, Price = 100000, Rating = 4.7, Description = "Luxury sedan"},

        new Car {Brand = "Ferrari", Model = "Ferrari 488", Year = 2021, Price = 250000, Rating = 4.9, Description = "Luxury sedan"},
        new Car {Brand = "Lamborghini", Model = "Lamborghini Huracan", Year = 2022, Price = 270000, Rating = 5.0, Description = "Luxury sedan"},

        new Car {Brand = "Ford", Model = "Ford Mustang 1969", Year = 1969, Price = 80000, Rating = 4.6, Description = "Luxury sedan"},
        new Car {Brand = "Chevrolet", Model = "Chevrolet Impala 1967", Year = 1967, Price = 75000, Rating = 4.5, Description = "Luxury sedan"}
    };

    public IActionResult Luxury()
    {
        var luxuryCars = Cars.Where(c => c.Brand == "Mercedes" || c.Brand == "BMW").ToList();
        return View(luxuryCars);
    }

    public IActionResult Sports()
    {
        var sportsCars = Cars.Where(c => c.Brand == "Ferrari" || c.Brand == "Lamborghini").ToList();
        return View(sportsCars);
    }

    public IActionResult Classic()
    {
        var classicCars = Cars.Where(c => c.Brand == "Ford" || c.Brand == "Chevrolet").ToList();
        return View(classicCars);
    }

    public IActionResult Details(int id)
    {
        var car = Cars.FirstOrDefault(c => c.Id == id);
        if (car == null)
        {
            return NotFound();
        }
        return View(car);
    }
}
}