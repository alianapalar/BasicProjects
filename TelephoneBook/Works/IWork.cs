using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook.Operations
{
    public interface IWork
    {
        public void Save() { }
        public void Delete() { }
        public void Update() { }
        public void List() { }
        public void Search() { }
    }
}
