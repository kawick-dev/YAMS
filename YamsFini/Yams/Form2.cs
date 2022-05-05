using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using YamsClassLibrary;

namespace Yams
{
    public partial class Form2 : Form
    {
        /* =================== Variable Global =================== */
        Form1 form1;

        Joueur joueur1;
        Joueur joueur2;

        Dés des1 = new Dés();
        Dés des2 = new Dés();
        Dés des3 = new Dés();
        Dés des4 = new Dés();
        Dés des5 = new Dés();

        List<int> faceSelectedList = new List<int>();

        int currentPlayer = 1;
        int desSelected = 0;
        int nbLance = 0;



    /* =================== Initialize =================== */
        public Form2(Joueur joueur1, Joueur joueur2, Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;

            this.joueur1 = joueur1;
            this.joueur2 = joueur2;

            /* ----- Datagrid content ----- */
            foreach (var itemJoueur1 in joueur1.Combiniason)
            {
                yamsGrid.Rows.Add(itemJoueur1.Key, "", "");
            }
            /* ----- Datagrid style ----- */
            yamsGrid.Columns[1].HeaderText = joueur1.Nom;
            yamsGrid.Columns[2].HeaderText = joueur2.Nom;
            for (int i= 0 ; i< yamsGrid.Rows.Count; i++)
            {
                if (yamsGrid.Rows[i].Cells[0].Value.ToString() == "Somme" || yamsGrid.Rows[i].Cells[0].Value.ToString() == "Bonus" || yamsGrid.Rows[i].Cells[0].Value.ToString() == "Total")
                {
                    yamsGrid.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    yamsGrid.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    yamsGrid.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                }

                if (i != 6 && i != 7 && i != 15)
                {
                    yamsGrid.Rows[i].Cells[1].Style.BackColor = Color.LightGreen;
                    yamsGrid.Rows[i].Cells[2].Style.BackColor = Color.White;
                    yamsGrid.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                    yamsGrid.Rows[i].Cells[2].Style.ForeColor = Color.Red;
                }

                ((DataGridViewButtonCell)yamsGrid.Rows[i].Cells[1]).FlatStyle = FlatStyle.Flat;
                ((DataGridViewButtonCell)yamsGrid.Rows[i].Cells[2]).FlatStyle = FlatStyle.Flat;
                yamsGrid.Rows[0].Cells[0].Selected = false;
            }

            /* ----- Nom joueur ----- */
            label_joueur1.Text = joueur1.Nom;
            label_joueur2.Text = joueur2.Nom;

            /* ----- Reset Joueur Dictionary ----- */
            for (int i = 0; i < yamsGrid.Rows.Count; i++)
            {
                joueur1.Combiniason[yamsGrid.Rows[i].Cells[0].Value.ToString()] = -1;
                joueur2.Combiniason[yamsGrid.Rows[i].Cells[0].Value.ToString()] = -1;
            }
        }



    /* =================== Function =================== */
        /* ------------------- Refresh Dice Affichage ------------------- */
        private void refreshAffichageDice()
        {
            if (des1.Selected)
            {
                if(currentPlayer == 1)
                {
                    panel_des1.Location = new Point(175, 63);
                }
                else
                {
                    panel_des1.Location = new Point(36, 584);
                }
            }
            else
            {
                panel_des1.Location = new Point(93, 310);
            }
            if (des2.Selected)
            {
                if (currentPlayer == 1)
                {
                    panel_des2.Location = new Point(280, 63);
                }
                else
                {
                    panel_des2.Location = new Point(141, 584);
                }
            }
            else
            {
                panel_des2.Location = new Point(203, 310);
            }
            if (des3.Selected)
            {
                if (currentPlayer == 1)
                {
                    panel_des3.Location = new Point(385, 63);
                }
                else
                {
                    panel_des3.Location = new Point(246, 584);
                }
            }
            else
            {
                panel_des3.Location = new Point(313, 310);
            }
            if (des4.Selected)
            {
                if (currentPlayer == 1)
                {
                    panel_des4.Location = new Point(490, 63);
                }
                else
                {
                    panel_des4.Location = new Point(351, 584);
                }
            }
            else
            {
                panel_des4.Location = new Point(423, 310);
            }
            if (des5.Selected)
            {
                if (currentPlayer == 1)
                {
                    panel_des5.Location = new Point(595, 63);
                }
                else
                {
                    panel_des5.Location = new Point(456, 584);
                }
            }
            else
            {
                panel_des5.Location = new Point(533, 310);
            }

            if (des1.Selected && des2.Selected && des3.Selected && des4.Selected && des5.Selected)
            {
                button_throwDice.Enabled = false;
            }
            else
            {
                button_throwDice.Enabled = true;
            }
        }

