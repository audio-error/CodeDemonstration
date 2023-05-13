using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemonstration
{
    internal class equation
    {
        private float firstNum;
        private float secondNum;
        private char equationThingy;

        public equation(float number1)
        {
            firstNum = number1;
            secondNum = 1;
            equationThingy = 'n';
        }
        public equation(float number1, char equationThingy, float number2)
        { 
            firstNum = number1;
            secondNum = number2;
            this.equationThingy = equationThingy;
        }
        public equation(float number1, char equationThingy, equation equation)
        {
            firstNum = number1;
            secondNum = equation.answer();
            this.equationThingy = equationThingy;
        }
        public equation(equation equation1, char equationThingy, equation equation2)
        {
            firstNum = equation1.answer();
            secondNum = equation2.answer();
            this.equationThingy = equationThingy;
        }

        public float answer()
        {
            float ans = 0;
            

            switch (this.equationThingy)
            {
                case '+': ans = firstNum + secondNum; break;

                case '-': ans = firstNum - secondNum; break;

                case '\u00D7': ans = firstNum * secondNum; break;

                case '\u00F7': ans = firstNum / secondNum; break;

                case 'n': ans = firstNum; break;

                default:
                    throw (new equationException("invalid equation"));
            }

            return ans;
        }

        public class equationException : Exception 
        {
            public equationException(string message) : base(message) { }
        }

    }
}
