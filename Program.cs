namespace Ternary_Operator___Challenge
{
    internal class Program
    {
        public static bool CheckTemperatureIsInteger(string input)
        {
            int number;
            bool isInteger = int.TryParse(input, out number);
            return isInteger;
        }
        static void Main(string[] args)
        {
            string temperatureMessage;
            Console.Write("Please enter a temperature:");
            string userInput = Console.ReadLine();
            bool isInputInteger = CheckTemperatureIsInteger(userInput);
            if (isInputInteger)
            {
                int checkedInput = Convert.ToInt32(userInput);
                temperatureMessage = (checkedInput <= 15) ? "it is too cold here"
                    : (checkedInput >= 16 && checkedInput <= 28) ? "It is ok" : "It is hot here";
                Console.WriteLine(temperatureMessage);
            }
            else
            {
                Console.WriteLine("Please enter a valid temperature");
            }
            Console.Read();
        }
    }
}