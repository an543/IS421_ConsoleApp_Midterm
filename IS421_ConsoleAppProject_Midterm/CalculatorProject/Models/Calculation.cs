using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;

namespace CalculatorProject.Models
{
    public class Calculation
    {
        //store 1 value
        public double A { get; set; }
        //store 1 value
        public double B { get; set; }
        //store a list of values for bulk operations
        public List<double> ListOfValues {get; set;}
        //store a single operation function
        public Func<double,double,double> Operation { get; set; }
        //store a bulk operations function
        public Func<List<double>, double> BulkOperation { get; set; }

        //constructor for 3 param (Double, Double, Function)
        public Calculation(double a, double b, Func<double,double,double> calculation)
        {
            A = a;
            B = b;
            //this stores the operation to be performed on A and B
            Operation = calculation;
        }
        //constructor for 2 param (list, and function)
        public Calculation(List<double> listOfValues, Func<List<double>,double> calculation)
        {
            ListOfValues = listOfValues;

            //this stores the operation to be performed on A and B
            BulkOperation = calculation;
        }
         // Create two create methods , set as static and return back calculation

        public static Calculation Create(double a, double b, Func<double, double, double> _operation){
        
            var _calculation = new Calculation(a, b, _operation);

            return _calculation;
        }
        //2nd Create method for the list
         public static Calculation Create(List<double> listOfValues, Func<List<double>, double> operation){
        
            var _calculation = new Calculation(listOfValues,operation);
            return _calculation;
        }



        public Calculation() { }

        //This calls whatever operation was stored i.e. mult, div, add, sub and returns the answer
       
       /* So we can take if statement out 
        * public double GetResult()
        {
            if(BulkOperation != null)
            {
                return BulkOperation(ListOfValues);
            } else
            {
                return Operation(A, B);
            }
            

        } */
    }
}
