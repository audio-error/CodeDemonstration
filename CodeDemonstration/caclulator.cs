using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeDemonstration
{
    public partial class caclulator : Form
    {
        public caclulator()
        {
            InitializeComponent();
            equationLabel.Text = "";
            answerLabel.Text = "";
        }
        void writeAnswer(string answer)
        {
            answerLabel.Text = answer;
        }


        private void b1_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            equationLabel.Text += "0";
        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            try { int.Parse(equationLabel.Text[equationLabel.Text.Length-1].ToString()); }
            catch (Exception) { return; }
            equationLabel.Text += " + ";
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            try { int.Parse(equationLabel.Text[equationLabel.Text.Length - 1].ToString()); }
            catch (Exception) { return; }
            equationLabel.Text += " - ";
        }

        private void bTimes_Click(object sender, EventArgs e)
        {
            try { int.Parse(equationLabel.Text[equationLabel.Text.Length - 1].ToString()); }
            catch (Exception) { return; }
            equationLabel.Text += " \u00D7 ";
        }
        private void bDivide_Click(object sender, EventArgs e)
        {
            try { int.Parse(equationLabel.Text[equationLabel.Text.Length - 1].ToString()); }
            catch (Exception) { return; }
            equationLabel.Text += " \u00F7 ";
        }
        private void bEquals_Click(object sender, EventArgs e)
        {
            if (equationLabel.Text != string.Empty)
            {
            writeAnswer("calculating");
            scan();
            equationLabel.Text = string.Empty; 
            }
        }

        private void scan()
        {
            string equationString = equationLabel.Text;
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
            equationParts.Enqueue(int.Parse(currentNum));
            currentNum = "";

            writeAnswer(findAnswer(equationParts).ToString());
        }

        private float findAnswer(Queue<object> equationParts)
        {

            /* if there are more that three parts to the equation,
             * evaluate the first three parts, then evaluate the rest, eg;
             * 1 + 2 + 3 + 4 => 3 + 3 + 4 => 6 + 4 = 10
             */
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
                    return findAnswer(queue);
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
            return 0f;//not intended to be used
        }


    }

}
