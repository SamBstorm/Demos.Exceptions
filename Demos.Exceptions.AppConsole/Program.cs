using System;

namespace Demos.Exceptions.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                CommonObjects.ExceptionsFactory.BadArgument();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
