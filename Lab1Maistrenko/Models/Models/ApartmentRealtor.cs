using System;
namespace Lab1.Models
{
    public class ApartmentRealtor
    {
        public int idRealtor { get; set; }

        public int idApartment { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"Вартість: {this.Price};";

        }
    }
}
