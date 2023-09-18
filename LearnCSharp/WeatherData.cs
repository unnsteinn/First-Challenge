using static System.Formats.Asn1.AsnWriter;

namespace LearnCSharp
{
    internal class WeatherData
    {
        public WeatherData(double temperature, double humidity, Char scale)
        {
            Temp = temperature;
            Hum = humidity;
            Scale = scale;


        }

        private double _temp;
        public double Temp
        {
            get
            {
                return _temp;
            }
            set
            {
                if (value < -60)
                {
                    Console.WriteLine("That must be a mistake any number temperature -60 is unrealistic");
                }
                if (value > 60)
                {
                    Console.WriteLine("That must be a mistake any temperature above 60 is unrealistic");
                }
                else
                {
                    _temp = value;
                }
            }
        }

        private double _hum;
        public double Hum
        {
            get
            {
                return _hum;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Please enter a humidity between 0% and 100% ");
                }
                else
                {
                    _hum = value; 
                }

            }

        }

        private char _scale;
        public char Scale
        {
            get
            {
                return _scale;
            }
            set
            {
                if (value == 'C' || value == 'F')
                {
                    _scale = value;
                }
                else
                {
                    Console.WriteLine("Thats not a valid Character, please use 'C' or 'F'");
                }
            }

        }
        public void Convert()
        {
            if (_scale == 'C')
            {
                _temp = (_temp * 9 / 5) + 32;
                _scale = 'F';
            }
            else if (_scale == 'F')
            {
                // Convert from Fahrenheit to Celsius
                _temp = (_temp - 32) * 5 / 9;
                _scale = 'C';
            }
        }

        public void DisplayWeatherInfo()
        {
            Console.WriteLine($"Temperature: {_temp} {_scale}");
            Console.WriteLine($"Humidity: {_hum}%");
        }

    }

}
