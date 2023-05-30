using MotoApp.Entities;
using MotoApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.DataProviders
{
    public class CarsProviderBasic : ICarsProvider
    {
        private readonly IRepository<Car> _carsRepository;

        public CarsProviderBasic(IRepository<Car> carsRepository) 
        {
            _carsRepository = carsRepository;
        }

        public string AnonymousClass()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetSpecificColumns()
        {
            throw new NotImplementedException();
        }

        public List<Car> FilterCars(decimal minPrice)
        {
            var cars = _carsRepository.GetAll();
            var list = new List<Car>();
            foreach (var car in cars)
            {
                if(car.ListPrice > minPrice)
                {
                    list.Add(car);
                }
            }
            return list;
        }

        public decimal GetMinPriceOfAllCars()
        {
            var cars = _carsRepository.GetAll();
            decimal ret = decimal.MaxValue;

            foreach (var car in cars)
            {
                if (car.ListPrice < ret)
                {
                    ret = car.ListPrice;
                }
            }
            return ret;
        }

        public List<string> GetUniqueCarColors()
        {
            var cars = _carsRepository.GetAll();
            var list = new List<string>();
            foreach (var car in cars)
            {
                if (!list.Contains(car.Color))
                {
                    list.Add(car.Color);
                }
            }
            return list;
        }
    }
}
