namespace FinalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var calculator = new Calculator();
            var userInput = new UserInput(logger);

            Console.WriteLine("Введите первое число:");
            int firstNum = userInput.CheckNum();

            Console.WriteLine("Введите второе число:");
            int secondNum = userInput.CheckNum();


            int result = calculator.Solve(firstNum, secondNum);
            Console.WriteLine($"Результат сложения: {result}");

            Console.ReadKey();
        }
    }
}