        /* ------------------- Switch Player ------------------- */
        private void switchPlayer()
        {
            if(currentPlayer == 1)
            {
                label_joueurActuel.Text = "Joueur 2, à toi de jouer";
                currentPlayer = 2;
            }
            else
            {
                label_joueurActuel.Text = "Joueur 1, à toi de jouer";
                currentPlayer = 1;
            }

            for (int i = 0; i < yamsGrid.Rows.Count; i++)
            {
                if(yamsGrid.Rows[i].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[i].Cells[1].Value = "";
                }
                if (yamsGrid.Rows[i].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[i].Cells[2].Value = "";
                }

                if(currentPlayer == 1)
                {
                    if (i != 6 && i != 7 && i != 15) {
                        yamsGrid.Rows[i].Cells[1].Style.BackColor = Color.LightGreen;
                        yamsGrid.Rows[i].Cells[2].Style.BackColor = Color.White;
                    }
                }
                else
                {
                    if (i != 6 && i != 7 && i != 15)
                    {
                        yamsGrid.Rows[i].Cells[1].Style.BackColor = Color.White;
                        yamsGrid.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;
                    }
                }
            }

            button_throwDice.Visible = true;
            button_throwDice.Location = new Point(253, 335);

            panel_des1.Visible = false;
            panel_des2.Visible = false;
            panel_des3.Visible = false;
            panel_des4.Visible = false;
            panel_des5.Visible = false;
            des1.Selected = false;
            des2.Selected = false;
            des3.Selected = false;
            des4.Selected = false;
            des5.Selected = false;
            refreshAffichageDice();
        }

