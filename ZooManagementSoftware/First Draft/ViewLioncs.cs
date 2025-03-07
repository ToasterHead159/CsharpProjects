using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ZooManageEncycloFA2
{
    public partial class ViewLions : Form
    {
        string selectedAnimals;
        public ViewLions()
        {
            InitializeComponent();
            //this assigns the text in animal eats to the label
            EatsLab.Text = Animals.Eats();
            sleepLab1.Text = Animals.Sleep();
            
        }

        private void lionChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this if statement checks if which lions is selected by the user.
            if (lionChoice.Text == "Peter")
            {
                //displays information about the specifically selected parrot.
                lionNamelab.Text = "This lions name is: " + MainMenu.oldlions[0].AniName + ".";
                lionNamelab.Show();
                lionAgelab.Text = "He is " + MainMenu.oldlions[0].AniAge + " years old.";
                lionAgelab.Show();
                lionGenderlab.Text = "Peter is a " + MainMenu.oldlions[0].AniGender + " lion.";
                lionGenderlab.Show();
                bool checkHasMane = MainMenu.oldlions[0].HasMane;
                if (checkHasMane == true)
                {
                    lionHasManelab.Text = MainMenu.oldlions[0].AniName + " lion has a big mane!";
                }
                else
                {
                    lionHasManelab.Text = MainMenu.oldlions[1].AniName + " lion has no mane!";
                }
                lionHasManelab.Show();
                // Display the eating and sleeping behaviour of a lion.
                EatsLab.Text = Lion.Eats();//eating behaviour of a lion.
                sleepLab1.Text = Lion.Sleep();//sleeping behaviour of a lion.
            }
            else if (lionChoice.Text == "Lucy")
            {
                lionNamelab.Text = "This lions name is: " + MainMenu.oldlions[1].AniName + ".";
                lionNamelab.Show();
                lionAgelab.Text = "She is " + MainMenu.oldlions[1].AniAge + " years old.";
                lionAgelab.Show();
                lionGenderlab.Text = "Lucy is a " + MainMenu.oldlions[1].AniGender + " lion.";
                lionGenderlab.Show();
                bool checkHasMane = MainMenu.oldlions[1].HasMane;
                if (checkHasMane == true)
                {
                    lionHasManelab.Text = MainMenu.oldlions[1].AniName + " lion has a big mane!";
                }
                else
                {
                    lionHasManelab.Text = MainMenu.oldlions[1].AniName + " lion has no mane!";
                }
                lionHasManelab.Show();
                EatsLab.Text = Lion.Eats();
                sleepLab1.Text = Lion.Sleep();
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
    }
}
