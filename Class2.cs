using System;
using System.Collections.Generic;
using System.Linq;

namespace NameManager
{
    public static class PersonManager
    {
        private static List<Person> people = new List<Person>();
       
        public static void AddPerson()
        {
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите отчество:");
            string middleName = Console.ReadLine();

            people.Add(new Person(surname, firstName, middleName));
            Console.WriteLine("Человек успешно добавлен!");
        }

        public static void PrintNamesSeparately()
        {
            Console.WriteLine("\nВыберите, что вывести: 1 - Фамилия, 2 - Имя, 3 - Отчество");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var person in people)
                    {
                        Console.WriteLine(person.Surname);
                    }
                    break;
                case "2":
                    foreach (var person in people)
                    {
                        Console.WriteLine(person.FirstName);
                    }
                    break;
                case "3":
                    foreach (var person in people)
                    {
                        Console.WriteLine(person.MiddleName);
                    }
                    break;
                default:
                    Console.WriteLine("Неверный ввод.");
                    break;
            }
        }
        public static void SortBySurname()
        {
            Console.WriteLine("\nСортировать фамилии: 1 - По возрастанию, 2 - По убыванию");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                people = people.OrderBy(p => p.Surname).ToList();
            }
            else if (choice == "2")
            {
                people = people.OrderByDescending(p => p.Surname).ToList();
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }

            Console.WriteLine("Список отсортирован:");
            ShowFullList();
        }
        public static void ModifyName()
        {
            Console.WriteLine("\nВведите индекс человека для изменения (начиная с 0):");
            ShowFullList();
            int index;
            if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < people.Count)
            {
                Console.WriteLine("Выберите, что изменить: 1 - Фамилию, 2 - Имя, 3 - Отчество");
                string choice = Console.ReadLine();
                Console.WriteLine("Введите новое значение:");
                string newValue = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        people[index].Surname = newValue;
                        break;
                    case "2":
                        people[index].FirstName = newValue;
                        break;
                    case "3":
                        people[index].MiddleName = newValue;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }

                Console.WriteLine("Изменение внесено:");
                ShowFullList();
            }
            else
            {
                Console.WriteLine("Неверный индекс.");
            }
        }
        public static void FindPersonBySurname()
        {
            Console.WriteLine("\nВведите фамилию для поиска:");
            string surname = Console.ReadLine();
            var foundPeople = people.Where(p => p.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase)).ToList();

            if (foundPeople.Any())
            {
                Console.WriteLine("Найденные люди:");
                foreach (var person in foundPeople)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Человек с такой фамилией не найден.");
            }
        }
        public static void ShowFullList()
        {
            Console.WriteLine("\nПолный список людей:");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i}. {people[i]}");
            }
        }
    }
}

