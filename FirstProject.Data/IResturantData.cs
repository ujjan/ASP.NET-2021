using System;
using System.Collections.Generic;
using FirstProject.Core;
using System.Linq;
namespace FirstProject.Data
{
    public interface IResturantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IResturantData
    {
        List<Restaurant> resturants;
        public InMemoryRestaurantData()
        {
            resturants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Spicy Kitchen", Location = "Orebro",
                Cuisine = CuisineType.Indian},
                new Restaurant {Id = 2, Name = "Dilan", Location = "Karlskoga",
                Cuisine = CuisineType.Italian},
                new Restaurant {Id = 3, Name = "Gargen", Location = "Stockholm",
                Cuisine = CuisineType.Maxican}
            };

        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in resturants
                   orderby r.Id
                   select r;
        }
    }
}
