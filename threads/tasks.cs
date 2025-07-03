using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


namespace LearnCSharp.threads
{

    internal class Tasks
    {

        //sync task 
        public static void Main1(string[] args)
        {
            string filePath = "C:\\Users\\tony_\\source\\repos\\T-King-00\\Learning-CSharp\\threads\\example.txt";

            string filePath2 = "C:\\Users\\tony_\\source\\repos\\T-King-00\\Learning-CSharp\\threads\\example2.txt";

            Task<string> task1 = ReadFileAsync(filePath);
            Console.WriteLine("didnt await");
            string content2 = ReadFilesync(filePath2);



        }



        //async task 
        public static async Task Main()
        {

            string filePath = "C:\\Users\\tony_\\source\\repos\\T-King-00\\Learning-CSharp\\threads\\example.txt";
            string filePath2 = "C:\\Users\\tony_\\source\\repos\\T-King-00\\Learning-CSharp\\threads\\example2.txt";

            //two tasks to read two files asynchronously

            Console.WriteLine("Reading files asynchronously...");

            Task<string> task1 =  ReadFileAsync(filePath);
            // async task that returns a string
            Task<string> task2 =  ReadFileAsync(filePath2);

            // if we didn't use await here, the tasks will run in parallel but we won't wait for them to complete before moving on.
            // await Task.WhenAll(task1, task2);
            Task<string>[] tasks = new Task<string>[] { task1, task2 };

            Console.WriteLine($"Task 1 id: {task1.Id} ");
            Console.WriteLine($"Task 2 id: {task2.Id} ");

            while (tasks.Length > 0)
            { //task that finishes first will be printed first.
                Task<string> finishedTask = await Task.WhenAny(tasks);

                Console.WriteLine($"Task 1 status: {task1.Status}");
                Console.WriteLine($"Task 2 status: {task2.Status}");
                if (finishedTask == task1)
                {
                    Console.WriteLine($"--- {finishedTask.Id} ---  task1 printed successfully");
 
                }
                else
                    Console.WriteLine($"--- {finishedTask.Id} --- task2 printed successfully\"");

                // Remove finished task from array
                tasks = Array.FindAll(tasks, t => t != finishedTask);
            }


            Console.WriteLine("All tasks completed.");
        }

       
        
        private static string ReadFilesync(string filePath)
        {
            using (StreamReader readER = new StreamReader(filePath))
            {
                Console.WriteLine("reaading content");
                string content = readER.ReadToEnd();
                Console.WriteLine("finished reading content");
                return content;
            
            }
        }


        private static async Task<string> ReadFileAsync(string filePath)
        {
            using (StreamReader readER = new StreamReader(filePath))
            {
                Console.WriteLine("reaading content");
                string content = await readER.ReadToEndAsync();
                Console.WriteLine("finished reading content");

                return content;
            }

        }

        public static async Task Main2()
        {

            Console.WriteLine("this is main 2");

        }
    }
}
