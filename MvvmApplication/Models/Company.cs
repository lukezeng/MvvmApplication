using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvvmApplication.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string ImageUrl { get; set; }
        public int Gdp { get; set; }
    }
}