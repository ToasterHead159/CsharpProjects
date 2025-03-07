namespace ZooManageEncycloFA2
{
    public partial class ViewParrots : Form

    {
        //interface for if the animal is able to fly
        IFlyable fly = new Parrot("", 0, "", habitatType.RainForest, foodType.Fruit, animalType.Bird, "");
        public ViewParrots()
        {
            InitializeComponent();
            //this assigns the text in animal eats to the label
            eatsPar.Text = Animals.Eats();
            //this makes a standard starting point for the text boxes
            var pointEats = new Point(175, 35);
            //this adds the new point to the location of the label.
            eatsPar.Location = pointEats;
            sleepPar.Text = Animals.Sleep();
            var pointSleep = new Point(180, 72);
            sleepPar.Location = pointSleep;

            //this adds the names of the parrots to the combo box for the user to select one of the options.
            selParrots.Items.Add(MainMenu.parrots[0].AniName);
            selParrots.Items.Add(MainMenu.parrots[1].AniName);
        }

        private void selParrots_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexNum = selParrots.SelectedIndex;
            //this if statement checks if which parrot is selected by the user.
            if (selParrots.SelectedIndex == indexNum)
            {
                //displays information about the specifically selected parrot.
                parName.Text = "This parrots name is: " + MainMenu.parrots[indexNum].AniName;
                parName.Show();
                parAge.Text = MainMenu.parrots[indexNum].AniName + " is " + MainMenu.parrots[indexNum].AniAge + " years old.";
                parAge.Show();
                parGen.Text = MainMenu.parrots[indexNum].AniName + " is " + MainMenu.parrots[indexNum].AniGender + ".";
                parGen.Show();
                parFcolor.Text = MainMenu.parrots[indexNum].AniName + " has " + MainMenu.parrots[indexNum].FeatherColor + " feathers.";
                parFcolor.Show();
                parHabi.Text = "Parrots can be found in " + MainMenu.parrots[indexNum].BestHabitat + "s around the world.";
                parHabi.Show();
                foodLab.Text = "Parrots like to eat " + MainMenu.parrots[indexNum].BestFood;
                foodLab.Show();
                aniLab.Text = "Parrots are " + MainMenu.parrots[indexNum].animalType + "s.";
                aniLab.Show();
                string flytext = fly.animalFly();
                flylab.Text = flytext;
                flylab.Show();

                // Display the eating and sleeping behaviour of a parrot using.
                eatsPar.Text = Parrot.Eats();//eating behviour of the parrot.
                sleepPar.Text = Parrot.Sleep();//sleeping behviour of the parrot.
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes the current form.
            this.Close();
        }

        private void eatsPar_TextChanged(object sender, EventArgs e)
        {
            //this makes a standard starting point for the text boxes when the text is changed.
            var point = new Point(140, 35);
            //sets the new point to the labels location.
            eatsPar.Location = point;
        }

        private void sleepPar_TextChanged(object sender, EventArgs e)
        {
            var point = new Point(65, 72);
            sleepPar.Location = point;
        }
    }
}
