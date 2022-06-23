using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.Models
{
    public class Data
    {
        public static List<Agency> Agencies => new List<Agency>
        {
            new Agency()
            {
                Name = "Рієлторська компанія Золоті ворота",
                IdAdress = 12,
                Id = 1
            },

            new Agency()
            {
                Name = "PRODANO",
                IdAdress = 3,
                Id = 2
            },

            new Agency()
            {
                Name = "Realty House",
                IdAdress = 14,
                Id = 3
            },

            new Agency()
            {
                Name = "The Capital",
                IdAdress = 17,
                Id = 4
            }
        };

        public static List<Agency> TestAgency => new List<Agency>
        {
            new Agency()
            {
                Name = "ПроАренда",
                IdAdress = 10,
                Id = 1
            },

            new Agency()
            {
                Name = "Арендуймо! Київ",
                IdAdress = 4,
                Id = 2
            },

            new Agency()
            {
                Name = "Аренда за класні кошти",
                IdAdress = 9,
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
                StreetId = 2
            },

            new Apartment()
            {
                Id = 2,
                Price = 9000,
                Floor = 5,
                Area = 56,
                DistrictID = 6,
                StreetId = 4

            },

            new Apartment()
            {
                Id = 3,
                Price = 10300,
                Floor = 12,
                Area = 30,
                DistrictID = 2,
                StreetId = 5
            },

            new Apartment()
            {
                Id = 4,
                Price = 23000,
                Floor = 10,
                Area = 80,
                DistrictID = 8,
                StreetId = 3
            },

            new Apartment()
            {
                Id = 5,
                Price = 14000,
                Floor = 3,
                Area = 80,
                DistrictID = 7,
                StreetId = 1
            }
        };


        public static List<Realtor> Realtors => new List<Realtor>
        {
            new Realtor{
                NameRealtor = "Ватуніна Ольга Михайлівна",
                PhoneNumber = "0675489363",
                Id = 1,
                IdAgency = 1
            },

            new Realtor{
                NameRealtor = "Гороховський Сергій Володимирович",
                PhoneNumber = "0556478392",
                Id = 2,
                IdAgency = 1
            },

            new Realtor{
                NameRealtor = "Вільна Катерина Степанівна",
                PhoneNumber = "0957192444",
                Id = 3,
                IdAgency = 3,
            },

            new Realtor{
                NameRealtor = "Ткачук Віталій Олександрович",
                PhoneNumber = "0668489848",
                Id = 4,
                IdAgency = 4,
            },

            new Realtor{
                NameRealtor = "Вітаєнко Марина Олексіївна",
                PhoneNumber = "0637829039",
                Id = 5,
                IdAgency = 2,
            }
        };

        public static List<ApartmentRealtor> RealtorsApartments => new List<ApartmentRealtor>
        {
            new ApartmentRealtor
            {
                idApartment = 2,
                idRealtor = 1,
                Price = 10000
            },

            new ApartmentRealtor
            {
                idApartment = 2,
                idRealtor = 3,
                Price = 10500
            },

            new ApartmentRealtor
            {
                idApartment = 3,
                idRealtor = 4,
                Price = 11000
            },

            new ApartmentRealtor
            {
                idApartment = 2,
                idRealtor = 4,
                Price = 12000
            },

            new ApartmentRealtor
            {
                idApartment = 1,
                idRealtor = 1,
                Price = 15500
            },

            new ApartmentRealtor
            {
                idApartment = 3,
                idRealtor = 2,
                Price = 12000
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
                IdDistrict = 1,
                NameDistrict = "Печерський",
            },

            new District()
            {
                IdDistrict = 2,
                NameDistrict = "Оболонський",
            },

            new District()
            {
                IdDistrict = 3,
                NameDistrict = "Голосіївський"
            },

            new District()
            {
                IdDistrict = 4,
                NameDistrict = "Подольський"
            },

            new District()
            {
                IdDistrict = 5,
                NameDistrict = "Святошинський"
            },

            new District()
            {
                IdDistrict = 6,
                NameDistrict = "Солом'янський"
            },

            new District()
            {
                IdDistrict = 7,
                NameDistrict = "Шевченківський"
            },

            new District()
            {
                IdDistrict = 8,
                NameDistrict = "Дарницький"
            },

            new District()
            {
                IdDistrict = 9,
                NameDistrict = "Деснянський"
            },

            new District()
            {
                IdDistrict = 10,
                NameDistrict = "Дніпровський"
            }
        };
    }
}
