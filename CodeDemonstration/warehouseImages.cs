using System;
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

        public void changeImage(string n)
        {
            //LINQ statements are similar to SQL and return queary result in the form of a IEnumerable
            //LINQ can query an abstract datatype like this struct
            IEnumerable<ImageWithDetails> ImageQuery = from IM in images
                                          where IM.name == n
                                          select IM;
            label1.Text = ImageQuery.First().name;
            label2.Text = ImageQuery.First().desciption;
            label4.Text = "$" + ImageQuery.First().cost;
            pictureBox1.Image = ImageQuery.First().image;
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

        }
    }
}
