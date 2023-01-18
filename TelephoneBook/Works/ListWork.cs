using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneBook.Data;
using TelephoneBook.Operations;

namespace TelephoneBook.Works
{
    public class ListWork:IWork
    {
        public void List()
        {
            Console.WriteLine("Telefon Rehberi \n **********************************************");

            foreach (Person person in TelephoneBookDb.PhoneList)
            {
                Console.WriteLine("İsim: " + person.FirstName);
                Console.WriteLine("Soyisim: " + person.LastName);
                Console.WriteLine("Telefon Numarası: " + person.PhoneNumber);
                Console.WriteLine("-");
            }
        }
    }
}
