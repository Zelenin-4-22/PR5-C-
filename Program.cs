using System;

namespace NameManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добавьте свои данные в список.");

            PersonManager.AddPerson();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1 - Вывести фамилию, имя или отчество отдельно");
                Console.WriteLine("2 - Отсортировать фамилии по возрастанию или убыванию");
                Console.WriteLine("3 - Изменить имя, фамилию или отчество");
                Console.WriteLine("4 - Найти человека по фамилии");
                Console.WriteLine("5 - Показать полный список");
                Console.WriteLine("6 - Добавить нового человека");
                Console.WriteLine("0 - Выйти");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PersonManager.PrintNamesSeparately();
                        break;
                    case "2":
                        PersonManager.SortBySurname();
                        break;
                    case "3":
                        PersonManager.ModifyName();
                        break;
                    case "4":
                        PersonManager.FindPersonBySurname();
                        break;
                    case "5":
                        PersonManager.ShowFullList();
                        break;
                    case "6":
                        PersonManager.AddPerson();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}

