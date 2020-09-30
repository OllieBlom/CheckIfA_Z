using System;

namespace CheckIfA_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your character: ");
            int character = Convert.ToChar(Console.ReadLine());
            if ((character > 64 && character < 91) || (character > 96 && character < 123))
            {
                Console.WriteLine("That's a letter!!!");
            }
            else
            {
                Console.WriteLine("That isn't a letter!!!");
            }
            
            //Console.WriteLine(character);

        }
    }
}