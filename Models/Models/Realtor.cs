using System;
namespace Lab1.Models
{
    public class Realtor
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string PhoneNumber { get; set; }

        public int Id { get; set; }

        public int AgencyId { get; set; }

        public override string ToString()
        {
            return $"Ім'я: {Name} {Patronymic} {Surname}; Номер телефону: {PhoneNumber};)";
        }
    }
}
