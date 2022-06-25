using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class DistrictsInAgencies
    { 
        public Agency Agency { get; set; }

        public IEnumerable<District> District { get; set; }
    
    }
}

