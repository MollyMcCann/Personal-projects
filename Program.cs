using System;
// okay so lets make an app that tracks emmett and evie (my dogs) age by establishing their birth year and then add
//or subtract age depending on what year it is
//tell user emmet and evies age this year (2020)
//ask user to put in a year to see how old they will be
//if they put in 2020 print age (do not add any thing)
//if they go overthe age 16 print that is an old doggo
namespace doggoAgeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
           //int EmmettCurrentAge = 2;
           // int EvieCurrentAge = 1;
            //in 2020 Evie is 1 and Emmett is 2
            Console.WriteLine("let's see how old my dogs are!");
            Console.WriteLine();
            Console.WriteLine("in 2020 Emmett is 2 and Evie is 1");
            Console.WriteLine("Please enter a year:");
            string year = Console.ReadLine();
            int year2 = Int32.Parse(year);
            int givenYear = year2 - 2020 +2;
            int givenYear2 = year2 - 2020 + 1;
            Console.WriteLine("Emmett's age is " + givenYear);
            Console.WriteLine("Evie's age is " + givenYear2);
            if (year2 > 2040)
            {
                Console.WriteLine("that's an old Doggo");
            } 
            if (year2 < 2018)
            {
                Console.WriteLine( "they weren't born yet!");
            }
           
            
            Console.ReadLine();
        }
    }
}
