using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviESWeb.Models.Person;

namespace MoviESWeb.Interfaces
{
    public interface IPersonManagement
    {
        public void AddPerson(Person person) { }

        public void DeletePerson(Person person) { }

        public void ShowPersons() { }

    }
}
