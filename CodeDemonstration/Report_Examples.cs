using CodeDemonstration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeDemonstration
{
    public partial class Report_Examples : Form
    {
        public Report_Examples()
        {
            InitializeComponent();
            //example of a switch-case for the document
            int age = 1;
            string rating = "G";
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

            rating = age switch
            {
                13 => "PG 13",

                15 => "MA 15",

                18 => "R 18+",

                _ => "G"
            };
            Console.Write(rating);

            //example if-statments
            if (age < 22)
            {
                Debug.WriteLine(age + " | " + rating); age++;
            }
            else
            {
                Debug.WriteLine("no more :(");
            }

            //for loop
            for (int i = 0; i < /*length*/10; i++)
            {
                //do stuff 10 times
            }

            //print the contents of SomeNubers IEnumerable
            foreach (int number in SomeNumbers())
            {
                Debug.Write(number.ToString() + " ");
            }
            // Output: 3 5 8
            Console.Read();

            List<int> ints = new List<int>(); // lists in C# cannot support multiple tpyes

            ints.Add(1); //only integers are added
            ints.Add('a'); //chars are converted to their neumeric equivilent e.g. 'a' -> 97
            //ints.Add("a string is here"); //Strings are not integers and cannot be added


            List<object> objs = new List<object>(); //but all types inherit from object
            //so all types are technically of the type object
            objs.Add(1);//int
            objs.Add("2");//string
            objs.Add(true);//bool
            objs.Add(1.23f);//float
            myClass m = new myClass(); objs.Add(m); //even abstract types like classes
            //this list is now technically multi-type
        }
        public static System.Collections.IEnumerable SomeNumbers() //Inumerable example
        {
            yield return 3;
            yield return 5;
            yield return 8;
        }
        public enum states //a seccond enum example
        {
            NONE, //each name is just a code for a number. e.g. NONE = 0
            WALKING,// = 1
            RUNNING,// = 2
            JUMPING // = 3
            //simply for readability and esspecially useful for case statements
            //where having numbers is confusing
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            caclulator form = new caclulator();
            form.Show(this);  //Show Form assigning this form as the forms owner
        }

        private void warehouseImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouseImages form = new warehouseImages();
            form.Show(this);  //Show Form assigning this form as the forms owner
        }

        private void itemNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warehouseStrings form = new warehouseStrings();
            form.Show(this);  //Show Form assigning this form as the forms owner
        }

        private void usingTheFORMEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usingEdotr form = new usingEdotr();
            form.Show(this);  //Show Form assigning this form as the forms owner
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void partyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inheritance form = new inheritance();
            form.Show(this);  //Show Form assigning this form as the forms owner
        }
    }
    //class examples
    class myClass
    {
    private
        int chocolate;// not accesible by other classes
    public
        void eat()
    { /*code here*/ chocolate--; } //accesible by other classes
    }
    class anotherClass
    {
    public
        int ReadWrite
    { get; set; }
    public
        int ReadOnly
    { get; }
    }


}
