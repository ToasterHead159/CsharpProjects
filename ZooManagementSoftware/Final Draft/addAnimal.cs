//This was not used in the final code as i could not get it to work properly.I think I found the problem will correct for other FA.

namespace ZooManageEncycloFA2
{
    public partial class addAnimal : Form
    {
        private bool InputBlankCheck(String input)
        {
            //checkss if the inputs length is less than zero.
            return input.Length > 0;
        }

        private bool NumberCheck(string UserInfo)
        {
            //try and catch to check if users input is letters and not numbers.
            try
            {
                Convert.ToInt32(UserInfo);
                return true;
            }
            catch (FormatException ex)
            {
                return false;
            }
        }
        //varaibles for use in this form.
        String lionName;
        int lionAge;
        string lionGender;
        bool lionHasMane;
        string UserInput;
        int UserNum;
        public addAnimal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code for when a speicfic animal is chosen only those attributes for that animal appear.
            if (specSelect.Text == "Lion")
            {
                lionNameLab.Visible = true;
                aniName.Visible = true;
                aniAgeLab.Visible = true;
                aniAgecount.Visible = true;
                aniGenlab.Visible = true;
                aniGender.Visible = true;
                yesMane.Visible = true;
                noMane.Visible = true;
                hasManelab.Visible = true;
            }
        }

        private void aniName_TextChanged(object sender, EventArgs e)
        {
            //variable for testing the input of the user.
            UserInput = aniName.Text;
            //used to handle the error returned from the checkeer for the standard price
            if (InputBlankCheck(UserInput) == false)
            {
                var point = new Point(550, 130);
                checker1lab.Location = point;
                checker1lab.Text = "You cannot have an empty name!";
                checker1lab.Show();
            }
            else
            {
                //shows the userinput on the label if the userinput is validated as correct.
                checker1lab.Text = UserInput;
                //used to assign the current name to the variable
                lionName = UserInput;
            }

        }

        private void aniAgecount_ValueChanged(object sender, EventArgs e)
        {
            //variable used to check the number input that the user inputs
            UserNum = Convert.ToInt32(aniAgecount.Value);
            //this checks if the user input is in the range and informs the user if the input is correct or not.
            if (UserNum > 0 && UserNum < 30)
            {
                lionAge = UserNum;

            }
            else
            {
                var point = new Point(550, 180);
                checklab2.Location = point;
                checklab2.Text = "A lion does not live longer than 30 years";
                checklab2.Show();
            }
        }

        private void aniGender_TextChanged(object sender, EventArgs e)
        {
            //takes the current gender and assigns it to the variable
            lionGender = aniGender.Text;
        }
        private void yesMane_CheckedChanged(object sender, EventArgs e)
        {
            //changes the has Mane boolean.
            lionHasMane = true;
        }
        private void noMane_CheckedChanged(object sender, EventArgs e)
        {
            lionHasMane = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if statement to be sure that the none of the data causes other errors in the program.
            if (lionName == null)
            {
                MessLab.Text = "The lion has to have a name.\nLion not added to the Zoo!";
                MessLab.Show();
            }
            else if (lionAge < 0 || lionAge > 30)
            {
                MessLab.Text = "The lion's age is incorrect.\nLion not added to the Zoo!";
                MessLab.Show();
            }
            else if (lionGender == null)
            {
                MessLab.Text = "The lion has to have a gender.\nLion not added to the Zoo!";
                MessLab.Show();
            }
            else if (!yesMane.Checked && !noMane.Checked)
            {
                MessLab.Text = "Please select if the lion has a mane or not.\nLion not added to the Zoo!";
                MessLab.Show();
            }
            else
            {
                //on button click the new object lion should be created and added to the list.
                Lion newestLion = new Lion(lionName, lionAge, lionGender, habitatType.Savannah, foodType.Meat, animalType.BigCat, lionHasMane);
                MainMenu.oldlions.Add(newestLion);

                MessLab.Text = "Lion has been added to the Zoo!";
                MessLab.Show();
            }

        }

        private void MessLab_TextChanged(object sender, EventArgs e)
        {
            //sets the message location when it changes
            var point = new Point(300, 345);
            MessLab.Location = point;
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
