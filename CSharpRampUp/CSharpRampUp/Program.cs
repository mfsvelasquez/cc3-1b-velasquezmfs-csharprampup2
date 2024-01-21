using System;

namespace CSharpRampUP
{
    class Program
    {
        static void Main(string[] args)
        {
            //pounds to kilograms
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Pounds to Kilograms");
            Console.WriteLine("Input weight in Pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kilograms = pounds * 0.453592;

            Console.WriteLine("Weight in pounds = " + pounds + "lbs");
            Console.WriteLine("Weight converted to kilograms = " + kilograms + "kg");
            Console.WriteLine("-----------------------------------------------");
            //miles to kilometers
            Console.WriteLine("Miles to Kilometers");
            Console.WriteLine("Input length in miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());

            double kilometers = miles * 1.609344;

            Console.WriteLine("Length in miles = " + miles + "mi");
            Console.WriteLine("Length converted to kilometers = " + kilometers + "km");
            Console.WriteLine("-----------------------------------------------");
            //fahrenheit to celsius
            Console.WriteLine("Fahrenheit to Celsius");
            Console.WriteLine("Input temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit + "°F");
            Console.WriteLine("Temperature converted to Celsius = " + celsius + "°C");
            Console.WriteLine("-----------------------------------------------");
            //average age of students
            int[] studentAges = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Input age: ");
                studentAges[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int age in studentAges)
            {
                sum += age;
            }

            int averageAge = sum / 10;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Age of Student {i + 1}: {studentAges[i]}");
            }

            Console.WriteLine($"The average age of the students is: {averageAge}");
            Console.WriteLine("-----------------------------------------------");
            //story
            Console.WriteLine("Story");
            string[] characs = { "Atlas", "Avery", "Slade", "Kaori", "Vera" };
            string[] abilities = { "Everlast Compass", "Phantasmal Wrath", "Mighty Axe", "Seraphic Gaze", "Psychomancer" };
            string[] enemies = { "Razorback Cat", "Torment Viper" };
            string place = "Nottpil";

            string story = $@"Three siblings set out on a quest to find a cure for their father on the highest mountain, referred to as {place}. The eldest, {characs[0]}, leads the way with a versatile {abilities[0]}, a shield inherited from their mother. {characs[1]}, the middle sibling, possesses a unique but burdensome ability {abilities[1]} to transform into anything she imagines.  The youngest, {characs[2]}, wields a {abilities[2]} that enhances his speed.
During their journey, they encounter formidable foes also seeking the cure. {characs[2]} uses his {abilities[2]} to swiftly defeat a {enemies[0]} with sharp nails. {characs[1]} showcases her power by transforming into a three-tailed scorpion to overcome a three-headed {enemies[1]}.
Approaching their destination, they encounter two familiar figures, {characs[3]} and {characs[4]}, known for their dangerous abilities. {characs[3]}'s gaze controls and addicts people, while {characs[4]} manipulates thoughts and actions. Realizing the threat, {characs[0]} shields his siblings, but {characs[2]} falls under {characs[3]}'s spell.
In a daring move, {characs[1]} transforms into a wild boar, covering her ears and roaring loudly to rescue {characs[2]} from the spell. In the chaos, they inadvertently fall from the mountain. Upon regaining consciousness, {characs[0]} and {characs[2]} discover {characs[1]}'s sacrifice to break her curse and strengthen their sibling bond. 
At the mountain peak, they find the cure, healing not only their father but also their fractured relationship.";

            Console.WriteLine(story);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Right Triangle");
            Console.WriteLine("Enter a positive integer: ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Summation");
            Console.WriteLine("Enter a number: ");
            string summ = Console.ReadLine();

            if (int.TryParse(summ, out int n) && n > 0)
            {
                int summation = 0;
                string formula = "Formula: ";

                for (int x = 1; x <= n; x++)
                {
                    summation += x;
                    formula += x;

                    if (x < n)
                    {
                        formula += "+";
                    }
                }

                Console.WriteLine($"Input: {n}\n{formula}\nOutput: {summation}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Inverse Right Triangle");
            Console.WriteLine("Enter a positive integer: ");

            string inver = Console.ReadLine();

            if (int.TryParse(inver, out int numb) && numb > 0)
            {
                for (int i = numb; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
