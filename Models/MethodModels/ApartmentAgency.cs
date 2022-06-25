using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class ApartmentAgency
    {
        public Realtor Realtor { get; set; }

        public Apartment Apartment { get; set; }

        public ApartmentRealtor ApartmentRealtor { get; set; }

        public Agency Agency { get; set; }

        public IEnumerable<Address> Addresses { get; set; }

        public IEnumerable<Apartment> Apartments { get; set; }

    }
}
