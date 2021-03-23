using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {

        public List<Calculation> Calculations = new List<Calculation>();


        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }
        public Calculator(List<double> listOfValues, Func<List<double>, double> _operation)
        {

            CreateCalculation(listOfValues, _operation);

        }
        public Calculator(double a, double b, Func<double, double, double> _operation)
        {

            CreateCalculation(a, b, _operation);

        }
        //Using polumorphism to know which methods to call 
        public void CreateCalculation(double a, double b, Func<double, double, double> _operation)
        {
            
            var _calculation = Calculation.Create(a, b, _operation);

             return _calculation;

        }
        public void CreateCalculation(List<double> listOfValues, Func<List<double>, double> operation)
        {

            var _calculation = Calculation.Create(listOfValues,operation);

            return _calculation;

        }
        //Add another method - Calculation
        public addCalculation(Calculation a){

            Calculation.add(a);
        
        }
        public Calculate(double a,double b, dynamic op) //checking "dynamic", to avoid the compile time type checking, the compiler gets the type at the run time. 
        {
            CreateCalculation(a, b, op);

        }
    }
}
