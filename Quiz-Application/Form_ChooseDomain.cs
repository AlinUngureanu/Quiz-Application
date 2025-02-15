using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class Form_ChooseDomain : Form
    {
        public Form_ChooseDomain(string strTextBox)
        {
            InitializeComponent();
            label_urare.Text = "Salutare " + strTextBox;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile("Arta.jpg");
                    pictureBox1.Size = Image.FromFile("Arta.jpg").Size;
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile("Istorie.jpg");
                    pictureBox1.Size = Image.FromFile("Istorie.jpg").Size;
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("Sport.jpg");
                    pictureBox1.Size = Image.FromFile("Sport.jpg").Size;
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("Geografie.jpg");
                    pictureBox1.Size = Image.FromFile("Geografie.jpg").Size;
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("Stiinta.jpg");
                    pictureBox1.Size = Image.FromFile("Stiinta.jpg").Size;
                    break;
            }
        }

        private void button_choose_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Form_Questions f2 = new Form_Questions(Convert.ToString(listBox1.SelectedItem));
                f2.Show();
            }
            else
            {
                MessageBox.Show("Nu ați ales nici un domeniu.", "Eroare");
            }
        }
    }
}