namespace ZooManageEncycloFA2
{
    public partial class Dieting : Form
    {
        //new lion object to access the dietary requirements structs
        Lion lion = new Lion("Peter", 7, "male",habitatType.Savannah,foodType.Meat,animalType.BigCat, true);
        public Dieting()
        {
            InitializeComponent();
        }

        private void lionDiet_Click(object sender, EventArgs e)
        {
            //makes a new object of the struct and adds the specific information to the various labels
            lion.Diet = new DietReq { typeFood = "Meat", numFeeds = "Twice a day", feedTimes = ["09:00", "16:00"] };
            typeFood.Text = lion.Diet.typeFood;
            typeFood.Show();
            numFeeds.Text = lion.Diet.numFeeds;
            numFeeds.Show();
            List<string> feedTimes = lion.Diet.feedTimes;
            String feedingTime = "";
            //for each loop to make the list printable to the label
            foreach (string time in feedTimes)
                feedingTime += time + "\n";
            feedTime.Text = feedingTime;
            feedTime.Show();
        }

        private void typeFood_Click(object sender, EventArgs e)
        {

        }

        private void parDiet_Click(object sender, EventArgs e)
        {
            Parrot parrot = new Parrot("Oliver", 12, "male",habitatType.RainForest,foodType.Seeds,animalType.Bird, "Green");
            parrot.Diet = new DietReq { typeFood = "Fruit, Seeds", numFeeds = "Three times a day", feedTimes = ["08:00", "13:00", "19:00"] };
            typeFood.Text = parrot.Diet.typeFood;
            typeFood.Show();
            numFeeds.Text = parrot.Diet.numFeeds;
            numFeeds.Show();
            List<string> feedTimes = parrot.Diet.feedTimes;
            String feedingTime = "";
            foreach (string time in feedTimes)
                feedingTime += time + "\n";
            feedTime.Text = feedingTime;
            feedTime.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tortoise tortoise = new Tortoise("Major HardShell", 35, "male",habitatType.Plains,foodType.Vegetables,animalType.Reptile, "Black/Yellow");
            tortoise.Diet = new DietReq { typeFood = "Fruit, Vegetables", numFeeds = "Once", feedTimes = ["07:00"] };
            typeFood.Text = tortoise.Diet.typeFood;
            typeFood.Show();
            numFeeds.Text = tortoise.Diet.numFeeds;
            numFeeds.Show();
            List<string> feedTimes = tortoise.Diet.feedTimes;
            String feedingTime = "";
            foreach (string time in feedTimes)
                feedingTime += time + "\n";
            feedTime.Text = feedingTime;
            feedTime.Show();
        }

        private void typeFood_TextChanged(object sender, EventArgs e)
        {
            //sets go to point for the label when the text is updated
            var goToPoint = new Point(550, 125);
            typeFood.Location = goToPoint;
        }

        private void numFeeds_TextChanged(object sender, EventArgs e)
        {
            var goToPoint = new Point(550, 207);
            numFeeds.Location = goToPoint;
        }

        private void feedTime_TextChanged(object sender, EventArgs e)
        {
            var goToPoint = new Point(550, 277);
            feedTime.Location = goToPoint;
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
