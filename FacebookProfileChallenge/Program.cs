using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookProfileChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Workplace firstWorkplace = new Workplace();

            firstWorkplace.current = "ElevenFifty";
            firstWorkplace.past = "HealthCoach";

            Bio firstBio = new Bio();

            firstBio.current = "Mom of 3 boys. Learning to Code and loving life!";

            Person firstPerson = new Person("Anna", "Heselbarth", new DateTime(1982, 03, 21), firstWorkplace, firstBio);

            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine(firstPerson.AgeInYears);
            Console.ReadKey();
        }
    }
}
