using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Data;

namespace TelephoneBook.Operations
{
    public class SaveWork:IWork

    {
        public void Save() 
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz:");
            string number = Console.ReadLine();

            Person person = new Person();
            person.FirstName = name;
            person.LastName = surname;
            person.PhoneNumber = number;

            TelephoneBookDb.PhoneList.Add(person);
            Console.WriteLine(name + " " + surname + " added successfully.");

        }
        public bool CheckExist(string input)
        {
            bool exists = TelephoneBookDb.PhoneList.Any(x => x.FirstName == input || x.LastName == input);
            return exists;
        }
    }

    }

