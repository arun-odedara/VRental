using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VRental.Models;

namespace VRental.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List <Customer> Customers { get; set; }

    }
}