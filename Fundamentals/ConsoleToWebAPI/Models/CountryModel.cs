using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Models
{
    [ModelBinder(typeof(CustomBinderCountryDetails))]
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
    }
}
