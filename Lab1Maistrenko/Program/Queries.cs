using System;
using System.Collections.Generic;
using System.Text;
using Lab1.Models;
using Lab1.MethodModels;
using System.Linq;

namespace Program
{
    public class Queries


    {
        // 1. Вивести усі адреси м. Київ

        public static IEnumerable<Address> GetAllAddresses()
        {
            return from address in Data.Addresses
                   select address;
        }

        // 2. Вивести усі адреси, за якими є квартири

        public static IEnumerable<ApartmentsToRent> ApartmentsToRent()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.IdDistrict
                   select new ApartmentsToRent() { Apartment = apartment, Address = address, District = district };
        }

        // 3. Вивід усіх агенств (тільки назва).

        public static IEnumerable<string> AllAgencies()
        {
            return from agency in Data.Agencies
                   select agency.Name;
        }

        // 4. Вивід агенств, що починаються на букву. 

        public static IEnumerable<AgencyAddress> AllAgenciesStartWith(char letter)
        {
            return from agency in Data.Agencies
                   join address in Data.Addresses on agency.IdAdress equals address.Id
                   where agency.Name.ToUpper().StartsWith(letter)
                   select new AgencyAddress { Address = address, Agency = agency};
        }

        // 5. Вивід рієлторів та агенств, у яких вони працюють. 

        public static IEnumerable<AgencyRealtor> AgenciesRealtors()
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.IdAgency
                   select new AgencyRealtor() { Agency = agency, Realtor = realtor };
        }

        // 6. Вивести квартири в порядку спадання площі. UPDATED

        public static IEnumerable<string> GroupByArea()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   orderby apartment.Area
                   select address.Street;
        }

        // 7. Вивести квартири, згруповані за районом. // UPDATED

        public static IEnumerable<CheckDistricts> GroupByDistrict2()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.IdDistrict
                   group address by district into newGroup
                   select new CheckDistricts { District = newGroup.Key, Address = newGroup.Select(address => address.Street).Distinct()};       
        }


        // 8. Вивести квартири, згруповані за ціною. // UPDATED 

        public static IEnumerable<ForPriceGroup> GroupByPrice()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   group address by apartment.Price into newGroup
                   //orderby newGroup.Key
                   select new ForPriceGroup { Price = newGroup.Key, Address = newGroup.Select(address => address.Street).Distinct() };
        }

        // 9. Вивести квартирні пропозиції різних рієлторів із ціною аренди // UPDATED 

        public static IEnumerable<ApartmentRealtors> ApartmentsRieltors()
        {
            return from apartment_realtor in Data.RealtorsApartments
                   join apartment in Data.Apartments on apartment_realtor.idApartment equals apartment.Id
                   join realtor in Data.Realtors on apartment_realtor.idRealtor equals realtor.Id
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   select new ApartmentRealtors() { ApartmentRealtor = apartment_realtor, Apartment = apartment, Realtor = realtor, Addresses = address };
        }

        // 10. Вивести ріелторів, що пропонують найбільшу кількість квартир

        public static IEnumerable<Realtor> PrintMaxApartmentsRealtor()
        {
            int max = Data.Realtors
                             .GroupJoin(
                                Data.RealtorsApartments,
                                realtor => realtor.Id,
                                realtor_apartment => realtor_apartment.idRealtor,
                                (realtor, realtor_apartments) => new { Realtor = realtor, RealtorApartments = realtor_apartments }
                             ).Select(x => x.RealtorApartments.Count()).Max();

            return from realtor in Data.Realtors
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.idRealtor into newGroup
                   where newGroup.Count() == max
                   select realtor;
        }

        // 11. Вивести квартири згруповані за ріелторським агентством


        public static IEnumerable<ApartmentAgency> PrintApartmentsGroupedByAgency()
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.IdAgency
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.idRealtor
                   join apartment in Data.Apartments on apartment_realtor.idApartment equals apartment.Id
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   group address by agency into newGroup
                   //orderby newGroup.Count() ascending
                   select new ApartmentAgency { Agency = newGroup.Key, Addresses = newGroup.Select(address => address.Street).Distinct()};
        }

        // 12. Вивести квартири, в яких площа менше сердньої

        public static IEnumerable<AddressAreaDistrict> PrintApartmentsWithAreaLessThanAverage()
        {
            double average = Data.Apartments.Select(apartment => apartment.Area).Average();

            return from address in Data.Addresses
                   join apartment in Data.Apartments on address.Id equals apartment.StreetId
                   where apartment.Area < average
                   select new AddressAreaDistrict() { Address = address.Street, Area = apartment.Area };

        }

        // 13. Вивести квартири погруповані за поверхом по зростанню

        public static IEnumerable<ApartmentFloor> PrintApartmentsGroupedByFloor()
        {
            return from apartments in Data.Apartments
                   join address in Data.Addresses on apartments.StreetId equals address.Id
                   group address by apartments.Floor into newGroup
                   orderby newGroup.Key ascending
                   select new ApartmentFloor { Floor = newGroup.Key, Address = newGroup.Select(address => address.Street).Distinct() };
        }

        // 14. Вивести агенції і райони в яких в них здаються квартири

        public static IEnumerable<DistrictsInAgencies> PrintAgenciesWithApartmentDistricts()
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.IdAgency
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.idRealtor
                   join apartment in Data.Apartments on apartment_realtor.idApartment equals apartment.Id
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.IdDistrict
                   group district by agency into g
                   select new DistrictsInAgencies { Agency = g.Key, District = g.Select(district => district.NameDistrict).Distinct() };
        }

        // 15. Вивести агенції, що здають квартири в Дарницькому районі

        public static IEnumerable<ForAgency> PrintAgenciesThatHaveApartmentsAssignedInSpecificDistrict(string _district)
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.IdAgency
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.idRealtor
                   join apartment in Data.Apartments on apartment_realtor.idApartment equals apartment.Id
                   join address in Data.Addresses on apartment.StreetId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.IdDistrict
                   group district by agency into g
                   where g.Select(a => a.NameDistrict).Contains(_district)
                   select new ForAgency { Agency = g.Key };
        }

        // 16.Вивести кількість ріелторів в кожному агенстві

        public static IEnumerable<RealtorsCount> PrintAgencyRealtorsCount()
        {

            return Data.Agencies
                        .GroupJoin(
                            Data.Realtors,
                            agency => agency.Id,
                            realtor => realtor.IdAgency,
                            (agency, realtors) => new RealtorsCount { Agency = agency, CountRealtors = realtors.Count() }
                        ).OrderByDescending(group => group.CountRealtors);
        }

        public static IEnumerable<Agency> ConcatAgencies()
        {
            var x = Data.Agencies.Concat(Data.TestAgency);
            return x;

        }
    }
}