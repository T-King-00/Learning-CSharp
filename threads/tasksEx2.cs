using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearnCSharp.threads
{
    internal class tasksEx2
    {

        public class Account
        {
            public string Name { get; set; }
            public decimal Balance { get; set; }
        }

        public static async Task Main0(string[] args)
        {
            // This example demonstrates how to create a directory, write a list of accounts to a JSON file, and read it back.

            string directoryPath = @"C:\Users\tony_\source\repos\T-King-00\Learning-CSharp";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                Console.WriteLine("Directory created successfully.");
            }
            string fileName = "accounts.json";
            string filePath = Path.Combine(directoryPath, fileName);



            //creating list of random accounts
            List<Account> accounts = new List<Account>
            {
                new Account { Name = "Alice", Balance = 1000.50m },
                new Account { Name = "Bob", Balance = 2000.75m },
                new Account { Name = "Charlie", Balance = 1500.00m }
                ,new Account { Name = "David", Balance = 3000.25m }
                ,new Account { Name = "Eve", Balance = 2500.00m }
                ,new Account { Name = "Frank", Balance = 1800.00m }
                ,new Account { Name = "Grace", Balance = 2200.00m }
                ,new Account { Name = "Hannah", Balance = 2700.00m }
                ,new Account { Name = "Ian", Balance = 3200.00m }

            };
            // save data to file
            await SaveAccDataAsync(filePath,accounts);

            List<Account> accs = await ReadAccDataAsync(filePath);
            Console.WriteLine("Accounts read from file : ");
            foreach (var acc in accs)
            {
                Console.WriteLine($"Name: {acc.Name}, Balance: {acc.Balance}");
            }

        }

        private static async Task<List<Account>> ReadAccDataAsync(string filePath)
        {
            List<Account> accounts = new List<Account>();
            if (File.Exists(filePath))
            {
                Console.WriteLine("File found, reading data async from json file !");
                string jsonString= await File.ReadAllTextAsync(filePath); ;
                accounts = JsonSerializer.Deserialize<List<Account>>(jsonString);

            }
            else
            {
                Console.WriteLine("File not found !");
            }
            return accounts;
        }

        private static async Task SaveAccDataAsync(string fileP,List<Account> accounts)
        {
            Console.WriteLine("Saving data to json file !");
            string jsonString = JsonSerializer.Serialize(accounts);
            Console.WriteLine(jsonString);
            await File.WriteAllTextAsync(fileP,jsonString);
            Console.WriteLine("Data saved successfully in json file !");

        }


    }
}
