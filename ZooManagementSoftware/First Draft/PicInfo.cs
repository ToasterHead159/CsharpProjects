using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManageEncycloFA2
{
    public partial class PicInfo : Form
    {
        public PicInfo()
        {
            InitializeComponent();
            //gets the picture from the solutions resrouces and displays in in the pictureBox.
            pictureBox1.Image = Properties.Resources.LionPic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //closes the current form.
            this.Close();
        }
    }
}
