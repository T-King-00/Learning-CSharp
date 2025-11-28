using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.TPL_WEEK3
{
    internal class TPLEx3
    {


        public static async Task Main0(string[] args)
        {
            var task = Task.Run(() => throw new CustomException("this is custom exception"));
            try
            {
                task.Wait();
            }
            catch (AggregateException ex)
            {
               /* ex.Handle(e =>
                {
                Console.WriteLine(ex.Message);
                if (e is CustomException)
                {
                    Console.WriteLine("Handled custom exception: " + e.Message);
                    return true; // Indicate that the exception was handled
                }
                return false; // Indicate that the exception was not handled*/

                foreach (var x in ex.InnerExceptions)
                {
                    // Handle the custom exception.
                    if (x is CustomException)
                    {
                        Console.WriteLine(x.Message);
                    }
                    // Rethrow any other exception.
                    else
                    {
                        throw x;
                    }
                };
               
        
            }

        }
    }
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
