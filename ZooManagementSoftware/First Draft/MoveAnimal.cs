namespace ZooManageEncycloFA2
{
    public partial class MoveAnimal : Form
    {
        public bool enclosureState;//variable for checking the enclosures state before moving.
        public bool aniReadyState;//variable for checking if the animal is ready before moving.

        //making new onjects of the enclosure class.
        Enclosures lionEnclosure = new Enclosures("Lion Enclosure", true);
        Enclosures birdEnclosure = new Enclosures("Bird Enclosure", true);
        Enclosures tortoiseEnclosure = new Enclosures("Tortoise Enclosure", true);

        public MoveAnimal()
        {

            InitializeComponent();
            //adding the enclosure names to the combo box for user selection.
            SelEnclo.Items.Add(lionEnclosure.encName);
            SelEnclo.Items.Add(birdEnclosure.encName);
            SelEnclo.Items.Add(tortoiseEnclosure.encName);
            //adding animal names to the combo box for user selection.
            SelAnimal.Items.Add(MainMenu.oldlions[0].AniName);
            SelAnimal.Items.Add(MainMenu.oldlions[1].AniName);
            SelAnimal.Items.Add(MainMenu.parrots[0].AniName);
            SelAnimal.Items.Add(MainMenu.parrots[1].AniName);
            SelAnimal.Items.Add(MainMenu.tortoises[0].AniName);
            SelAnimal.Items.Add(MainMenu.tortoises[1].AniName);
            //gives the label the string.
            moveStatlab.Text = "Pending...";
        }

        private void SelEnclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if specific enclosure selected the enclosure state is assigned to the enclosure state variable.
            if (SelEnclo.Text == "Lion Enclosure")
            {
                enclosureState = lionEnclosure.WasCleaned;
            }
            else if (SelEnclo.Text == "Bird Enclosure")
            {
                enclosureState = birdEnclosure.WasCleaned;
            }
            else if (SelEnclo.Text == "Tortoise Enclosure")
            {
                enclosureState = birdEnclosure.WasCleaned;
            }
        }

        private void encloClean_CheckedChanged(object sender, EventArgs e)
        {
            //the enclosure state is changed when the yes radio button is pushed.
            enclosureState = true;
        }

        private void encloDirty_CheckedChanged(object sender, EventArgs e)
        {
            //the enclosure state is changed when the no radio button is pushed.
            enclosureState = false;
        }

        private void SelAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when an animal is selected the question appears.
            if (SelAnimal.Text == "Peter")
            {
                quesAniReady.Text = "Is Peter ready to be moved?";
                quesAniReady.Visible = true;
            }
            else if (SelAnimal.Text == "Lucy")
            {
                quesAniReady.Text = "Is Lucy ready to be moved?";
                quesAniReady.Visible = true;
            }
            else if (SelAnimal.Text == "Oliver")
            {
                quesAniReady.Text = "Is Oliver ready to be moved?";
                quesAniReady.Visible = true;
            }
            else if (SelAnimal.Text == "Mary")
            {
                quesAniReady.Text = "Is Mary ready to be moved?";
                quesAniReady.Visible = true;
            }
        }

        private void aniYes_CheckedChanged(object sender, EventArgs e)
        {
            //changes the animal ready state when the Yes Radio button is clicked
            aniReadyState = true;
        }

        private void aniNo_CheckedChanged(object sender, EventArgs e)
        {
            //changes the animal ready state when the No Radio button is clicked
            aniReadyState = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //when the button is clicked it makes a new object of the animal class to use the interface. 
            IMovable moveableAnimal = new Animals("toast", 23, "male");
            //calls the methods and assignes the values from the methods in the animal class.
            bool enclosureReady = moveableAnimal.enclosureReady(enclosureState);
            bool aniReadyforTrans = moveableAnimal.animalReadytomove(aniReadyState);
            //depending on which states are true the prompt will tell the user if the animal has moved or what is preventing the animal from being moved.
            if (enclosureReady == true && aniReadyforTrans == true)
            {
                moveStatlab.Text = "The animal has been moved.";
            }
            else if (enclosureReady == false && aniReadyforTrans == true)
            {
                moveStatlab.Text = "The enclosure is not ready.";
            }
            else if (enclosureReady == true && aniReadyforTrans == false)
            {
                moveStatlab.Text = "The animal is not ready to move.";
            }
            else
            {
                moveStatlab.Text = "Pending...";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //closes the current window.
            this.Close();
        }


    }
}

