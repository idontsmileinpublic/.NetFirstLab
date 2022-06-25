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

        public static IEnumerable<Address> GetAllAddresses()
        {
            return from address in Data.Addresses
                   select address;
        }

        public static IEnumerable<ApartmentsToRent> ApartmentsToRent()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.DistrictId
                   select new ApartmentsToRent() { Apartment = apartment, Address = address, District = district };
        }

        public static IEnumerable<string> AllAgencies()
        {
            return from agency in Data.Agencies
                   select agency.Name;
        }

        public static IEnumerable<AgencyAddress> AllAgenciesStartWith(char letter)
        {
            return from agency in Data.Agencies
                   join address in Data.Addresses on agency.AddressId equals address.Id
                   where agency.Name.ToUpper().StartsWith(char.ToUpper(letter))
                   select new AgencyAddress { Address = address, Agency = agency};
        }

        public static IEnumerable<AgencyRealtor> AgenciesRealtors()
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.AgencyId
                   select new AgencyRealtor() { Agency = agency, Realtor = realtor };
        }

        public static IEnumerable<string> GroupByArea()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   orderby apartment.Area
                   select address.Street;
        }

        public static IEnumerable<CheckDistricts> GroupByDistrict()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.DistrictId
                   group address by district into newGroup
                   select new CheckDistricts { District = newGroup.Key, Address = newGroup.Select(address => address)};       
        }

        public static IEnumerable<ForPriceGroup> GroupByPrice()
        {
            return from apartment in Data.Apartments
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   group address by apartment.Price into newGroup
                   select new ForPriceGroup { Price = newGroup.Key, Address = newGroup.Select(address => address)};
        }

        public static IEnumerable<ApartmentRealtors> ApartmentsRealtors()
        {

            return from apartment_realtor in Data.RealtorsApartments
                   join apartment in Data.Apartments on apartment_realtor.ApartmentId equals apartment.Id
                   join realtor in Data.Realtors on apartment_realtor.RealtorId equals realtor.Id
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   select new ApartmentRealtors() { ApartmentRealtor = apartment_realtor, Realtor = realtor, Addresses = address, OverallPrice = apartment.Price + apartment_realtor.Price };
        }

        public static IEnumerable<Realtor> PrintMaxApartmentsRealtor()
        {
            int max = Data.Realtors
                             .GroupJoin(
                                Data.RealtorsApartments,
                                realtor => realtor.Id,
                                realtor_apartment => realtor_apartment.RealtorId,
                                (realtor, realtor_apartments) => new { Realtor = realtor, RealtorApartments = realtor_apartments }
                             ).Select(x => x.RealtorApartments.Count()).Max();

            return from realtor in Data.Realtors
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.RealtorId into newGroup
                   where newGroup.Count() == max
                   select realtor;
        }

        public static IEnumerable<ApartmentAgency> PrintApartmentsGroupedByAgency()
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.AgencyId
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.RealtorId
                   join apartment in Data.Apartments on apartment_realtor.ApartmentId equals apartment.Id
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   group address by agency into newGroup
                   select new ApartmentAgency { Agency = newGroup.Key, Addresses = newGroup.Select(address => address)};
        }

        public static IEnumerable<AddressAreaDistrict> PrintApartmentsWithAreaLessThanAverage()
        {
            return from address in Data.Addresses
                   join apartment in Data.Apartments on address.Id equals apartment.AddressId
                   where apartment.Area < Data.Apartments.Select(apartment => apartment.Area).Average()
                   select new AddressAreaDistrict { Addresses = address, Area = apartment.Area };
        }

        public static IEnumerable<ApartmentFloor> PrintApartmentsGroupedByFloor()
        {
            return from apartments in Data.Apartments
                   join address in Data.Addresses on apartments.AddressId equals address.Id
                   group address by apartments.Floor into newGroup
                   orderby newGroup.Key ascending
                   select new ApartmentFloor { Floor = newGroup.Key, Address = newGroup.Select(address => address)};
        }

        public static IEnumerable<DistrictsInAgencies> PrintAgenciesWithApartmentDistricts()
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.AgencyId
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.RealtorId
                   join apartment in Data.Apartments on apartment_realtor.ApartmentId equals apartment.Id
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.DistrictId
                   group district by agency into g
                   select new DistrictsInAgencies { Agency = g.Key, District = g.Select(district => district)};
        }

        public static IEnumerable<ForAgency> PrintAgenciesThatHaveApartmentsAssignedInSpecificDistrict(string districtName)
        {
            return from agency in Data.Agencies
                   join realtor in Data.Realtors on agency.Id equals realtor.AgencyId
                   join apartment_realtor in Data.RealtorsApartments on realtor.Id equals apartment_realtor.RealtorId
                   join apartment in Data.Apartments on apartment_realtor.ApartmentId equals apartment.Id
                   join address in Data.Addresses on apartment.AddressId equals address.Id
                   join district in Data.Districts on address.DistrictId equals district.DistrictId
                   group district by agency into g
                   where g.Select(a => a.Name).Contains(districtName)
                   select new ForAgency { Agency = g.Key };
        }

        public static IEnumerable<RealtorsCount> PrintAgencyRealtorsCount()
        {

            return Data.Agencies
                        .GroupJoin(
                            Data.Realtors,
                            agency => agency.Id,
                            realtor => realtor.AgencyId,
                            (agency, realtors) => new RealtorsCount { Agency = agency, CountRealtors = realtors.Count() }
                        ).OrderByDescending(group => group.CountRealtors);
        }

        public static IEnumerable<Agency> ConcatAgencies()
        {
            return Data.Agencies.Concat(Data.TestAgency);
        }
    }
}