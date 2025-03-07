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
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
            //gives the last button its title.
            TickManBtn.Text = "Ticket Management";
        }

        private void addAnibtn1_Click(object sender, EventArgs e)
        {
            //when add animal button is clicked it makes an instance of the notification and displays it
            var notify = new Notify();
            notify.ShowDialog();
        }

        private void TickManBtn_Click(object sender, EventArgs e)
        {
            var tickets = new Prices();
            tickets.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //when add animal button is clicked it makes an instance of the move animals and displays it
            MoveAnimal moveAnimal = new MoveAnimal();
            moveAnimal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var notify = new Notify();
            notify.ShowDialog();
        }
    }
}
