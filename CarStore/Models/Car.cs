using Microsoft.AspNetCore.Mvc;

namespace CarStore.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public decimal Price { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}

