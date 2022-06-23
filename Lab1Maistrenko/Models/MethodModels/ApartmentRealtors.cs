using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class ApartmentRealtors
    {
        public Realtor Realtor { get; set; }

        public Apartment Apartment { get; set; }

        public ApartmentRealtor ApartmentRealtor { get; set; }

        public Agency Agency { get; set; }

        public Address Addresses { get; set; }

        public IGrouping<Agency, Apartment> Apartments { get; set; }
    }
}
