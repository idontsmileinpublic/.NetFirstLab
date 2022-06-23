using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class DistrictsInAgencies
    {
        public IEnumerable<string> ApartmentDistricts { get; set; }

        public Agency Agency { get; set; }

        public Address Address { get; set; }

        public IEnumerable<string> District { get; set; }
    
    }
}

