namespace ZooManageEncycloFA2
{
    public partial class Prices : Form
    {
        // variables for use within the this form.
        int SeniorsAge;
        int childbotAge;
        int childtopAge;
        string UserInput;
        public Prices()
        {
            InitializeComponent();
            //Contextual for the user.
            tickExplainlab.Text = "Change the prices. Be sure to fill in all the boxes.";
        }

        //method for checking if the userinput is empty or not.
        private bool InputBlankCheck(String input)
        {
            //checkss if the inputs length is less than zero.
            return input.Length > 0;
        }

        private bool NumberCheck(string userPriceInput)
        {
            //try and catch to check if users input is letters and not numbers.
            try
            {
                Convert.ToInt32(userPriceInput);
                return true;
            }
            catch (FormatException ex)
            {
                return false;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //variable for testing the input of the user.
            UserInput = textBox1.Text;
            //used to handle the error returned from the checkeer for the standard price
            if (InputBlankCheck(UserInput) == false)
            {
                standardMesslab.Text = "You cannot have an empty price!";
            }
            else if (NumberCheck(UserInput) == false)
            {
                standardMesslab.Text = "Please use numbers only";
            }
            else
            {
                //shows the userinput on the label if the userinput is validated as correct.
                standardMesslab.Text = UserInput;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInput = textBox1.Text;
            if (InputBlankCheck(UserInput) == false)
            {
                standardMesslab.Text = "You cannot have an empty price!";
            }
            else if (NumberCheck(UserInput) == false)
            {
                standardMesslab.Text = "You have to use numbers please!";
            }
            else
            {
                standardMesslab.Text = Animals.ChangePrice();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UserInput = textBox2.Text;
            if (InputBlankCheck(UserInput) == false)
            {
                seniorLab.Text = "You cannot have an empty price!";
            }
            else if (NumberCheck(UserInput) == false)
            {
                seniorLab.Text = "Please use numbers only";
            }
            else
            {
                seniorLab.Text = UserInput;
            }
        }

        private void seniorAgeSet_ValueChanged(object sender, EventArgs e)
        {
            //minimum and maximum values for the number box so that the user is limited to that range.
            seniorAgeSet.Minimum = 45;
            seniorAgeSet.Maximum = 100;
            //converts the current value of the number updown to integer and assigns it 
            SeniorsAge = Convert.ToInt32(seniorAgeSet.Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            UserInput = textBox2.Text;
            if (InputBlankCheck(UserInput) == false)
            {
                seniorLab.Text = "You cannot have an empty price!";
            }
            else if (NumberCheck(UserInput) == false)
            {
                seniorLab.Text = "Please use numbers only";
            }
            else
            {
                seniorLab.Text = Animals.ChangePrice(SeniorsAge);
            }
        }

        private void childBot_ValueChanged(object sender, EventArgs e)
        {
            //min and max for the child youngest age range
            childBot.Minimum = 3;
            childBot.Maximum = 5;
            childbotAge = Convert.ToInt32(childBot.Value);
        }

        private void childTop_ValueChanged(object sender, EventArgs e)
        {
            //min and max for the child oldest age range
            childTop.Minimum = 6;
            childTop.Maximum = 15;
            childtopAge = Convert.ToInt32(childTop.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //input checker
            UserInput = textBox3.Text;
            if (InputBlankCheck(UserInput) == false)
            {
                childLab.Text = "You cannot have an empty price!";
            }
            else if (NumberCheck(UserInput) == false)
            {
                childLab.Text = "Please use numbers only";
            }
            else
            {
                childLab.Text = Animals.ChangePrice(childbotAge, childtopAge);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UserInput = textBox3.Text;
            if (InputBlankCheck(UserInput) == false)
            {
                childLab.Text = "You cannot have an empty price!";
            }
            else if (NumberCheck(UserInput) == false)
            {
                childLab.Text = "Please use numbers only";
            }
            else
            {
                childLab.Text = UserInput;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