        /* ------------------- Point Preview ------------------- */
        private void pointPreview()
        {
            faceSelectedList.Clear();
            faceSelectedList.Add(des1.CurrentFace);
            faceSelectedList.Add(des2.CurrentFace);
            faceSelectedList.Add(des3.CurrentFace);
            faceSelectedList.Add(des4.CurrentFace);
            faceSelectedList.Add(des5.CurrentFace);

            int one = 0;
            int oneCount = 0;
            int two = 0;
            int twoCount = 0;
            int three = 0;
            int threeCount = 0;
            int four = 0;
            int fourCount = 0;
            int five = 0;
            int fiveCount = 0;
            int six = 0;
            int sixCount = 0;

            foreach (int face in faceSelectedList)
            {
                if(face == 1)
                {
                    one++;
                    oneCount += 1;
                }
                else if (face == 2)
                {
                    two++;
                    twoCount += 2;
                }
                else if (face == 3)
                {
                    three++;
                    threeCount += 3;
                }
                else if (face == 4)
                {
                    four++;
                    fourCount += 4;
                }
                else if (face == 5)
                {
                    five++;
                    fiveCount += 5;
                }
                else if (face == 6)
                {
                    six++;
                    sixCount += 6;
                }
            }

            /* ----- Un ----- */
            if (one != 0)
            {
                if(currentPlayer == 1 && yamsGrid.Rows[0].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[0].Cells[1].Value = oneCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[0].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[0].Cells[2].Value = oneCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[0].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[0].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[0].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[0].Cells[2].Value = "";
                }
            }
            /* ----- Deux ----- */
            if (two != 0)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[1].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[1].Cells[1].Value = twoCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[1].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[1].Cells[2].Value = twoCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[1].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[1].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[1].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[1].Cells[2].Value = "";
                }
            }
            /* ----- Trois ----- */
            if (three != 0)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[2].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[2].Cells[1].Value = threeCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[2].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[2].Cells[2].Value = threeCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[2].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[2].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[2].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[2].Cells[2].Value = "";
                }
            }
            /* ----- Quatre ----- */
            if (four != 0)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[3].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[3].Cells[1].Value = fourCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[3].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[3].Cells[2].Value = fourCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[3].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[3].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[3].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[3].Cells[2].Value = "";
                }
            }
            /* ----- Cinq ----- */
            if (five != 0)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[4].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[4].Cells[1].Value = fiveCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[4].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[4].Cells[2].Value = fiveCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[4].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[4].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[4].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[4].Cells[2].Value = "";
                }
            }
            /* ----- Six ----- */
            if (six != 0)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[5].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[5].Cells[1].Value = sixCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[5].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[5].Cells[2].Value = sixCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[5].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[5].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[5].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[5].Cells[2].Value = "";
                }
            }

            /* ----- Brelan ----- */
            if (one >= 3)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "3";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "3";
                }
            }
            else if (two >= 3)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "6";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "6";
                }
            }
            else if (three >= 3)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "9";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "9";
                }
            }
            else if (four >= 3)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "12";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "12";
                }
            }
            else if (five >= 3)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "15";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "15";
                }
            }
            else if (six >= 3)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "18";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "18";
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[8].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[8].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[8].Cells[2].Value = "";
                }
            }

            /* ----- Carré ----- */
            if (one >= 4)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "4";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "4";
                }
            }
            else if (two >= 4)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "8";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "8";
                }
            }
            else if (three >= 4)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "12";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "12";
                }
            }
            else if (four >= 4)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "16";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "16";
                }
            }
            else if (five >= 4)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "20";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "20";
                }
            }
            else if (six >= 4)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "24";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "24";
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[9].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[9].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[9].Cells[2].Value = "";
                }
            }

            /* ----- Petite Suite ----- */
            if (one == 3 || two == 3 || three == 3 || four == 3 || five == 3 || six == 3)
            {
                if (one == 2 || two == 2 || three == 2 || four == 2 || five == 2 || six == 2)
                {
                    if (currentPlayer == 1 && yamsGrid.Rows[10].Cells[1].Style.ForeColor == Color.Red)
                    {
                        yamsGrid.Rows[10].Cells[1].Value = "25";
                    }
                    else if (currentPlayer == 2 && yamsGrid.Rows[10].Cells[2].Style.ForeColor == Color.Red)
                    {
                        yamsGrid.Rows[10].Cells[2].Value = "25";
                    }
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[10].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[10].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[10].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[10].Cells[2].Value = "";
                }
            }

            /* ----- Petite Suite ----- */
            if (one >= 1 && two >= 1 && three >= 1 && four >= 1 || two >= 1 && three >= 1 && four >= 1 && five >= 1 ||  three >= 1 && four >= 1 && five >= 1 && six >= 1)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[11].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[11].Cells[1].Value = "30";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[11].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[11].Cells[2].Value = "30";
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[12].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[12].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[12].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[12].Cells[2].Value = "";
                }
            }

            /* ----- Grande Suite ----- */
            if (one >= 1 && two >= 1 && three >= 1 && four >= 1 && five >= 1 || two >= 1 && three >= 1 && four >= 1 && five >= 1 && six >= 1)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[12].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[12].Cells[1].Value = "40";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[12].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[12].Cells[2].Value = "40";
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[12].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[12].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[12].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[12].Cells[2].Value = "";
                }
            }

            /* ----- Chance ----- */
            if (currentPlayer == 1 && yamsGrid.Rows[13].Cells[1].Style.ForeColor == Color.Red)
            {
                yamsGrid.Rows[13].Cells[1].Value = (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount).ToString();
            }
            else if (currentPlayer == 2 && yamsGrid.Rows[13].Cells[2].Style.ForeColor == Color.Red)
            {
                yamsGrid.Rows[13].Cells[2].Value = (oneCount + twoCount + threeCount + fourCount + fiveCount + sixCount).ToString();
            }

            /* ----- Yams ----- */
            if (one == 5)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = oneCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = oneCount.ToString();
                }
            }
            else if (two == 5)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = twoCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = twoCount.ToString();
                }
            }
            else if (three == 5)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = threeCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = threeCount.ToString();
                }
            }
            else if (four == 5)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = fourCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = fourCount.ToString();
                }
            }
            else if (five == 5)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = fiveCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = fiveCount.ToString();
                }
            }
            else if (six == 5)
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = sixCount.ToString();
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = sixCount.ToString();
                }
            }
            else
            {
                if (currentPlayer == 1 && yamsGrid.Rows[14].Cells[1].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[1].Value = "";
                }
                else if (currentPlayer == 2 && yamsGrid.Rows[14].Cells[2].Style.ForeColor == Color.Red)
                {
                    yamsGrid.Rows[14].Cells[2].Value = "";
                }
            }
        }

        /* ------------------- Test Full Grid ------------------- */
        private bool testFullGrid()
        {
            bool gridFull = true;
            for (int i = 0; i < yamsGrid.Rows.Count; i++)
            {
                if(i != 6 && i != 7 && i != 15)
                {
                    if (yamsGrid.Rows[i].Cells[1].Value.ToString() == "")
                    {
                        gridFull = false;
                    }
                    if (yamsGrid.Rows[i].Cells[2].Value.ToString() == "")
                    {
                        gridFull = false;
                    }
                }
            }
            return gridFull;
        }



    /* =================== Event =================== */
        /* ------------------- YamsGrid Event ------------------- */
        private void yamsGrid_SelectionChanged(object sender, EventArgs e)
        {
            yamsGrid.ClearSelection();
        }
        private void yamsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == 0)
            {
                return;
            }
            else
            {
                if (currentPlayer == 1 && e.ColumnIndex == 1 || currentPlayer == 2 && e.ColumnIndex == 2)
                {
                    if (yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString() != "Somme" && yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString() != "Bonus" && yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString() != "Total")
                    {
                        if (yamsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor == Color.Red)
                        {
                            DataGridViewCell cell = (DataGridViewCell)yamsGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

                            if (cell.Value.ToString() == "")
                            {
                                cell.Style.ForeColor = Color.Black;
                                cell.Value = "0";
                                if(currentPlayer == 1)
                                {
                                    joueur1.Combiniason[yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()] = 0;
                                }
                                else
                                {
                                    joueur2.Combiniason[yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()] = 0;
                                }
                            }
                            else
                            {
                                cell.Style.ForeColor = Color.Black;
                                if (currentPlayer == 1)
                                {
                                    joueur1.Combiniason[yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()] = int.Parse(cell.Value.ToString());
                                }
                                else
                                {
                                    joueur2.Combiniason[yamsGrid.Rows[e.RowIndex].Cells[0].Value.ToString()] = int.Parse(cell.Value.ToString());
                                }
                            }

                            if (testFullGrid())
                            {
                                int sommeJoueur1 = joueur1.Combiniason["Un"] + joueur1.Combiniason["Deux"] + joueur1.Combiniason["Trois"] + joueur1.Combiniason["Quatre"] + joueur1.Combiniason["Cinq"] + joueur1.Combiniason["Six"];
                                joueur1.Combiniason["Somme"] = sommeJoueur1;
                                yamsGrid.Rows[6].Cells[1].Value = sommeJoueur1.ToString();
                                if (sommeJoueur1 >= 63)
                                {
                                    joueur1.Combiniason["Bonus"] = 35;
                                    yamsGrid.Rows[7].Cells[1].Value = "35";
                                }
                                else
                                {
                                    joueur1.Combiniason["Bonus"] = 0;
                                    yamsGrid.Rows[7].Cells[1].Value = "0";
                                }
                                int totalJoueur1 = 0;
                                int index = 0;
                                foreach(int value in joueur1.Combiniason.Values)
                                {
                                    if(value >= 0 && index != 6)
                                    {
                                        totalJoueur1 += value;
                                    }
                                    index++;
                                }
                                joueur1.Combiniason["Total"] = totalJoueur1;
                                yamsGrid.Rows[15].Cells[1].Value = totalJoueur1.ToString();

                                int sommeJoueur2 = joueur2.Combiniason["Un"] + joueur2.Combiniason["Deux"] + joueur2.Combiniason["Trois"] + joueur2.Combiniason["Quatre"] + joueur2.Combiniason["Cinq"] + joueur2.Combiniason["Six"];
                                joueur2.Combiniason["Somme"] = sommeJoueur2;
                                yamsGrid.Rows[6].Cells[2].Value = sommeJoueur2.ToString();
                                if (sommeJoueur2 >= 63)
                                {
                                    joueur2.Combiniason["Bonus"] = 35;
                                    yamsGrid.Rows[7].Cells[2].Value = "35";
                                }
                                else
                                {
                                    joueur2.Combiniason["Bonus"] = 0;
                                    yamsGrid.Rows[7].Cells[2].Value = "0";
                                }
                                int totalJoueur2 = 0;
                                index = 0;
                                foreach (int value in joueur2.Combiniason.Values)
                                {
                                    if (value >= 0 && index != 6)
                                    {
                                        totalJoueur2 += value;
                                    }
                                    index++;
                                }
                                joueur2.Combiniason["Total"] = totalJoueur2;
                                yamsGrid.Rows[15].Cells[2].Value = totalJoueur2.ToString();

                                for (int i = 0; i < yamsGrid.Rows.Count; i++)
                                {
                                    if(i != 6 && i != 7 && i != 15)
                                    {
                                        yamsGrid.Rows[i].Cells[1].Style.BackColor = Color.White;
                                        yamsGrid.Rows[i].Cells[2].Style.BackColor = Color.White;
                                    }
                                }

                                label_textJoueur1.Visible = false;
                                label_joueur1.Visible = false;
                                label_textJoueur2.Visible = false;
                                label_joueur2.Visible = false;

                                panel_des1.Visible = false;
                                panel_des2.Visible = false;
                                panel_des3.Visible = false;
                                panel_des4.Visible = false;
                                panel_des5.Visible = false;

                                button_throwDice.Visible = false;
                                button_replay.Visible = true;
                                button_back.Visible = true;

                                if(totalJoueur1 > totalJoueur2)
                                {
                                    label_joueurActuel.Text = joueur1.Nom + " a gagné.";
                                }
                                else if (totalJoueur1 < totalJoueur2)
                                {
                                    label_joueurActuel.Text = joueur2.Nom + " a gagné.";
                                }
                                else
                                {
                                    label_joueurActuel.Text = "match null";
                                }
                            }
                            else
                            {
                                switchPlayer();
                                nbLance = 0;
                            }
                        }
                    }
                }
            }
        }

        /* ------------------- Bouton Lancer Event ------------------- */
        private void button_throwDice_Click(object sender, EventArgs e)
        {
            if (nbLance < 4)
            {
                if (!des1.Selected)
                {
                    int faceNumber1 = des1.getRandomFaces();
                    if (faceNumber1 == 1)
                    {
                        panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés1;
                    }
                    else if (faceNumber1 == 2)
                    {
                        panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés2;
                    }
                    else if (faceNumber1 == 3)
                    {
                        panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés3;
                    }
                    else if (faceNumber1 == 4)
                    {
                        panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés4;
                    }
                    else if (faceNumber1 == 5)
                    {
                        panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés5;
                    }
                    else if (faceNumber1 == 6)
                    {
                        panel_des1.BackgroundImage = global::Yams.Properties.Resources.Dés6;
                    }
                }
                if (!des2.Selected)
                {
                    int faceNumber2 = des2.getRandomFaces();
                    if (faceNumber2 == 1)
                    {
                        panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés1;
                    }
                    else if (faceNumber2 == 2)
                    {
                        panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés2;
                    }
                    else if (faceNumber2 == 3)
                    {
                        panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés3;
                    }
                    else if (faceNumber2 == 4)
                    {
                        panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés4;
                    }
                    else if (faceNumber2 == 5)
                    {
                        panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés5;
                    }
                    else if (faceNumber2 == 6)
                    {
                        panel_des2.BackgroundImage = global::Yams.Properties.Resources.Dés6;
                    }
                }
                if (!des3.Selected)
                {
                    int faceNumber3 = des3.getRandomFaces();
                    if (faceNumber3 == 1)
                    {
                        panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés1;
                    }
                    else if (faceNumber3 == 2)
                    {
                        panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés2;
                    }
                    else if (faceNumber3 == 3)
                    {
                        panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés3;
                    }
                    else if (faceNumber3 == 4)
                    {
                        panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés4;
                    }
                    else if (faceNumber3 == 5)
                    {
                        panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés5;
                    }
                    else if (faceNumber3 == 6)
                    {
                        panel_des3.BackgroundImage = global::Yams.Properties.Resources.Dés6;
                    }
                }
                if (!des4.Selected)
                {
                    int faceNumber4 = des4.getRandomFaces();
                    if (faceNumber4 == 1)
                    {
                        panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés1;
                    }
                    else if (faceNumber4 == 2)
                    {
                        panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés2;
                    }
                    else if (faceNumber4 == 3)
                    {
                        panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés3;
                    }
                    else if (faceNumber4 == 4)
                    {
                        panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés4;
                    }
                    else if (faceNumber4 == 5)
                    {
                        panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés5;
                    }
                    else if (faceNumber4 == 6)
                    {
                        panel_des4.BackgroundImage = global::Yams.Properties.Resources.Dés6;
                    }
                }
                if (!des5.Selected)
                {
                    int faceNumber5 = des5.getRandomFaces();
                    if (faceNumber5 == 1)
                    {
                        panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés1;
                    }
                    else if (faceNumber5 == 2)
                    {
                        panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés2;
                    }
                    else if (faceNumber5 == 3)
                    {
                        panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés3;
                    }
                    else if (faceNumber5 == 4)
                    {
                        panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés4;
                    }
                    else if (faceNumber5 == 5)
                    {
                        panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés5;
                    }
                    else if (faceNumber5 == 6)
                    {
                        panel_des5.BackgroundImage = global::Yams.Properties.Resources.Dés6;
                    }
                }

                panel_des1.Visible = true;
                panel_des2.Visible = true;
                panel_des3.Visible = true;
                panel_des4.Visible = true;
                panel_des5.Visible = true;

                button_throwDice.Location = new Point(253, 430);

                pointPreview();

                if (nbLance == 2)
                {
                    button_throwDice.Visible = false;
                }
            }
            nbLance++;
        }

        /* ------------------- Bouton Rejouer Event ------------------- */
        private void button_replay_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2(joueur1, joueur2, form1);
            form2.Show();
        }

        /* ------------------- Bouton Retour Event ------------------- */
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        /* ------------------- Dice Click Event ------------------- */
        private void panel_des1_Click(object sender, EventArgs e)
        {
            if (des1.Selected)
            {
                des1.Selected = false;
                desSelected--;
            }
            else
            {
                des1.Selected = true;
                desSelected++;
            }
            refreshAffichageDice();
        }
        private void panel_des2_Click(object sender, EventArgs e)
        {
            if (des2.Selected)
            {
                des2.Selected = false;
                desSelected--;
            }
            else
            {
                des2.Selected = true;
                desSelected++;
            }
            refreshAffichageDice();
        }
        private void panel_des3_Click(object sender, EventArgs e)
        {
            if (des3.Selected)
            {
                des3.Selected = false;
                desSelected--;
            }
            else
            {
                des3.Selected = true;
                desSelected++;
            }
            refreshAffichageDice();
        }
        private void panel_des4_Click(object sender, EventArgs e)
        {
            if (des4.Selected)
            {
                des4.Selected = false;
                desSelected--;
            }
            else
            {
                des4.Selected = true;
                desSelected++;
            }
            refreshAffichageDice();
        }
        private void panel_des5_Click(object sender, EventArgs e)
        {
            if (des5.Selected)
            {
                des5.Selected = false;
                desSelected--;
            }
            else
            {
                des5.Selected = true;
                desSelected++;
            }
            refreshAffichageDice();
        }
    }
}
