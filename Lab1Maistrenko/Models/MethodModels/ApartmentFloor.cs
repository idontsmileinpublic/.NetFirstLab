using System.Collections.Generic;
using System.Text;
using System.Linq;
using Lab1.Models;

namespace Lab1.MethodModels
{
    public class ApartmentFloor
    {
        public int Floor { get; set; }
        public IEnumerable<string> Address { get; set; }
    }
}
