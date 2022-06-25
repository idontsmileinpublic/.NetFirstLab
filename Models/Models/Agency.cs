using System;

namespace Lab1.Models
{
    public class Agency
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public int AddressId { get; set; }

        public override string ToString()
        {
            return $"Назва: {Name};";
        }
    }
}
