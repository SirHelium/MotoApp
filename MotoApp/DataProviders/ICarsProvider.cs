using MotoApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.DataProviders
{
    public interface ICarsProvider
    {
        List<Car> FilterCars(decimal minPrice);

        List<string> GetUniqueCarColors();

        decimal GetMinPriceOfAllCars();

        List<Car> GetSpecificColumns();

        string AnonymousClass();
    }
}
