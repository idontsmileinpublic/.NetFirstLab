using System;
using System.Collections.Generic;
using System.Text;
using Lab1.Models;
using System.Linq;


namespace Program
{
    public class Program
    {
        public static void Menu()
        {
            Console.WriteLine
            (
                "1 - Вивести усі адреси м. Київ, \n" +
                "2 - Вивести усі квартири для оренди, \n" +
                "3 - Вивести усі агенства, \n" +
                "4 - Вивести усі агенства, які починаються на введену букву, \n" +
                "5 - Вивести рієлторів з агенствами, в яких вони працюють, \n" +
                "6 - Вивести наявні квартири в порядку спадання площі, \n" +
                "7 - Вивести квартири за районами, \n" +
                "8 - Вивести квартири за ціною,\n" +
                "9 - Вивести квартирні пропозиції різних рієлторів із ціною аренди, \n" +
                "10 - Вивести рієлторів, що пропонують найбільшу кількість квартир, \n" +
                "11 - Вивести квартири, згруповані за агентством, \n" +
                "12 - Вивести квартири, в яких площа менше сердньої, \n" +
                "13 - Вивести квартири, згруповані за поверхом по зростанню, \n" +
                "14 - Вивести агенції і райони в яких в них здаються квартири, \n" +
                "15 - Вивести агенції, що здають квартири в заданому районі, \n" +
                "16 - Вивести кількість ріелторів в кожному агенстві \n" +
                "17 - Реалізація Concat \n" +
                "m - Повернутися до меню \n"
            );
        }

        public static void Choice()
        {
            Console.WriteLine
            (
                "0 - Завершити \n" +
                "1 - Продовжити \n"
            );

            int k = int.Parse(Console.ReadLine());
            if (k == 1)
            {
                Switches();
            }
            if (k== 0)
            {
                Console.WriteLine("Дякую.");
            }
            else
            {
                Console.WriteLine("Невідоме значення. Роботу завершено.");
            }

        }

        public static void Switches()
        {
            Menu();
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    PrintMethods.GetAllAddresses();
                    Choice();
                    break;
                case 2:
                    PrintMethods.ApartmentsToRent();
                    Choice();
                    break;
                case 3:
                    PrintMethods.PrintAgencies();
                    Choice();
                    break;
                case 4:
                    char letter = char.Parse(Console.ReadLine());
                    PrintMethods.PrintAgenciesStartWith(letter);
                    Choice();
                    break;
                case 5:
                    PrintMethods.PrintAgenciesRieltors();
                    Choice();
                    break;
                case 6:
                    PrintMethods.PrintByArea();
                    Choice();
                    break;
                case 7:
                    PrintMethods.PrintByResidArea();
                    Choice();
                    break;
                case 8:
                    PrintMethods.PrintByPrice();
                    Choice();
                    break;
                case 9:
                    PrintMethods.PrintApartmentsRieltors();
                    Choice();
                    break;
                case 10:
                    PrintMethods.PrintTopRieltors();
                    Choice();
                    break;
                case 11:
                    PrintMethods.PrintApartmentsGroupedByAgency();
                    Choice();
                    break;
                case 12:
                    PrintMethods.PrintAverageAp();
                    Choice();
                    break;
                case 13:
                    PrintMethods.PrintApartmentsGroupedByFloor();
                    Choice();
                    break;
                case 14:
                    PrintMethods.PrintAgenciesWithApartmentDistricts();
                    Choice();
                    break;
                case 15:
                    string district = Console.ReadLine();
                    PrintMethods.PrintAgenciesThatHaveApartmentsAssignedInSpecificDistrict(district);
                    Choice();
                    break;
                case 16:
                    PrintMethods.PrintAgencyRealtorsCount();
                    Choice();
                    break;
                case 17:
                    PrintMethods.PrintAllConcatAgencies();
                    Choice();
                    break;
                default:
                    Console.WriteLine("Дякую!");
                    break;
            }
        }
        public static void Main()
        {
            Console.WriteLine($"\t");
            Menu();
            Console.WriteLine($"\t");
            Switches();
        }
    }
}
