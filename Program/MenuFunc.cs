using System;

namespace Program
{
    public class MenuFunc
    {
        public static void Menu()
        {
            Console.WriteLine
            (
                $"1 - Вивести усі адреси м. Київ,{Environment.NewLine}" +
                $"2 - Вивести усі квартири для оренди,{Environment.NewLine}" +
                $"3 - Вивести усі агенства,{Environment.NewLine}" +
                $"4 - Вивести усі агенства, які починаються на введену букву,{Environment.NewLine}" +
                $"5 - Вивести рієлторів з агенствами, в яких вони працюють,{Environment.NewLine}" +
                $"6 - Вивести наявні квартири в порядку спадання площі,{Environment.NewLine}" +
                $"7 - Вивести квартири за районами,{Environment.NewLine}" +
                $"8 - Вивести квартири за ціною,{Environment.NewLine}" +
                $"9 - Вивести квартирні пропозиції різних рієлторів із ціною аренди,{Environment.NewLine}" +
                $"10 - Вивести рієлторів, що пропонують найбільшу кількість квартир,{Environment.NewLine}" +
                $"11 - Вивести квартири, згруповані за агентством,{Environment.NewLine}" +
                $"12 - Вивести квартири, в яких площа менше сердньої,{Environment.NewLine}" +
                $"13 - Вивести квартири, згруповані за поверхом по зростанню,{Environment.NewLine}" +
                $"14 - Вивести агенції і райони в яких в них здаються квартири,{Environment.NewLine}" +
                $"15 - Вивести агенції, що здають квартири в заданому районі,{Environment.NewLine}" +
                $"16 - Вивести кількість ріелторів в кожному агенстві{Environment.NewLine}" +
                $"17 - Реалізація Concat{Environment.NewLine}" +
                $"m - Повернутися до меню{Environment.NewLine}"
            );
        }

        public static void Choice()
        {
            Console.WriteLine
            (
                $"0 - Завершити {Environment.NewLine}" +
                $"1 - Продовжити {Environment.NewLine}"
            );

            int k = int.Parse(Console.ReadLine());
            if (k == 1)
            {
                Switches();
            }
            if (k == 0)
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
                    PrintMethods.PrintApartmentsRealtors();
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
    }
}
