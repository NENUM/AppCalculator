using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Calculator
{
    internal class ArithmeticLogic
    {
        private decimal a;
        private decimal b;

        public bool ConvertNumber(string num)
        {
            try
            {
                Double.Parse(num);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool ConvertNumber(string num1, string num2)
        {
            try
            {
                a = Decimal.Parse(num1);
                b = Decimal.Parse(num2);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public decimal Addition()
        {
            return a + b;
        }

        public decimal Subtraction()
        {
            return a - b;
        }

        public decimal Multiplication()
        {
            return a * b;
        }

        public string Division()
        {
            decimal result; 
            try
            {
                result = a / b;
                return result.ToString();
            }
            catch(Exception e)
            {
                return $"Error, {e.Message}";
            }
            
        }

        public string Modulo()
        {
            decimal result;
            try
            {
                result = a / b;
                return result.ToString();
            }
            catch (Exception e)
            {
                return $"Error, {e.Message}";
            }
        }
    }
}
