namespace ZooManageEncycloFA2
{
    public partial class ViewParrots : Form
    {
        public ViewParrots()
        {
            InitializeComponent();
            //this assigns the text in animal eats to the label
            eatsPar.Text = Animals.Eats();
            sleepPar.Text = Animals.Sleep();

            //this adds the names of the parrots to the combo box for the user to select one of the options.
            selParrots.Items.Add(MainMenu.parrots[0].AniName);
            selParrots.Items.Add(MainMenu.parrots[1].AniName);
        }

        private void selParrots_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this if statement checks if which parrot is selected by the user.
            if (selParrots.Text == "Oliver")
            {
                //displays information about the specifically selected parrot.
                parName.Text = "This parrots name is: " + MainMenu.parrots[0].AniName;
                parName.Show();
                parAge.Text = MainMenu.parrots[0].AniName + " is " + MainMenu.parrots[0].AniAge + " years old.";
                parAge.Show();
                parGen.Text = MainMenu.parrots[0].AniName + " is " + MainMenu.parrots[0].AniGender + ".";
                parGen.Show();
                parFcolor.Text = MainMenu.parrots[0].AniName + " has " + MainMenu.parrots[0].FeatherColor + " feathers.";
                parFcolor.Show();

                // Display the eating and sleeping behaviour of a parrot using.
                eatsPar.Text = Parrot.Eats();//eating behviour of the parrot.
                sleepPar.Text = Parrot.Sleep();//sleeping behviour of the parrot.
            }
            else if (selParrots.Text == "Mary")
            {
                parName.Text = "This parrots name is: " + MainMenu.parrots[1].AniName;
                parName.Show();
                parAge.Text = MainMenu.parrots[1].AniName + " is " + MainMenu.parrots[1].AniAge + " years old.";
                parAge.Show();
                parGen.Text = MainMenu.parrots[1].AniName + " is " + MainMenu.parrots[1].AniGender + ".";
                parGen.Show();
                parFcolor.Text = MainMenu.parrots[1].AniName + " has " + MainMenu.parrots[1].FeatherColor + " feathers.";
                parFcolor.Show();

                eatsPar.Text = Parrot.Eats();
                sleepPar.Text = Parrot.Sleep();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes the current form.
            this.Close();
        }
    }
}
