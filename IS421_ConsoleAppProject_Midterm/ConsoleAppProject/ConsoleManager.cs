using System;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System.Collections.Generic;
using ConsoleCalculator.Subscribers;
using ConsoleEventHandler;
namespace ConsoleCalculator
{
    public class ConsoleManager
    {
        Calculator _calculator = new Calculator(new CalculatorBuilder());
        ConsoleEventManager _consoleEventMan = new ConsoleEventManager();
        public void Start()
        {
            Console.WriteLine("Please enter which operation you want: ");
            Console.WriteLine("Options: ('add', 'sub', 'div', 'mul')");
        }
        public void PerformCalculation(double firstInput, double secondInput, Func<double, double, double> action)
        {
            DisplayCalculation();
            var _result = _calculator.CreateCalculation(firstInput, secondInput, action);
           


        }
        void DisplayCalculation()
        {
            var displayCalc = new DisplayCalculation();
            _calculator._calcEvent.CalculationCompleted += displayCalc.OnCalculation;

        }
        void StoreUserInput()
        {
            _consoleEventMan._consoleEvent.UserInput += _consoleEventMan.storeUserInput.OnUserInput;
            
        }
        public void InputsDisplay()
        {
            _consoleEventMan.storeUserInput.DisplayInputs();
        }


    }
}
