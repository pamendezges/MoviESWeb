using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviESWeb.Interfaces;
using MoviESWeb.Models.Person;

namespace MoviESWeb.Implementations
{
    class Persons : IPersonManagement
    {

        private List<Person> logins = new List<Person>();

        public List<Person> Logins { get => logins; set => logins = value; }

        public Persons()
        {
            Logins = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            if (person != null)
            {
                Logins.Add(person);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeletePerson(Person person)
        {
            if (person != null & Logins.Contains(person))
            {
                Logins.Remove(person);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowPersons()
        {
            Console.WriteLine("List of Persons (id, name)");
            int i = 0;
            while (i < Logins.Count)
            {
                Console.WriteLine(Logins[i].Id + " _ " + Logins[i].Name);
                i++;
            }
            Console.WriteLine();
        }
    }
}
