using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Business
{
    public class Fibonacci
    {
        private const int _lastIndex = 92;
        private const int _lastNegativeIndex = -92;
        public long GetFibonacci(int index)
        {
            if (index > _lastIndex || index < _lastNegativeIndex)
                throw new OverflowException();

            if (index == 0 || index == 1 || index == -1)
                return index == -1 ? 1 : index;

            return CalculateFabonacciForLoop(index);
        }

        private long CalculateFibonacci(int index)
        {
            if (index <= 1)
                return 1;
            return CalculateFibonacci(index - 2) + CalculateFibonacci(index - 1);
        }

       

        private long CalculateFabonacciForLoop(int index)
        {
            long firstNumber = 0, seconNumber = 1, result = 0;
            int uIndex = index < 0 ? -index : index;
            for (int i = 1; i < uIndex; i++)
            {
                result = index < 0 ? firstNumber - seconNumber : firstNumber + seconNumber;
                firstNumber = seconNumber;
                seconNumber = result;
            }
            return result;
            
        }
    }
}
