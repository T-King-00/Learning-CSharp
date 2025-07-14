using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearnCSharp.threads
{
    internal class taskEx3
    {

        public static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //  petstore api endpoint to make a GET request
                    string url = "https://petstore.swagger.io/v2/pet/findByStatus?status=available";

                    // fetching the response from the API
                    HttpResponseMessage response = await client.GetAsync(url);
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"Response: {responseBody}");

                    //converting the JSON response to a list of Pet objects

                    var pets = JsonSerializer.Deserialize<List<Pet>>(responseBody);

                    foreach (var _pet in pets)
                    {
                        if(_pet.id.ToString().Length>4)
                            Console.WriteLine($"Pet ID: {_pet.id}, Name: {_pet.name} " );

                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                    throw;
                }




            }
            

        }

        class Pet
        {
            public long id { get; set; }
            public string name { get; set; }
            public Category category { get; set; }
            public List<string> photoUrls { get; set; }
            public List<Tag> tags { get; set; }
            public string status { get; set; }


        }
        public class Category
        {
            public long id { get; set; }
            public string name { get; set; }
        }

        public class Tag
        {
            public long id { get; set; }
            public string name { get; set; }
        }

    }
}
