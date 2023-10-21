using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask
{
    internal class UserInput
    {
        ILogger Logger { get; set; }    

        public UserInput(ILogger logger)
        {
            Logger = logger;
        }

        public int CheckNum()
        {         
            int userInput = 0;
            bool checkInput = false;

            do
            {
                try
                {                
                    if (int.TryParse(Console.ReadLine(), out userInput))
                    {
                        Logger.Event($"Введено целое число: {userInput}");
                        checkInput = true;
                    }
                    else
                    {
                        throw new CustomException("Требуется ввести целое число");
                    }
                }
                catch (CustomException ce)
                {
                    Logger.Error(ce.Message);
                    //Console.WriteLine(ce.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            while (!checkInput);

            return userInput;
        }
    }
}
