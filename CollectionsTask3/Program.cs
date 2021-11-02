using System;
using System.Collections.Generic;

namespace CollectionsTask3
{
    //Task 3:
    //Create the PhoneBook class based on Dictionary collection.
    //Provide the possibility of adding, editing, removing and showing records.


    class Program
    {
        static void ShowRecords(Dictionary<string,PhoneBook> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.WriteLine("--------------------------------");
        }

        static void AddRecord(Dictionary<string, PhoneBook> dictionary, string number, string name, string email)
        {
            //dictionary.Add(number, new PhoneBook() { Name = name, Email = email });
            dictionary[number] = new PhoneBook() { Name = name, Email = email};
        }
        static void DeleteRecord(Dictionary<string, PhoneBook> dictionary, string number)
        {
            dictionary.Remove(number);
        }
        static void InfoRecord(Dictionary<string, PhoneBook> dictionary, string number)
        {
            if (dictionary.ContainsKey(number))
               Console.WriteLine($"Iformation about {number} - {dictionary[number]}");
            else
                Console.WriteLine($"{number} - Is not  Exists!");
            Console.WriteLine("--------------------------------");
        }

        static void EditRecord(Dictionary<string, PhoneBook> dictionary, string number, string name, string email)
        {
            if (dictionary.ContainsKey(number))
            {
                Console.WriteLine($"{number} - Successfully changed");
                Console.WriteLine($"{dictionary[number].Name} -> {name}");
                Console.WriteLine($"{dictionary[number].Email} -> {email}");
                dictionary[number].Name = name;
                dictionary[number].Email = email;
            }
            else
                Console.WriteLine($"{number} - Is not  Exists!");
            Console.WriteLine("--------------------------------");
        }

        class PhoneBook
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public override string ToString()
            {
                return $"{Name} {Email}";
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, PhoneBook> phoneBook = new Dictionary<string, PhoneBook>() 
            { 
                ["099 456 21 32"] = new PhoneBook() { Name = "Andrew", Email = "sdsd@gmail.com" },
                ["098 987 12 67"] = new PhoneBook() { Name = "Bob", Email = "vbnvbn@mail.ru" },
                ["097 158 89 74"] = new PhoneBook() { Name = "Serg", Email = "rt56y@yandex.ru" },
                ["073 555 44 56"] = new PhoneBook() { Name = "Mask", Email = "mnn7@gmail.com" },
                ["095 379 94 40"] = new PhoneBook() { Name = "Anton", Email = "opoi@mail.ru" },
                ["050 947 78 29"] = new PhoneBook() { Name = "Nataly", Email = "sagg3jhj@gmail.com" },
                ["067 204 57 41"] = new PhoneBook() { Name = "Olga", Email = "zzxc@gmail.com" }

            };

            
            ShowRecords(phoneBook);
            AddRecord(phoneBook, "099 888 77 66", "New Name", "234@gmail.com");
            ShowRecords(phoneBook);
            DeleteRecord(phoneBook, "067 204 57 41");
            ShowRecords(phoneBook);
            InfoRecord(phoneBook, "073 555 44 56");

            EditRecord(phoneBook, "050 947 78 27", "Tany", "change@mail.com");
            EditRecord(phoneBook, "050 947 78 29", "Tany", "change@mail.com");
            ShowRecords(phoneBook);
        }
    }
}
