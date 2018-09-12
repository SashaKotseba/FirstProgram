using System;

namespace FirstProgram
{
    class HoursOfSleep
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", how many hours of sleep did you get last night?");
            int hours = int.Parse(Console.ReadLine());

            if(hours >= 8 && hours < 12 ){
                Console.WriteLine("that`s good");
            }

            else if(hours >= 12) {
                Console.WriteLine("hey man, that`s so much");
            }

            else if(hours < 8 && hours >= 6) {
                Console.WriteLine("not bad");
            }

            else if(hours < 6 && hours >= 0) {
                Console.WriteLine("that`s bad");
            }

            else{
                Console.WriteLine("you could not sleep " + hours);
            }  
        }
    }
}
