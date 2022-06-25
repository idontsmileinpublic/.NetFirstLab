using System;
namespace Lab1.Models
{
    public class Apartment
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int DistrictID { get; set; }

        public int Floor { get; set; }

        public int AddressId { get; set; } // поменять на адресс 

        public double Area { get; set; }

        public override string ToString()
        {
            return string.Format($"Вартість: {this.Price}; Поверх:{this.Floor}; Площа: {this.Area};");
        }
    }
}
