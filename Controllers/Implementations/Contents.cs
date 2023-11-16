using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviESWeb.Interfaces;
using MoviESWeb.Models.Content;

namespace MoviESWeb.Implementations
{
    class Contents : IContentManagement
    {

        private List<Content> billboard = new List<Content>();

        public List<Content> Billboard { get => billboard; set => billboard = value; }

        public Contents()
        {
            Billboard = new List<Content>();
        }

        public void AddContent(Content content)
        {
            if (content != null)
            {
                Billboard.Add(content);
            }
            else
            {
                Console.WriteLine("No se pueden introducir términos nulos, inténtelo de nuevo");
            }
        }

        public void DeleteContent(Content content)
        {
            if (content != null & Billboard.Contains(content))
            {
                Billboard.Remove(content);
            }
            else
            {
                Console.WriteLine("La persona que has introducido no se encuentra en la lista.");
            }
        }

        public void ShowContent()
        {
            Console.WriteLine("List of Movies (id, name)");
            int i = 0;
            while (i < Billboard.Count)
            {
                Console.WriteLine(Billboard[i].Id + " _ " + Billboard[i].Title);
                i++;
            }
            Console.WriteLine();
        }

        public void RateContent(Content content) //Gets the average rating
        {
            int sum = content.Rating * content.NumOfRates;
            int rate = 0;
            Console.WriteLine("¿Que nota le das a " + content.Title + "?. Selecciona un numero del 1 al 5.");
            rate = Convert.ToInt32(Console.ReadLine());
            sum = sum + rate;
            content.NumOfRates++;
            content.Rating = sum / content.NumOfRates;
        }

    }
}
