﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeDemonstration
{
    /*-OOP concept: structs & classes
     *C# has both structs and classes for encapsulating data. Further, access modifiers change
     *how abstract data is by hiding certain components from view.
     */
    public struct ImageWithDetails
    {
        public Image image;
        public string name;
        public string desciption;
        public double cost;
    }
    public partial class warehouseImages : Form
    {
        ImageWithDetails[] images = new ImageWithDetails[6];
        public warehouseImages()
        {
            InitializeComponent();

            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label4.Text = string.Empty;

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

        public async void changeImage(string n)
        {
            //LINQ statements are similar to SQL and return query result in the form of a IEnumerable
            //LINQ can query an abstract datatype like this struct
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                          where IM.name == n
                                          select IM;

            await addName(ImageQuery, ImageQuery.First().name);
            await addDescription(ImageQuery, ImageQuery.First().desciption);
            await addCost(ImageQuery, ImageQuery.First().cost);
            await addImage(ImageQuery, ImageQuery.First().image);
        }

        private async Task addName(IEnumerable<ImageWithDetails> IQ, string n)
        {
            label1.Text = IQ.First().name;
        }
        private async Task addDescription(IEnumerable<ImageWithDetails> IQ, string d)
        {
            label2.Text = IQ.First().desciption;
        }
        private async Task addCost(IEnumerable<ImageWithDetails> IQ, double c)
        {
            label4.Text = "$" + IQ.First().cost;
        }
        private async Task addImage(IEnumerable<ImageWithDetails> IQ, Image i)
        {
            pictureBox1.Image = IQ.First().image;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                changeImage(comboBox1.Text);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //C# methdods and statements can be empty, unlike Python.
        }
    }
}
