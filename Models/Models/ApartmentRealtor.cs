using System;
namespace Lab1.Models
{
    public class ApartmentRealtor
    {
        public int RealtorId { get; set; }

        public int ApartmentId { get; set; }

        public decimal Price { get; set; } 

        public override string ToString()
        {
            return $"Вартість: {Price};";

        }
    }
}
