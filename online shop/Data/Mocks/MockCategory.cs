using online_shop.Data.Interfaces;
using online_shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Cars", desc = "Vehicles"},
                    new Category { categoryName = "Classic cars", desc = "Classic cars with engine"}
                };
            }
        }
    }
}
