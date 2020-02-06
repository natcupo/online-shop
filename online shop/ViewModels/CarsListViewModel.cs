using online_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_shop.ViewModels
{
    public class CarsListViewModel
    {
       public  IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }

    }
}
