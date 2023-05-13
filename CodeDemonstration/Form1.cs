using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeDemonstration
{
    class newClass
    {
        public void mainCode()
        {
            //create the thread
            Thread myThread = new Thread(new ThreadStart(newThread));

            //start the thread
            myThread.Start();

            //To interrupt a thread:
            myThread.Interrupt();

        }

        static void newThread()
        {
            //some code
            //will pause the thread for specified milliseconds
            Thread.Sleep(1000);
            //some more code
        }


    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    }
}
