using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
        List<TextBox> l_words; //Creates a list containing textboxes.
        String wordToGuess; //Word to guess.
        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// Main class constructor
        /// </summary>
        public frm_Main()
        {
            InitializeComponent();
            sm_MainStick = new stickMan(6); //initiate stickMan instance with 6 lives
                                 //This type of instantiation is quite useless, the stickman can have only 6 lives, passing them by parameter has no sense.
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
            initText(); //Initializes the  default textboxes.
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
        /// Initializes the textboxes based on wordComplexity and makes them visible.
        /// </summary>
        private void initText()
        {
            l_words = new List<TextBox>(); //TextBoxes list
            for (int i = 0; i < wordComplexity; i++)
            {
                l_words.Add(new TextBox());
                l_words[i].Size = new Size(20, 20);
                l_words[i].Location = new Point(1 + (i * 21), 120);
                l_words[i].Visible = true;
                l_words[i].MaxLength = 1;
                this.Controls.Add(l_words[i]);
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
        /// Checks if the string is correct.
        /// </summary>
        private void checkString()
        {
            StringBuilder sb = new StringBuilder(); //Creates a StringBuilder object.

            for (int i = 0; i < wordComplexity; i++)
            {
                sb.Append(l_words[i].Text);
            }
            if (sb.ToString().ToUpper().Equals(wordToGuess))
            {
                gm_Victory();
            }
            else
            {
                sm_MainStick.sLifes--;
            }
        }

        /// <summary>
        /// Resets everything.
        /// </summary>
        private void gm_Reset()
        {
            foreach (TextBox words in l_words)
            {
                words.Dispose();
            };
            //Disposes all the textboxes in the list.
            this.Invalidate();
            pb_BackGround.Invalidate();
            sm_MainStick.sLifes = 6; //Resets the lifes.
            genWord(); //Calls the method that generates a word.   
            randString(); //Calls the method that selects a random string from the file.
            initText(); 
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
        #endregion
    }
}