namespace ZooManageEncycloFA2
{
    public partial class infoForm : Form
    {
        public infoForm(visitorForm Visitorsform)
        {
            InitializeComponent();
            //for future use. Is intended to allow for the reuse of the more info and related forms.
            string selectedAnimals = Visitorsform.AnimalSelected;
            infoLionLab.Text = selectedAnimals;

            if (selectedAnimals == "Lions")
            {
                //get the info from the lion class and display it.
                infoLionLab.Text = Lion.lionInfo();
                infoLionLab.Show();
            }
            else if (selectedAnimals == "Parrots")
            {
                //get the info from the parrot class and display it.
                infoLionLab.Text = Parrot.ParrotInfo();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes this specific window.
            this.Close();
        }
    }
}
