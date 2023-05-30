using MotoApp.Entities;
using MotoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MotoApp.DataProviders
{
    public class CarsProvider : ICarsProvider
    {
        private readonly IRepository<Car> _carsRepository;

        public CarsProvider(IRepository<Car> carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public string AnonymousClass()
        {
            var cars = _carsRepository.GetAll();
            var list = cars.Select(car => new
            {
                Identifier = car.Id,
                ProductName = car.Name,
                ProductSize = car.Type
            });

            StringBuilder sb = new(2048);
            foreach (var car in list)
            {
                sb.AppendLine($"Product ID: {car.Identifier}");
                sb.AppendLine($"Product name: {car.ProductName}");
                sb.AppendLine($"Product Size: {car.ProductSize}");
            }

            return sb.ToString();
        }

        public List<Car> FilterCars(decimal minPrice)
        {
            throw new NotImplementedException();
        }

        public decimal GetMinPriceOfAllCars()
        {
            var cars = _carsRepository.GetAll();
            return cars.Select(x => x.ListPrice).Min();
        }

        public List<Car> GetSpecificColumns()
        {
            var cars = _carsRepository.GetAll();
            var list = cars.Select(car => new Car
            {
                Id = car.Id,
                Name = car.Name,
                Type = car.Type
            }).ToList();

            return list;
        }

        public List<string> GetUniqueCarColors()
        {
            var cars = _carsRepository.GetAll();
            var colors = cars.Select(x => x.Color).Distinct();
            return colors.ToList();
        }
    }
}
