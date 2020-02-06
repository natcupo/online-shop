using online_shop.Data.Interfaces;
using online_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_shop.Data.Mocks
{
    public class MockCars : IAllCars {

        private readonly ICarsCategory _categorycars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla Huesla Model 5",
                        Shortdesc = "Fast vehicle",
                        LongDesc = "Fast and Quiet Vehicle",
                        img ="/img/gen340_2970710.jpeg",
                        price = 45000,
                        IsFavourite = true,
                        available = true,
                        Category = _categorycars.AllCategories.First()
                },
                    new Car
                    {
                        name = "Ford Fiesta",
                        Shortdesc = "Slow and quiet",
                        LongDesc = "Family friendly vehicle",
                        img ="/img/ford.jpeg",
                        price = 45000,
                        IsFavourite = true,
                        available = true,
                        Category = _categorycars.AllCategories.First()
                    }
        };
        }
    }
        public IEnumerable<Car> GetFavCars { get; }
        IEnumerable<Car> IAllCars.GetFavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
    }

