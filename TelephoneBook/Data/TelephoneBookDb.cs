using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook.Data
{
    public class TelephoneBookDb
    {
        private static List<Person> _phoneList;
        

        static TelephoneBookDb()
        {
            _phoneList = new List<Person>()
            {
                new Person{FirstName="Mahmut", LastName="Tekdemir", PhoneNumber="(242) 352-0562" },
                new Person{FirstName="Kerem", LastName="Akturkoglu", PhoneNumber="(986) 695-0671" },
                new Person{FirstName="Kevin", LastName="Nkodou", PhoneNumber="(415) 923-6596" },
                new Person{FirstName="Mauro", LastName="Icardi", PhoneNumber="(450) 379-0231" },
                new Person{FirstName="Michy", LastName="Batshuayi", PhoneNumber="(643) 928-0063" }
            };

        }

        public static List<Person> PhoneList
        {
            get { return _phoneList; }
        }

       
    }
}
