using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace ConsoleCalculator.ConsolePublisher
{

    public class ConsoleEvent
    {
        public event EventHandler<ConsoleEventArgs> UserInput;
        public void GetUserInput(double userInput)
        {
            Console.WriteLine("User Input : ");

            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(double userInput)
        {

            if(UserInput != null) 
                UserInput(this, new ConsoleEventArgs() { UserNumberInput = userInput });
        }
        public void GetUserInputAct(Func<double, double, double> userInput)
        {
            Console.WriteLine("User Action : ");


            OnUserInput(userInput);
        }
        protected virtual void OnUserInput(Func<double, double, double> userInput)
        {

            UserInput.Invoke(this, new ConsoleEventArgs() { UserActionInput = userInput });
        }

    }
}
