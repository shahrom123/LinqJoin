using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Calculator
    {
        private int _firstNum;
        private int _secondNum;
        public Calculator() { }   

        public Calculator(int firstNum, int secondNum)
        {
            _firstNum = firstNum;
            _secondNum = secondNum;
             
        }
        public int Sum()
        {
            return _firstNum + _secondNum; 
        }
        public int Subtract()
        {
            return _firstNum - _secondNum;
        }
        public int Multiplication() 
        {
            return _firstNum * _secondNum; 
        }
        public int Division()
        {
            if (_secondNum == 0)
            {
                Console.WriteLine("Error:Can not division by zero");
                return 0;
            }
            else
            {
                return _firstNum / _secondNum; 
            }
        }
    }
}
