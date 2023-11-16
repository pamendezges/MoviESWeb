using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using MoviESWeb.Implementations;
using MoviESWeb.Models.Content;


namespace MoviESWeb.Controllers.FileController
{
    class FileDocumentaryManagement
    {

        public void SaveToFile(Contents movies)
        {

            var jsonFolder = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"jsonFiles\DocumentariesList.json");

            if (File.Exists(jsonFolder))
            {
                File.Delete(jsonFolder);
            }

            using (StreamWriter sw = File.CreateText(jsonFolder))
            {
                foreach (Content content in movies.Billboard)
                {
                    if (content is Documentary documentary)
                    {
                        string jsonString = JsonSerializer.Serialize(documentary);
                        sw.WriteLine(jsonString);
                    }

                }

            }
            Console.WriteLine(" \r\n ");
        }

    }
}
