using System;
namespace Program
{
    public class PrintMethods
    {
        // 1

        public static void GetAllAddresses()
        {
            var result = Queries.GetAllAddresses();

            foreach (var a in result)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine($"\t");
        }

        // 2

        public static void ApartmentsToRent()
        {
            var result = Queries.ApartmentsToRent();

            foreach (var a in result)
            {
                Console.WriteLine($"{a.Address} {a.District} {a.Apartment}");
            }

            Console.WriteLine($"\t");
        }

        // 3

        public static void PrintAgencies()
        {
            var result = Queries.AllAgencies();

            foreach (var a in result)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine($"\t");
        }

        // 4

        public static void PrintAgenciesStartWith(char letter)
        {
            var result = Queries.AllAgenciesStartWith(letter);

            foreach (var a in result)
            {
                Console.WriteLine($"{a.Address} {a.Agency}");
            }

            Console.WriteLine($"\t");
        }

        // 5

        public static void PrintAgenciesRieltors()
        {
            var result = Queries.AgenciesRealtors();

            foreach (var a in result)
            {
                Console.WriteLine($"{a.Agency.Name} {a.Realtor.NameRealtor}");
            }

            Console.WriteLine($"\t");
        }

        // 6

        public static void PrintByArea()
        {
            var result = Queries.GroupByArea();

            foreach (var a in result)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine($"\t");
        }

        // 7

        public static void PrintByResidArea()
        {
            var result = Queries.GroupByDistrict2();

            foreach (var a in result)
            {
                Console.WriteLine($"Район: {a.District.NameDistrict}");
                foreach (var b in a.Address)
                {
                    Console.WriteLine($"\t{b}");
                }
            }

            Console.WriteLine($"\t");
        }

        // 8

        public static void PrintByPrice()
        {
            var result = Queries.GroupByPrice();

            foreach (var a in result)
            {
                Console.WriteLine($"Ціна: {a.Price}");
                foreach (var b in a.Address)
                {
                    Console.WriteLine($"\t{b}");
                }
            }

            Console.WriteLine($"\t");
        }

        // 9

        public static void PrintApartmentsRieltors()
        {
            var result = Queries.ApartmentsRieltors();

            foreach (var a in result)
            {
                Console.WriteLine($"{a.Addresses.Street} {a.Realtor.NameRealtor} {a.ApartmentRealtor.Price}");
            }

            Console.WriteLine($"\t");
        }

        // 10

        public static void PrintTopRieltors()
        {
            var result = Queries.PrintMaxApartmentsRealtor();

            foreach (var a in result)
                Console.WriteLine($"{a.NameRealtor}");

            Console.WriteLine();
        }

        // 11

        public static void PrintApartmentsGroupedByAgency()
        {
            var result = Queries.PrintApartmentsGroupedByAgency();
            foreach (var a in result)
            {
                Console.WriteLine($"Агенція: {a.Agency.Name}");
                foreach (var b in a.Addresses)
                    Console.WriteLine($"\t{b}");
            }

            Console.WriteLine();
        }

        // 12

        public static void PrintAverageAp()
        {

            var result = Queries.PrintApartmentsWithAreaLessThanAverage();

            foreach (var a in result)
            {
                Console.WriteLine($"{a.Address} | {a.Area}");
            }

            Console.WriteLine();
        }

        // 13

        public static void PrintApartmentsGroupedByFloor()
        {
            var result = Queries.PrintApartmentsGroupedByFloor();
            foreach (var a in result)
            {
                Console.WriteLine($"{a.Floor} поверх:");
                foreach (var b in a.Address)
                {
                    Console.WriteLine($"\t{b}");
                }
            }

            Console.WriteLine();
        }

        // 14

        public static void PrintAgenciesWithApartmentDistricts()
        {
            var result = Queries.PrintAgenciesWithApartmentDistricts();
            foreach (var a in result)
            {
                Console.WriteLine($"Агенція: {a.Agency.Name}");

                foreach (var b in a.District)
                    Console.WriteLine($"\t{b}");
            }

            Console.WriteLine();
        }

        // 15

        public static void PrintAgenciesThatHaveApartmentsAssignedInSpecificDistrict(string district)
        {
            var result = Queries.PrintAgenciesThatHaveApartmentsAssignedInSpecificDistrict(district);

            foreach (var a in result)
                Console.WriteLine(a.Agency);

            Console.WriteLine();
        }

        // 16

        public static void PrintAgencyRealtorsCount()
        {
            var result = Queries.PrintAgencyRealtorsCount();

            foreach (var row in result)
                Console.WriteLine($"{row.Agency.Name}: {row.CountRealtors}");

            Console.WriteLine();
        }

        // 17

        public static void PrintAllConcatAgencies()
        {
            var result = Queries.ConcatAgencies();

            foreach (var row in result)
                Console.WriteLine(row);

            Console.WriteLine();
        }


    }
}
