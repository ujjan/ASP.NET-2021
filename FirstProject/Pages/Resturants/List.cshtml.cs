using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Core;
using FirstProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace FirstProject.Pages.Resturants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IResturantData resturantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }


        public ListModel(IConfiguration config, IResturantData resturantData)
        {
            this.config = config;
            this.resturantData = resturantData;
        }


        public void OnGet()
        {
            Message = config["Message"];
            Restaurants = (IEnumerable<Restaurant>)resturantData.GetAll();

        }
    }
}