using System;
using CollectionFunction;
using HouseFunction;
// need to practice this code a little more

/*this is all practice from here on out
coding can be really difficult

most things are used in uppercase but properties and fileds can be used for lowercase 
but the second word of that field should be uppercase

*/

namespace c_train106
{
    class Program
    /*   main method will be the first method called/run. (the compiler will look for this method)
        static means, I dont have to instantiate the program class to use the method
        -void, the method will not give anything back
    */
    {
        private static object userInput;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // If you do not make the method static, you have to instantiate it. this is the 
            // example if it is not instantiated 
            /*"Program test = new Program();" // this will instantiate an object
            test.Example();*/

            Program.Example();
    
            House Stephen = new House();
            //Console.WriteLine (Stephen.owner);
            Stephen.MiceName = "Jerry";
            Stephen.Owner = "Carvell";
            Console.WriteLine (Stephen.MiceName);
            Console.WriteLine (Stephen.Owner);
            Console.WriteLine (Stephen.owner);
            
            Console.WriteLine ("what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine ($"Hello {name}! Welcome to my world!");

            Collection collectionObj = new Collection();
            collectionObj.CollectionMain();
        }
        public static int Example()
        {
            return 10;
        }
    }
}
