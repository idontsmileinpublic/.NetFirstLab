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

        public ApartmentRealtor ApartmentRealtor { get; set; }

        public Agency Agency { get; set; }

        public Address Addresses { get; set; }

        public IEnumerable<Apartment> Apartments { get; set; }

        public decimal OverallPrice { get; set; }
    }
}
