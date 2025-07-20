using LearnCSharp.threads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.TPL_WEEK3
{
    internal class TPLEx2
    {

        public static async Task Main(string[] args)
        {
            var urlS = new List<string>
            {
                
                "https://example.com", 
                "https://example.net",
                "https://facebook.com"

            };

            var tasks = new List<Task<string>>();

            foreach (var url in urlS)
            {

                tasks.Add(FetchDataAsync(url));
            }

            // Compare the two methods of waiting for tasks to finish

            // Uncomment only one of the following lines of code to see the difference in behavior:


            //whenAllTasksFinished(tasks).GetAwaiter().GetResult();
            whenAnyTasksFinished(tasks).GetAwaiter().GetResult();


        }

        private static async Task<string> FetchDataAsync(string url)
        {

            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        private static async Task whenAllTasksFinished(List<Task<string>> tasks)
        {
            var results = await Task.WhenAll(tasks);

            foreach (var VARIABLE in results)
            {
                // Print the results    
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine(VARIABLE);

                Console.WriteLine("--------------------------------------------------");

            }



        }

        private static async Task whenAnyTasksFinished(List<Task<string>> tasks)
        {
            var results = await Task.WhenAny(tasks);

           
            // Print the results    
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine(results.Result);

            Console.WriteLine("--------------------------------------------------");

            



        }

    }
}
