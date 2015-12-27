using static System.Console;

namespace HelloGoodbye.ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {

            string input;
            do
            {
                input = ReadLine();
                var output = GetOutput(input);
                WriteLine(output);
            } while (input != "Hello");
        }

        private static string GetOutput(string input)
        {
            switch (input)
            {
                case "Hello":
                    return "Goodbye";
                case "Merry Christmas":
                    return "And a Happy New Year";
                default:
                    return "Say that again.";
            }
        }
    }
}
