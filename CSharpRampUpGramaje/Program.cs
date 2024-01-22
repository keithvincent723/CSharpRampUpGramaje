namespace CSharpRampUpGramaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSharpRampUp");

            Console.Write("Enter a number in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kilograms = pounds * 0.45359237;
            Console.WriteLine(pounds + " pounds is " + kilograms + " kilograms");

            Console.ReadLine();
            Console.WriteLine("=========================================================================================");

            Console.WriteLine("miles to kilometers");

            Console.Write("Enter a number in miles: ");
            double miles = Convert.ToDouble(Console.ReadLine());

            double kilometers = miles * 1.609344;
            Console.WriteLine(miles + " miles is " + kilometers + " kilometers");

            Console.ReadLine();
            Console.WriteLine("=========================================================================================");

            Console.WriteLine("Fahrenheit (°F) to Celsius (°C)");

            Console.WriteLine("Enter a temperature in Fahrenheit (°F): ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());

            double Celcius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine(Fahrenheit + "°F is " + Celcius + "°C");
            Console.ReadLine();
            Console.WriteLine("=========================================================================================");

            Console.WriteLine("Average age of 10 Students");

            int noStudents = 10;

            double[] age = new double[noStudents];

            for (int i = 0; i < noStudents; i++)
            {
                Console.Write($"Enter the age for student {i + 1}: ");

                while (!double.TryParse(Console.ReadLine(), out age[i]))
                {
                    Console.WriteLine("Please enter a valid number.");
                    Console.Write($"Enter the age for student {i + 1}: ");
                }
            }

            Console.WriteLine("\nIndividual");
            for (int i = 0; i < noStudents; i++)
            {
                Console.WriteLine($"Student {i + 1}: {age[i]}");
            }

            double sum = 0;
            for (int i = 0; i < noStudents; i++)
            {
                sum += age[i];
            }

            double average = sum / noStudents;

            Console.WriteLine($"\nAverage age of {noStudents} students: {average:F2}");

            Console.WriteLine("=========================================================================================");
            Console.WriteLine("Fantasy Story");
            string mainc = "McQueen";
            string law = "Sheriff";
            string truck = "Mack";
            string chic = "Sally";
            string towing = "Mater";

            string typemain = "racecar";
            string policesiren = "sirens";
            string truckcargo = "cargo";
            string smell = "Premium Gasoline";
            string hook = "tow hook";

            // Story output
            string story = $"A few months ago, {mainc} fell asleep inside {truck}'s open {truckcargo}.";
            story += $" {mainc} woke up in the middle of the road, panicked. He tried to chase other trucks that looked like {truck}";
            story += $"\n\n {mainc} failed to find {truck} and which he ended up a lost {typemain} in the middle of nowhere.";
            story += $"Then he found Radiator springs. But he was not that welcomed. As he came in night, the people thought he was a bad guy. Then the {law} saw him.";

            story += $"\n\nThe {policesiren} of {law} immediately went on as they thought that he was going to steal from their town.";
            story += $" {mainc} rode as fast as he can because he was spooked. Until he ran out of gas and the {law} catched up to him.";

            story += $"\n\nHe tried to explain himself to the {law}. But no one would believe him because it is a rural land.";
            story += $"Without gas and nowhere to run to. {towing} hooked {mainc} to his {hook}";

            story += $"\n\nHe was brought to the court where he met {chic}, the attorney.";
            story += $"The courtroom smelled like {smell}, which made {mainc} scared.";

            // Display the story
            Console.WriteLine(story);
            Console.WriteLine("=========================================================================================");

            Console.WriteLine("PART 2:");
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("=========================================================================================");
            {
                Console.Write("Enter a number: ");
                int k = Convert.ToInt32(Console.ReadLine());

                int sumb = 0;

                for (int i = 1; i <= k; i++)
                {
                    sumb += i;
                }

                Console.WriteLine("Sum of 1 to {0} is: {1}", k, sumb);
                Console.WriteLine("=========================================================================================");
                Console.Write("Enter a number: ");
                int xn = Convert.ToInt32(Console.ReadLine());

                for (int i = xn; i >= 1; i--)
                {
                    for (int z = 1; z <= i; z++)
                    {
                        Console.Write(z + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}