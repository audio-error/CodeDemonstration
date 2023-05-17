using CodeDemonstration.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeDemonstration
{
    //In this demonstration there are three classes,
    //a superclass
    //a subclass
    //and an interface
    //
    //Interfaces and inhereitance use the same syntax making it hard to tell what is which in C#
    public partial class inheritance : Form
    {
        SoundPlayer sound = new SoundPlayer(Resource1.Darude_Sandstorm);
        public inheritance()
        {
            InitializeComponent();

            
            sound.Play();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground= true;
                while (true)
                {
                    Random random = new Random();
                    Color color = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    Thread.Sleep(333);
                    BackColor = color;
                }
            }).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void inheritance_FormClosed(object sender, FormClosedEventArgs e)
        {
            sound.Stop();
        }
    }

    //This class is inherently confusing to see what is an interface and what is a superclass. 
    //as the names of the classes/ interfaces dont dictate what tpye they are.
    //
    //a better solution is like Java, which uses seperaete keywords:
    //"class Play extends rave implements party {}"
    //
    //The other two classes are located in party.cs and rave.cs
    //this higlights how the confusion of this syntax is worseded when classes & interfaces are in separate files
    class Play : rave, party
    {
        public void Rave()
        {
            Console.WriteLine("havin a good time");
            partyColour = Color.Red; //red is the colour of a good time
        }
    }
}
