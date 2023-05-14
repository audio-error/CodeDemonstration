using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeDemonstration
{
    public partial class warehouseStrings : Form
    {
        ImageWithDetails[] images = new ImageWithDetails[6];
        public warehouseStrings()
        {
            InitializeComponent();

            label2.Text = string.Empty;

            //initialise array in a crude, but effective way
            for (int i = 0; i < 6; i++)
            {
                ImageWithDetails IM;
                IM.image = i switch
                {
                    0 => Resource1.table1,
                    1 => Resource1.table2,
                    2 => Resource1.table3,
                    3 => Resource1.table4,
                    4 => Resource1.table5,
                    5 => Resource1.table6
                };
                IM.name = i switch
                {
                    0 => "table 1",
                    1 => "table 2",
                    2 => "table 3",
                    3 => "table 4",
                    4 => "table 5",
                    5 => "table 6"
                };
                IM.desciption = i switch
                {
                    0 => "a wooden coffee table",
                    1 => "a dark-wood small dinning table",
                    2 => "a wooden passageway table",
                    3 => "a pine outdoor table",
                    4 => "a metal coffee table",
                    5 => "a glass sitting table"
                };
                IM.cost = i switch
                {
                    0 => 150,
                    1 => 200,
                    2 => 75,
                    3 => 60,
                    4 => 65,
                    5 => 230
                };

                images[i] = IM;
            }
        }
        private void setLabel(IEnumerable<ImageWithDetails> ImageQuery)
        {
            label2.Text = string.Empty;
            foreach (ImageWithDetails item in ImageQuery)
            {
                label2.Text += item.name + " | " + item.cost + " | " + item.desciption + "\n";
            }
        }

        //list all tables
        private void button1_Click(object sender, EventArgs e)
        {
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                                       select IM;

            setLabel(ImageQuery);
        }
        //list tables 1-3
        private void button2_Click(object sender, EventArgs e)
        {
            //the where statement can perform complicated operation like convert the 7th letter to a number, and 
            //check if it is less than three
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                                       where int.Parse(IM.name[6].ToString()) <= 3
                                                       select IM;
            setLabel(ImageQuery);
        }
        //list table 4
        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                                       where int.Parse(IM.name[6].ToString()) == 4
                                                       select IM;
            setLabel(ImageQuery);
        }
        //list odd tables
        private void button4_Click(object sender, EventArgs e)
        {
            //or even perform a modulo
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                                       where int.Parse(IM.name[6].ToString()) % 2 == 1
                                                       select IM;
            setLabel(ImageQuery);
        }
        //list tabels with "wooden" in their descrition
        private void button5_Click(object sender, EventArgs e)
        {
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                                       where IM.desciption.Contains("wooden")
                                                       select IM;
            setLabel(ImageQuery);
        }
    }
}
