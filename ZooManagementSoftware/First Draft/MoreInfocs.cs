using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static System.Windows.Forms.DataFormats;

namespace ZooManageEncycloFA2
{
    public partial class MoreInfocs : Form
    {
        //instantiates a new sound player module
        private SoundPlayer player;
        //makes a new instance of the visitorForm. adds to the reusability.
        visitorForm visitor = new visitorForm();
        public MoreInfocs()
        {
            InitializeComponent();
            //makes a new Sound player
            player = new SoundPlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //makes new object of the infoForm form and displays it.
            var infoForm = new infoForm(visitor);
            infoForm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //makes a new objet of toe PicInfo and displays it.
            var PicInfo = new PicInfo();
            PicInfo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //"streams" the audio from the resrouces and then plays it
            player.Stream = Properties.Resources.lion_roar;
            player.Play();
        }
    }
}
