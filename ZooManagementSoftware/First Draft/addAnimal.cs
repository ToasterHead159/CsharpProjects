//This was not used in the final code as i could not get it to work properly.I think I found the problem will correct for other FA.

namespace ZooManageEncycloFA2
{
    public partial class addAnimal : Form
    {
        internal static List<Lion> lions = []; //list for storing lions
        private ViewLions showLions = new ViewLions();//new instnaces of view lion info. used for testing
        //varaibles for use in this form.
        String lionName;
        int lionAge;
        string lionGender;
        bool lionHasMane;
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
            else if (specSelect.Text == "Parrot")
            {
                parNamelab.Visible = true;
                aniName.Visible = true;
                aniAgeLab.Visible = true;
                aniAge.Visible = true;
                aniGenlab.Visible = true;
                aniGender.Visible = true;

            }
        }

        private void aniName_TextChanged(object sender, EventArgs e)
        {
            //used to assign the current name to the variable
            lionName = aniName.Text;
        }

        private void aniAgecount_ValueChanged(object sender, EventArgs e)
        {
            //assigns the value to the variable
            lionAge = Convert.ToInt32(aniAgecount.Value);
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
            //on button click the new object lion should be created and added to the list.
            Lion newestLion = new Lion(lionName, lionAge, lionGender, lionHasMane);
            lions.Add(newestLion);
            string newListItem = lions[0].AniName;
            //testLab1.Text = newListItem;
            //testLab1.Show();
            //showLions.AddLiontoCombo(newListItem);
            //notification should have been used to notify as a means for validation if all the detials were correct.
            Notify notification = new Notify();
            notification.Show();
        }

        //method for returning the complete list of lions. expecited use for outside this form.
        public static List<Lion> GetLions()
        {
            return lions;
        }


    }

}
