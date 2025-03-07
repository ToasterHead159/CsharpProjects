namespace ZooManageEncycloFA2
{
    public partial class ViewLions : Form
    {
        Iclimbable iclimbable = new Lion("", 0, "", habitatType.Savannah, foodType.Meat, animalType.BigCat, true);
        Iswimmable iswimmable = new Lion("", 0, "", habitatType.Savannah, foodType.Meat, animalType.BigCat, true);
        string selectedAnimals;
        public ViewLions()
        {
            InitializeComponent();

            //this assigns the text in animal eats to the label
            EatsLab.Text = Animals.Eats();
            //this sets a start point for the eats and sleeps labels. They change when an animal is selected
            var pointEats = new Point(175, 35);
            EatsLab.Location = pointEats;
            sleepLab1.Text = Animals.Sleep();
            var pointSleep = new Point(175, 72);
            sleepLab1.Location = pointSleep;
            //for each loop to add the animal names in the lions list to the combo box
            foreach (Lion lion in MainMenu.oldlions)
            {
                lionChoice.Items.Add(lion.AniName);
            }

        }

        private void lionChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this is used as the index position chosen is also the index position of the lion in the lionlist.
            int indexNum = lionChoice.SelectedIndex;
            //this if statement checks if which indexposition is selected by the user.
            if (lionChoice.SelectedIndex == indexNum)
            {
                //displays information about the specifically selected parrot.
                lionNamelab.Text = "This lions name is: " + MainMenu.oldlions[indexNum].AniName + ".";
                lionNamelab.Show();
                lionAgelab.Text = MainMenu.oldlions[indexNum].AniName + " is " + MainMenu.oldlions[indexNum].AniAge + " years old.";
                lionAgelab.Show();
                lionGenderlab.Text = MainMenu.oldlions[indexNum].AniName + " is a " + MainMenu.oldlions[indexNum].AniGender + " lion.";
                lionGenderlab.Show();
                anilab2.Text = "Lions are known as a " + MainMenu.oldlions[indexNum].animalType;
                anilab2.Show();
                foodlab2.Text = "Lions eat only " + MainMenu.oldlions[indexNum].BestFood;
                foodlab2.Show();
                Hablab.Text = "Lions are found mainly in " + MainMenu.oldlions[indexNum].BestHabitat;
                Hablab.Show();
                String canClimb = iclimbable.animalClimb();
                climbLab.Text = canClimb;
                climbLab.Show();
                String canSwim = iswimmable.animalSwim();
                swimlab.Text = canSwim;
                swimlab.Show();
                bool checkHasMane = MainMenu.oldlions[indexNum].HasMane;
                if (checkHasMane == true)
                {
                    lionHasManelab.Text = MainMenu.oldlions[indexNum].AniName + " has a big mane!";
                }
                else
                {
                    lionHasManelab.Text = MainMenu.oldlions[indexNum].AniName + " has no mane!";
                }
                lionHasManelab.Show();
                // Display the eating and sleeping behaviour of a lion.
                EatsLab.Text = Lion.Eats();//eating behaviour of a lion.
                sleepLab1.Text = Lion.Sleep();//sleeping behaviour of a lion.

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //makes a new instance of the more info form.
            var moreInfo = new MoreInfocs();
            //displays the form
            moreInfo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //closes the current form.
            this.Close();
        }

        private void EatsLab_TextChanged(object sender, EventArgs e)
        {
            //sets the go to point of the label once the text changes
            var goToPoint = new Point(175, 10);
            EatsLab.Location = goToPoint;
        }

        private void sleepLab1_TextChanged(object sender, EventArgs e)
        {
            //sets the go to point of the label once the text changes
            var goToPoint = new Point(102, 50);
            sleepLab1.Location = goToPoint;
        }
    }
}
