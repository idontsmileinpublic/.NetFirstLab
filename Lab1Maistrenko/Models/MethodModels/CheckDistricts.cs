using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class CheckDistricts
    {
        public District District { get; set; }
        public IEnumerable<string> Apartments { get; set; }
        public IEnumerable<string> Address { get; set; }
    }
}
