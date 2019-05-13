using System;
using HashidsNet;

namespace Id_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Encode();
            //Decode();
        }

        public static void Encode()
        {
            var hashids = new Hashids("Cert");
            var hash = hashids.Encode(683,94108,123,5);

            Console.WriteLine(hash);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void Decode()
        {
            var hashids = new Hashids("this is my salt");
            int[] numbers = hashids.Decode("gB0NV05e");

           foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
