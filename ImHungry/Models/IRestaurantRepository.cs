using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImHungry.Models
{
    public interface IRestaurantRepository
    {
        IQueryable<Restaurant> Restaurants { get; }
    }
}