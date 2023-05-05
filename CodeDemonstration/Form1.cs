using System;

namespace CodeDemonstration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";

            //example of a switch-case for the document
            int age = 15;
            string rating;

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
                    rating = "G";
                    break;
            }
            Console.Write(rating);

            //testing the yeild return to see what it does
            foreach (int number in SomeNumbers())
            {
                Console.Write(number.ToString() + " ");
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