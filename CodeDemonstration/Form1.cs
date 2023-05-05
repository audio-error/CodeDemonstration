using System;
using System.Diagnostics;

namespace CodeDemonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

            //example of a switch-case for the document
            int age = 1;
            string rating = "G";
            doSwitch:
            switch (age)
            {
                case 13:
                    rating = "PG 13";
                    break;

                case 15:
                    rating = "MA 15";
                    break;

                case 18:
                    rating = "R 18+";
                    break;

                default:
                    //do nothing
                    break;
            }
            Console.Write(rating);

            //example if-statments
            if (age < 22)
            {
                Debug.WriteLine(age + " | " + rating); age++; goto doSwitch;
            }
            else
            {
                Debug.WriteLine("no more :(");
            }

            //testing the yeild return to see what it does
            foreach (int number in SomeNumbers())
            {
                Debug.Write(number.ToString() + " ");
                label1.Text+= number.ToString() + " ";
            }
            // Output: 3 5 8
            Console.Read();
        }
        public static System.Collections.IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 8;
        }
    }
}