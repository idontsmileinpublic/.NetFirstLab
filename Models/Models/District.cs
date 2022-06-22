using System;
namespace Lab1.Models
{
    public class District
    {
        public string NameDistrict { get; set; }

        public int IdDistrict { get; set; }

        public override string ToString()
        {
            return $"Район: {this.NameDistrict};";

        }

    }
}
