

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // CHALLENGE 1



            /*
            List<int> numbers = new List<int>();
            int number;

            while (true)
            {
                Console.WriteLine("Enter a number (press Enter to stop):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                if (int.TryParse(input, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            if (numbers.Count > 0)
            {
                int smallest = numbers.Min();
                int largest = numbers.Max();

                Console.WriteLine($"Smallest number entered: {smallest}");
                Console.WriteLine($"Largest number entered: {largest}");
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }
        }
            */


            // CHALLENGE 2

            WeatherData w1 = new WeatherData(50,69,'F');
            Console.WriteLine(w1);
            w1.DisplayWeatherInfo();
            w1.Convert();
            w1.DisplayWeatherInfo();

            WeatherData w2 = new WeatherData(80, 200, 'E');
            w2.DisplayWeatherInfo();


        }
    }
}