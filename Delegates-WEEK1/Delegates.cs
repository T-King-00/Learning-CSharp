using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Delegates
{
    internal class Delegates
    {
        //this example demonstrates how to use delegates in C# to print a message in three different ways.
        //to define a delegate the delegate definition must be similar to function signature.
        //delegate return_type delegate_name(parameter_list);
        // Instead of using a delegate, you can use a Func or Action delegate that makes our code less shorter

        public delegate void DelPrintMessage(string PrintMessage);


        public static void Main2(string[] args)
        {
            // This is a simple examples of using delegates in C# to print a message in three different ways.
            // using delegate .
            Way1( );

            // using Action delegate.
            // using lambda expression 
            Way2();

            // using lambda expression .
            Way3();


            // Action delegate without parameters 
            ActionDelWithoutParam();

            // Action delegate with 2 parameters
            ActionDelWith2Params("Hello", "World!");
            ////////////////////////////////////////////
            
            // Func delegate with 2 parameters and one return value 
            FuncWay1();

            // Func delegate with 3 different parameters and one return value
            FuncWay2( );

        }

        private static void FuncWay2()
        {
          Func<int,int,string,int> del=(a,b,c)=> 
          {
              Console.WriteLine($"The sum of {a}, {b} ;{c} is {a + b }");
              return a+b;

          };

          int result = del(10, 10, "result of the first two parameters"); // Example usage
          

        }

        private static void FuncWay1()
        {
            Func<int ,int ,int > del=(a,b) => a + b;

            int result = del(5, 10); // Example usage
            Console.WriteLine($"The result of the addition via FUNC delegate  is: {result} ");
            
        }

        private static void ActionDelWith2Params( string v1, string v2 )
        {
           Action<string, string> act = (msg1, msg2) => Console.WriteLine($"{msg1} {msg2}");
           act(v1, v2);
        }

        private static void ActionDelWithoutParam()
        {
          Action act = ()=> Console.WriteLine("Hello, this is a message from the Action delegate without parameters!");
          act();
        }

        public static void Way1()
        {
            // using delegate .
            DelPrintMessage del = new DelPrintMessage(PrintMessage);
            del( "Hello, this is a message from the delegate Way1!");
        }

        public static void Way2()
        {
            // using Action delegate.
            // using lambda expression ,action
            Action<string> act = delegate ( string msg )
            {
                Console.WriteLine( msg );
            };
            act( "Hello, this is a message from the delegate using action with parameter way2!" ); ;

        }

        public static void Way3()
        {

            // using lambda expression .

            Action<string> act = (msg) =>Console.WriteLine(msg);
            act("Hello, this is a message from the lambda expression with action delegate way3!");
        }

        public static void PrintMessage (string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
