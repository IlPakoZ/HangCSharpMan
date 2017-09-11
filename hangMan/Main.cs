﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangMan
{
    public partial class frm_Main : Form
    {
        //This region contains the variables declaration and the constructor.
        #region BaseThing

        // Declaration ---------------------------------------------------------------------------------
        stickMan sm_MainStick; //Creates a new stickman! 
        int wordComplexity; //Indicates the complexity of the word, aka the number of its characters.
        int ltrPoints = 0; //Indicates how many letter you have guessed.
        String wordToGuess; //Word to guess.
        List<Label> l_labels; //List of labels.
        SoundPlayer player;
        List<char> l_insertedChars; //All inserted chars
        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// Main class constructor
        /// </summary>
        public frm_Main()
        {
            InitializeComponent();
            sm_MainStick = new stickMan(6); //initiate stickMan instance with 6 lives
            genWord(); //Calls the method that generates a word.   
            randString(); //Calls the method that selects a random string from the file.
        }
        #endregion

        //This region contains all the event handling methods.
        #region EventHandling

        /// <summary>
        /// Main_Load event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            initLabels();
        }

        /// <summary>
        /// backGround_Paint event handler (paints the background of the Hangman's reserved picturebox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backGround_Paint(object sender, PaintEventArgs e)
        {
            Graphics g_bg = e.Graphics;

            //This region contains all the drawing operations regarding the hangman's parts in a switch case statement.
            #region Lifes switch
            switch (sm_MainStick.sLifes)
            {
                case 6:
                    sm_MainStick.drawHang(g_bg);
                    break;
                case 5:
                    sm_MainStick.drawHang(g_bg);
                    sm_MainStick.drawHead(g_bg);
                    break;
                case 4:
                    sm_MainStick.drawHang(g_bg);
                    sm_MainStick.drawHead(g_bg);
                    sm_MainStick.drawBody(g_bg);
                    break;
                case 3:
                    sm_MainStick.drawHang(g_bg);
                    sm_MainStick.drawHead(g_bg);
                    sm_MainStick.drawBody(g_bg);
                    sm_MainStick.drawRightArm(g_bg);
                    break;
                case 2:
                    sm_MainStick.drawHang(g_bg);
                    sm_MainStick.drawHead(g_bg);
                    sm_MainStick.drawBody(g_bg);
                    sm_MainStick.drawRightArm(g_bg);
                    sm_MainStick.drawLeftArm(g_bg);
                    break;
                case 1:
                    sm_MainStick.drawHang(g_bg);
                    sm_MainStick.drawHead(g_bg);
                    sm_MainStick.drawBody(g_bg);
                    sm_MainStick.drawRightArm(g_bg);
                    sm_MainStick.drawLeftArm(g_bg);
                    sm_MainStick.drawRightLeg(g_bg);
                    break;
                case 0:
                    sm_MainStick.drawHang(g_bg);
                    sm_MainStick.drawHead(g_bg);
                    sm_MainStick.drawBody(g_bg);
                    sm_MainStick.drawRightArm(g_bg);
                    sm_MainStick.drawLeftArm(g_bg);
                    sm_MainStick.drawRightLeg(g_bg);
                    sm_MainStick.drawLeftLeg(g_bg);
                    gm_Defeat();
                    break;
            }
            #endregion
        }

        /// <summary>
        /// check_Click Event Handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_Click(object sender, EventArgs e)
        {
            checkString(); 
            pb_BackGround.Invalidate();
        }

        /// <summary>
        /// ltr_Check_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ltr_Check_Click(object sender, EventArgs e)
        {
            checkLtrString();
            pb_BackGround.Invalidate();
        }

        /// <summary>
        /// resetButton_Click Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            gm_Reset();
        }

        /// <summary>
        /// musicCheck_CheckedChanged Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                Musica();
                box.Image = hangMan.Properties.Resources.stateOn;
                box.Invalidate();
            }
            else
            {
                player.Stop();
                box.Image = hangMan.Properties.Resources.stateOff;
                box.Invalidate();
            }
        }
        #endregion

        //This region contains all the methods that handle the game management section of the program.
        #region GameManagement

        /// <summary>
        /// Generates a random word.
        /// </summary>
        private void genWord()
        {
            Random rand = new Random();
            wordComplexity = rand.Next(3, 9); //Il massimo è esclusivo, quindi i valori sono comunque da 3 a 8 
        }

        /// <summary>
        /// Initializes the list of labels based on the word complexity.
        /// </summary>
        private void initLabels()
        {
            int j;
            l_labels = new List<Label>(); //Labels list
            for (int i = 0; i < wordComplexity; i++)
            {
                l_labels.Add(new Label());
                l_labels[i].Size = new Size(20, 20);
                l_labels[i].Location = new Point(12 + (i * 20), 90);
                l_labels[i].Visible = true;
                l_labels[i].Text = "_";
                this.Controls.Add(l_labels[i]);
            }
            j = new Random().Next(0, wordComplexity); //+1 cause the max value is esclusive 
            l_labels[j].Text = wordToGuess[j].ToString();
            l_insertedChars = new List<char>();
            //If it's the only letter in the word, add the letter in the list.
            int count = 0;
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == wordToGuess[j])
                {
                    count++;
                }
            }
            if (count == 1)
            {
                l_insertedChars.Add(wordToGuess[j]);
            }
        }

        /// <summary>
        /// Defeat method, called when you lose.
        /// </summary>
        private void gm_Defeat()
        {
            MessageBox.Show("Fai schifo");
            gm_Reset();
        }

        /// <summary>
        /// Victory method, called when you win.
        /// </summary>
        private void gm_Victory()
        {
            MessageBox.Show("Brav");
            gm_Reset();
        }

        /// <summary>
        /// Check if the string is correct (for the entire word).
        /// </summary>
        private void checkString()
        {
            if (l_word.Text.ToUpper().Equals(wordToGuess))
            {
                for (int i = 0; i < wordComplexity; i++)
                {
                    l_labels[i].Text = wordToGuess[i].ToString();
                    l_labels[i].Invalidate();
                }
                gm_Victory();
            }
            else
            {
                sm_MainStick.sLifes--;
            }
        }

        /// <summary>
        /// Checks if the string is correct (for the single char).
        /// </summary>
        private void checkLtrString()
        {
            char x = s_word.Text[0];
            bool alreadyInserted = false;
            bool guessed = false;

            for (int i = 0; i < l_insertedChars.Count(); i++)
            {
                if (x == l_insertedChars[i])
                {
                    alreadyInserted = true;
                    break;
                }
            }
            if (!alreadyInserted)
            {
                l_insertedChars.Add(x);
                for (int j = 0; j < wordToGuess.Length; j++)
                {
                    if (x == wordToGuess[j])
                    {
                        l_labels[j].Text = x.ToString().ToUpper();
                        guessed = true;
                    }
                }
            }
            if (!guessed)
            {
                sm_MainStick.sLifes--;
            }
            String word = null;
            for(int i = 0; i < l_labels.Count; i++)
            {
                word += l_labels[i].Text;
            }
            if (word.ToLower() == wordToGuess.ToLower())
            {
                gm_Victory();
            }
        }

        /// <summary>
        /// Resets everything.
        /// </summary>
        private void gm_Reset()
        {
            foreach (Label label in l_labels)
            {
                label.Dispose();
            };
            //Disposes all the textboxes in the list.
            this.Invalidate();
            pb_BackGround.Invalidate();
            sm_MainStick.sLifes = 6; //Resets the lifes.
            genWord(); //Calls the method that generates a word.   
            randString(); //Calls the method that selects a random string from the file.
            initLabels();
            ltrPoints = 0;
            this.Invalidate();
            pb_BackGround.Invalidate();
        }

        /// <summary>
        /// Selects a random string from a text files.
        /// </summary>
        private void randString()
        {
            List<string> l_Strings = new List<string>(); //è una lista operchè ho intenzione di fare altro in futuro...
            Random rand = new Random();
            foreach (String parola_temp in LoadString.loadFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Insert(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Length, "//Stringhe.txt")))
            {
                if (parola_temp.Length == wordComplexity && !(parola_temp.Equals("File not found")))
                {
                    l_Strings.Add(parola_temp);
                }
            }
            if (rand.Next(1, 3) == 1)
            {
                wordToGuess = l_Strings[0];
            }
            else
            {
                wordToGuess = l_Strings[1];
            }
        }

        /// <summary>
        /// An endless loop of music.
        /// </summary>
        private void Musica()
        {
            player = new SoundPlayer(hangMan.Properties.Resources.Space_IlPakoz);
            player.PlayLooping();
        }


        #endregion

        
    }
}