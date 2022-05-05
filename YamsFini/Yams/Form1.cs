using System;
using System.Windows.Forms;
using YamsClassLibrary;

namespace Yams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (textBox_joueur1.Text != "" && textBox_joueur2.Text != "")
            {
                Joueur joueur1 = new Joueur(textBox_joueur1.Text);
                Joueur joueur2 = new Joueur(textBox_joueur2.Text);

                Form2 form2 = new Form2(joueur1, joueur2, this);
                form2.Show();
                this.Hide();
            }
            else
            {
                if (textBox_joueur1.Text == "" && textBox_joueur2.Text == "")
                {
                    label_warning.Text = "Veuillez entrer un nom à chaque joueur";
                }
                else if (textBox_joueur1.Text == "")
                {
                    label_warning.Text = "Veuillez entrer un nom au joueur 1";
                }
                else if (textBox_joueur2.Text == "")
                {
                    label_warning.Text = "Veuillez entrer un nom au joueur 2";
                }
            }
        }
    }
}
