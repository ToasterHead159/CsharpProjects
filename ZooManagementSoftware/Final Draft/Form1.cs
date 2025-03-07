namespace ZooManageEncycloFA2
{
    public partial class MainMenu : Form
    {
        //Defining the list in the Main so that it is avaliable throughout all the code.
        public static List<Lion> oldlions = []; //list for lions in the zoo
        public static List<Parrot> parrots = []; //list for parrots in the zoo
        public static List<Tortoise> tortoises = []; //list for tortoises in the zoo.
        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; //centers the window on the screen

            //Creates instances of the Lion Class and adds to the lists
            Lion maleLion = new Lion("Peter", 7, "male", habitatType.Savannah, foodType.Meat, animalType.BigCat, true);
            Lion femaleLion = new Lion("Lucy", 5, "female", habitatType.Savannah, foodType.Meat, animalType.BigCat, false);
            oldlions.Add(maleLion);
            oldlions.Add(femaleLion);

            //Creates instances of the Parrot Class and adds to the lists
            Parrot maleParrot = new Parrot("Oliver", 12, "male", habitatType.RainForest, foodType.Seeds, animalType.Bird, "Green");
            Parrot femaleParrot = new Parrot("Mary", 15, "female", habitatType.RainForest, foodType.Seeds, animalType.Bird, "Orange");
            parrots.Add(maleParrot);
            parrots.Add(femaleParrot);

            //Creates instances of the Tortoise Class and adds to the lists
            Tortoise maleTortoise = new Tortoise("Major HardShell", 35, "male", habitatType.Plains, foodType.Vegetables, animalType.Reptile, "Black/Yellow");
            Tortoise femaleTortoise = new Tortoise("Myrtle", 30, "female", habitatType.Plains, foodType.Vegetables, animalType.Reptile, "Black/Yellow");
            tortoises.Add(maleTortoise);
            tortoises.Add(femaleTortoise);
        }

        private void visitBtn1_Click(object sender, EventArgs e)
        {
            //Open the Zoo Map for the visitors when the button is clicked.
            var visitorsForm = new visitorForm();
            visitorsForm.ShowDialog();
        }

        private void ManBtn1_Click(object sender, EventArgs e)
        {
            //Open the management window when the button is clicked
            var ManagementForm = new ManageForm();
            ManagementForm.ShowDialog();
        }

        private void clsBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
