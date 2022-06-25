using System;
namespace Lab1.Models
{
    public class District
    {
        public string Name { get; set; }

        public int DistrictId { get; set; }

        public override string ToString()
        {
            return $"Район: {Name};";
        }

    }
}
