using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MoviESWeb.Implementations;
using MoviESWeb.Models.Person;


namespace MoviESWeb.Controllers.FileController
{
    class FileUserManagement
    {       
        public void SaveToFile(Persons people)
        {

            var jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"jsonFiles\UserList.json");

            if (File.Exists(jsonFolder))
            {
                File.Delete(jsonFolder);
            }

            using (StreamWriter sw = File.CreateText(jsonFolder))
            {
                foreach (Person person in people.Logins)
                {
                    if(person is User user)
                    {
                        string jsonString = JsonSerializer.Serialize(user);
                        sw.WriteLine(jsonString);
                    }

                }

            }
            Console.WriteLine(" \r\n ");
        }



    }
}
