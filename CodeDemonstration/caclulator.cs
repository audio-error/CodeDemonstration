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
            try { int.Parse(equationLabel.Text[equationLabel.Text.Length - 1].ToString()); }
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
                evaluation equation = new evaluation();
                writeAnswer("calculating");
                writeAnswer(equation.findAnswer(equation.scan(equationLabel.Text)).ToString()); //convert the string into an equation, then evaluate it from left to right. Finnaly, print the answer to the screen
                equationLabel.Text = string.Empty;
            }
        }

        private void caclulator_Load(object sender, EventArgs e)
        {

        }

        private void caclulator_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}
