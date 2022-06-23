using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class ApartmentsToRent
    {
        public Apartment Apartment { get; set; }
        public Address Address { get; set; }
        public District District { get; set; }
    }
}
