using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDemonstration
{
    //this class will take any two values and return the answer of them
    internal class equation
    {
        private float firstNum;
        private float secondNum;
        private char equationThingy; // +, -, * or /
                                     // 'n' will cause return the value itself

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
                //code commets can be insterted into any line of code, unaffected
                case '\u00D7'/*Times symbol (×)*/: ans = firstNum * secondNum; break;

                case '\u00F7'/*Divide symbol (÷)*/: ans = firstNum / secondNum; break;

                case 'n': ans = firstNum; break;

                default:
                    throw (new equationException("invalid equation"));
            }

            return ans;
        }
    }


    internal class evaluation
    {

        /*Scan function
         *This will take a string equation (1 + 2 - 3 + 4)
         *and returns a list of integers and characters {1,'+',2,'-',3,'+',4}
         *this is as a list of object types so that integers & chars can be stored in the same list
         *The list is a queue types which makes processing each element more simple in the findAnswer method
         */
        public Queue<object> scan(string equationString)
        {
            Queue<object> equationParts = new Queue<object>();
            string currentNum = ""; //the current number digit by digit
            //convert the string into a set of ints & equation stuff
            foreach (char letter in equationString)
            {
                if (char.IsNumber(letter))// if the current char is a number, add to the digits of the current number
                {
                    currentNum += letter;
                }
                else if (char.IsSymbol(letter) || char.IsPunctuation(letter))// if the curret char is a symbol, add it to the equation list
                {
                    equationParts.Enqueue(letter);
                }
                else// if the current char is whitspace, skip and add any current numbers to the equation list
                {
                    if (currentNum != "")
                    {
                        equationParts.Enqueue(int.Parse(currentNum));
                        currentNum = "";
                    }
                    //continue to the next letter
                }
            }
            //add the final number
            if (currentNum != "")
            {
                int n;
                if (!int.TryParse(currentNum,out n))
                {
                    n = 0;
                }
                equationParts.Enqueue(n);
            }

            else equationParts.Clear();
            currentNum = "";

            return equationParts;
        }

        /*find answer method
         * this will take the eqaution as a list of objects and evaluate if from left to right, returning the answer as a float
         * if there are more that three parts to the equation,
             * evaluate the first three parts, then evaluate the rest, eg;
             * 1 + 2 + 3 + 4 => 3 + 3 + 4 => 6 + 4 = 10
         * this method does NOT follow the BIMDAS order of precedence rule.
         */
        public float findAnswer(Queue<object> equationParts)
        {
            while (equationParts.Count > 0)
            {
                if (equationParts.Count > 3)
                {
                    Queue<object> queue = new Queue<object>();

                    float f;
                    try
                    {
                        f = (float)equationParts.Peek();
                        f = (float)equationParts.Dequeue();
                    }
                    catch (Exception)
                    {
                        f = (float)(int)equationParts.Dequeue();
                    }
                    char s = (char)equationParts.Dequeue();
                    float f2 = (float)(int)equationParts.Dequeue();

                    queue.Enqueue(new equation(f, s, f2).answer());
                    foreach (object item in equationParts)
                    {
                        queue.Enqueue(item);
                    }
                    return findAnswer(queue); // iterative function. Will call on itself unil the equation is only 3 parts
                }
                else if (equationParts.Count == 1)
                {
                    return new equation((float)(int)equationParts.Dequeue()).answer();
                }
                else
                {
                    float f;
                    try
                    {
                        f = (float)equationParts.Peek();
                        f = (float)equationParts.Dequeue();
                    }
                    catch (Exception)
                    {
                        f = (float)(int)equationParts.Dequeue();
                    }
                    char s = (char)equationParts.Dequeue();
                    float f2 = (float)(int)equationParts.Dequeue();

                    return new equation(f, s, f2).answer();
                }
            }
            return float.NaN;//equation is not valid
        }
    }

        public class equationException : Exception 
        {
            public equationException(string message) : base(message) { }
        }

}
