using System;
namespace Lab1.Models
{
    public class Address
    {
        public string Street { get; set; }

        public int Id { get; set; }

        public int DistrictId { get; set; }

        public override string ToString()
        {
            return string.Format($"Вулиця: {Street}");
        }
    }
}
