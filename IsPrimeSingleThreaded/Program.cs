using System;
using System.Threading;

namespace IsPrimeSingleThreaded
{
    class Program
    {
        bool goOn = true;

        static void Main(string[] args)
        {
            Program program = new IsPrimeSingleThreaded.Program();
            program.Run();
        }

        public void Run()
        {
            do
            {
                long input = GetUserValue();
                if (input == 0)
                {
                    goOn = false;
                }
                else
                {
                    PrimeChecker pc = new PrimeChecker(input);
                    Thread t = new Thread(new ThreadStart(pc.Check));
                    t.IsBackground = true;
                    t.Start();

                    //pc.Check();
                }
            } while (goOn);
        }

        private long GetUserValue()
        {
            Console.Write("Enter a positive integer value to test whether it is prime (enter 0 to exit) : ");
            return long.Parse(Console.ReadLine());
        }



    }


        
    
}
