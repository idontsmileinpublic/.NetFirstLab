using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Models
{
    public class Data
    {
        public static ICollection<Agency> Agencies => new List<Agency>
        {
            new Agency()
            {
                Name = "Рієлторська компанія Золоті ворота",
                AddressId = 12,
                Id = 1
            },

            new Agency()
            {
                Name = "PRODANO",
                AddressId = 3,
                Id = 2
            },

            new Agency()
            {
                Name = "Realty House",
                AddressId = 14,
                Id = 3
            },

            new Agency()
            {
                Name = "The Capital",
                AddressId = 17,
                Id = 4
            }
        };

        public static List<Agency> TestAgency => new List<Agency>
        {
            new Agency()
            {
                Name = "ПроАренда",
                AddressId = 10,
                Id = 1
            },

            new Agency()
            {
                Name = "Арендуймо! Київ",
                AddressId = 4,
                Id = 2
            },

            new Agency()
            {
                Name = "Аренда за класні кошти",
                AddressId = 9,
                Id = 3
            }
        };

        public static List<Apartment> Apartments => new List<Apartment>
        {
            new Apartment()
            {
                Id = 1,
                Price = 14000,
                Floor = 2,
                Area = 40,
                DistrictID = 7,
                AddressId = 2
            },

            new Apartment()
            {
                Id = 2,
                Price = 9000,
                Floor = 5,
                Area = 56,
                DistrictID = 6,
                AddressId = 4

            },

            new Apartment()
            {
                Id = 3,
                Price = 10300,
                Floor = 12,
                Area = 30,
                DistrictID = 2,
                AddressId = 5
            },

            new Apartment()
            {
                Id = 4,
                Price = 23000,
                Floor = 10,
                Area = 80,
                DistrictID = 8,
                AddressId = 3
            },

            new Apartment()
            {
                Id = 5,
                Price = 14000,
                Floor = 3,
                Area = 80,
                DistrictID = 7,
                AddressId = 1
            }
        };


        public static List<Realtor> Realtors => new List<Realtor>
        {
            new Realtor{
                Name = "Ольга",
                Patronymic = "Михайлівна",
                Surname = "Ватуніна",
                PhoneNumber = "0675489363",
                Id = 1,
                AgencyId = 1
            },

            new Realtor{
                Name = "Сергій",
                Patronymic = "Володимирович",
                Surname = "Гороховський",
                PhoneNumber = "0556478392",
                Id = 2,
                AgencyId = 1
            },

            new Realtor{
                Name = "Катерина",
                Patronymic = "Степанівна",
                Surname = "Вільна",
                PhoneNumber = "0957192444",
                Id = 3,
                AgencyId = 3,
            },

            new Realtor{
                Name = "Віталій",
                Patronymic = "Орестович",
                Surname = "Ткачук",
                PhoneNumber = "0668489848",
                Id = 4,
                AgencyId = 4,
            },

            new Realtor{
                Name = "Марина",
                Patronymic = "Олексіївна",
                Surname = "Вітаєнко",
                PhoneNumber = "0637829039",
                Id = 5,
                AgencyId = 2,
            }
        };

        public static List<ApartmentRealtor> RealtorsApartments => new List<ApartmentRealtor>
        {
            new ApartmentRealtor
            {
                ApartmentId = 2,
                RealtorId = 1,
                Price = 200
            },

            new ApartmentRealtor
            {
                ApartmentId = 2,
                RealtorId = 3,
                Price = 300
            },

            new ApartmentRealtor
            {
                ApartmentId = 3,
                RealtorId = 4,
                Price = 700
            },

            new ApartmentRealtor
            {
                ApartmentId = 2,
                RealtorId = 4,
                Price = 280
            },

            new ApartmentRealtor
            {
                ApartmentId = 1,
                RealtorId = 1,
                Price = 800
            },

            new ApartmentRealtor
            {
                ApartmentId = 3,
                RealtorId = 2,
                Price = 600
            }
        };

        public static List<Address> Addresses => new List<Address>
        {
            new Address()
            {
                Id = 1,
                DistrictId = 7,
                Street = "Берлінського, 18"
            },

            new Address()
            {
                Id = 2,
                DistrictId = 7,
                Street = "Берлінського, 14"
            },


            new Address()
            {
                Id = 3,
                DistrictId = 8,
                Street = "С. Крушельницької, 9"
            },

            new Address()
            {
                Id = 4,
                DistrictId = 8,
                Street = "Ахматової, 30"
            },

            new Address()
            {
                Id = 5,
                DistrictId = 2,
                Street = "Тютюнника, 51"
            },

            new Address()
            {
                Id = 6,
                DistrictId = 6,
                Street = "Мартиросяна, 11"
            },

            new Address()
            {
                Id = 7,
                DistrictId = 6,
                Street = "Волинська, 24"
            },

            new Address()
            {
                Id = 8,
                DistrictId = 6,
                Street = "Чоколівський бульвар, 18"
            },

            new Address()
            {
                Id = 9,
                DistrictId = 4,
                Street = "Білицька, 52/1"
            },

            new Address()
            {
                Id = 10,
                DistrictId = 4,
                Street = "Паркова, 20"
            },

            new Address()
            {
                Id = 11,
                DistrictId = 4,
                Street = "Яблочкова, 10"
            },

            new Address()
            {
                Id = 12,
                DistrictId = 4,
                Street = "Полкова, 6"
            },

            new Address()
            {
                Id = 13,
                DistrictId = 2,
                Street = "Полярна, 11"
            },

            new Address()
            {
                Id = 14,
                DistrictId = 2,
                Street = "Оболонський проспект, 14А"
            },

            new Address()
            {
                Id = 15,
                DistrictId = 2,
                Street = "Героїв Дніпра, 38"
            },

            new Address()
            {
                Id = 16,
                DistrictId = 9,
                Street = "Пожарського, 26В"
            },

            new Address()
            {
                Id = 17,
                DistrictId = 9,
                Street = "Каштанова, 8А"
            },


        };

        public static List<District> Districts => new List<District>
        {
            new District()
            {
                DistrictId = 1,
                Name = "Печерський",
            },

            new District()
            {
                DistrictId = 2,
                Name = "Оболонський",
            },

            new District()
            {
                DistrictId = 3,
                Name = "Голосіївський"
            },

            new District()
            {
                DistrictId = 4,
                Name = "Подольський"
            },

            new District()
            {
                DistrictId = 5,
                Name = "Святошинський"
            },

            new District()
            {
                DistrictId = 6,
                Name = "Солом'янський"
            },

            new District()
            {
                DistrictId = 7,
                Name = "Шевченківський"
            },

            new District()
            {
                DistrictId = 8,
                Name = "Дарницький"
            },

            new District()
            {
                DistrictId = 9,
                Name = "Деснянський"
            },

            new District()
            {
                DistrictId = 10,
                Name = "Дніпровський"
            }
        };
    }
}
