using System;
namespace Lab1.Models
{
    public class Realtor
    {
        public string NameRealtor { get; set; }

        public string PhoneNumber { get; set; }

        public int Id { get; set; }

        public int IdAgency { get; set; }

        public override string ToString()
        {
            return string.Format($"Ім'я: {this.NameRealtor}; Номер телефону: {this.PhoneNumber};)");
        }
    }
}
