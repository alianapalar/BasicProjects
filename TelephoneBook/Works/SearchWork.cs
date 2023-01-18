using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Data;
using TelephoneBook.Operations;

namespace TelephoneBook.Works
{
    public class SearchWork:IWork
    {
        public void Search()
        {
        Search:
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz. /n *********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Person person;
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("İsim veya soyisim giriniz : ");
                String input2 = Console.ReadLine();
                person = TelephoneBookDb.PhoneList.FirstOrDefault(x => x.FirstName == input2 || x.LastName == input2);
                Show(person);
            }
            else if (input == "2")
            {
                Console.WriteLine("Telefon numarası giriniz : ");
                String input3 = Console.ReadLine();
                foreach (Person item in TelephoneBookDb.PhoneList)
                {
                    if (item.PhoneNumber.Contains(input3))
                    {
                        Show(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz");
                goto Search;
            }
        }
        public void Show(Person person)
        {
            Console.WriteLine("İsim: " + person.FirstName);
            Console.WriteLine("Soyisim: " + person.LastName);
            Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
            Console.WriteLine("-");
        }
    }
}
