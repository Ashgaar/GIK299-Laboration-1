using System;
using System.Linq;

namespace Yo
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variabler för att spara data som användaren skriver in.
            int person1Age, person2Age, person3Age, person4Age;
            string person1Name, person2Name, person3Name, person4Name;

            //Frågar efter namn och ålder på person 1
            Console.WriteLine("Skriv namnet på person 1:");
            person1Name = Console.ReadLine();
            Console.WriteLine("Skriv åldern på {0}:", person1Name);
            person1Age = Convert.ToInt32(Console.ReadLine());
            
            //Frågar efter namn och ålder på person 2
            Console.WriteLine("Skriv namnet på person 2:");
            person2Name = Console.ReadLine();
            Console.WriteLine("Skriv åldern på {0}:", person2Name);
            person2Age = Convert.ToInt32(Console.ReadLine());
            
            //Frågar efter namn och ålder på person 3
            Console.WriteLine("Skriv namnet på person 3:");
            person3Name = Console.ReadLine();
            Console.WriteLine("Skriv åldern på {0}:", person3Name);
            person3Age = Convert.ToInt32(Console.ReadLine());
            
            //Frågar efter namn och ålder på person 4
            Console.WriteLine("Skriv namnet på person 4:");
            person4Name = Console.ReadLine();
            Console.WriteLine("Skriv åldern på {0}:", person4Name);
            person4Age = Convert.ToInt32(Console.ReadLine());

            //Skapar variabler och räknar ut hur längde personerna har levt i dagar.
            int person1AgeDays = person1Age * 365;
            int person2AgeDays = person2Age * 365;
            int person3AgeDays = person3Age * 365;
            int person4AgeDays = person4Age * 365;

            //Skriver ut deras namn och ålder
            Console.WriteLine("{0} är {1} år gammal och har levt i {2} dagar.", person1Name, person1Age, person1AgeDays);
            Console.WriteLine("{0} är {1} år gammal och har levt i {2} dagar.", person2Name, person2Age, person2AgeDays);
            Console.WriteLine("{0} är {1} år gammal och har levt i {2} dagar.", person3Name, person3Age, person3AgeDays);
            Console.WriteLine("{0} är {1} år gammal och har levt i {2} dagar.", person4Name, person4Age, person4AgeDays);

            //Räknar ut den sammanlagda åldern
            int totalAge = person1Age + person2Age + person3Age + person4Age;

            //Skriver ut den sammanlagda åldern
            Console.WriteLine("Sammanlagd ålder är: {0}"  ,totalAge);

            //Räknar ut medelåldern
            float averageAge = ((person1Age + person2Age + person3Age + person4Age) / (float)4);
            
            //Skriver ut medelåldern
            Console.WriteLine("Medelåldern är: {0}"  ,averageAge);

            //Räknar ut vem som är äldst och yngst och ger ett värde på boomer och zoomer.
            int[] ages = {person1Age, person2Age, person3Age, person4Age};
            int boomer = ages.Max();
            int zoomer = ages.Min();

            //Kollar vem som är äldst och skriver ut det.
            if (person1Age == boomer){
                Console.WriteLine("{0} är äldst.", person1Name);
            }
            if (person2Age == boomer){
                Console.WriteLine("{0} är äldst.", person2Name);
            }
            if (person3Age == boomer){
                Console.WriteLine("{0} är äldst.", person3Name);
            }
            if (person4Age == boomer){
                Console.WriteLine("{0} är äldst.", person4Name);
            }

            //Kollar vem som är yngst och skriver ut det.
            if (person1Age == zoomer){
                Console.WriteLine("{0} är yngst.", person1Name);
            }
            if (person2Age == zoomer){
                Console.WriteLine("{0} är yngst.", person2Name);
            }
            if (person3Age == zoomer){
                Console.WriteLine("{0} är yngst.", person3Name);
            }
            if (person4Age == zoomer){
                Console.WriteLine("{0} är yngst.", person4Name);
            }
        }
    }
}
