using System.Data.Common;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography;

namespace Pairs
{
    /* 
     Player turn
        - 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Global Variables
 
        bool gameActive = false;
        bool playerOneTurn = true;
        int cardOneNumber = -1;
        int cardTwoNumber = -2;

        private List<Image> images = new List<Image>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "images/cards")))
            {
                images.Add(Image.FromFile(file));
            }
        }
        #endregion


        #region Set board
        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBoard(6);
        }

        private void x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBoard(10);

        }

        private void x16ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetBoard(16);
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Sets board size and adds buttons randomly to the table layout pannel
        /// </summary>
        /// <param name="size"></param>
        private void SetBoard(int size)
        {
            // Initialize button array
            Button[] buttons = new Button[size * size];

            // Set up button pairs
            ButtonImageAssigner(buttons);

            // Randomize button array
            Button[] randomArray = ButtonRandomizer(buttons);

            // Set grid size to 0,0
            cardGrid.RowStyles.Clear();
            cardGrid.ColumnStyles.Clear();

            // Set max grid size to parameter size
            cardGrid.RowCount = size;
            cardGrid.ColumnCount = size;
            
            // Loop over row count and add rows/columns
            for (int i = 0; i < size; i++)
            {
                cardGrid.RowStyles.Add(new RowStyle(SizeType.Percent, (float)1 / size));
                cardGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)1 / size));
            }
            // Initialize counter
            int counter = 0;

            cardGrid.Controls.Clear();
            // Loop over table
            for (int row = 0; row < size; row++)
            {
                for(int column = 0; column < size; column++)
                {
                    // Add button to table
                    cardGrid.Controls.Add(randomArray[counter], row, column);
                    counter++;
                }
            }
        }

        /// <summary>
        /// Assigns all buttons an image, and a text Identifier
        /// </summary>
        /// <param name="buttons"></param>
        private void ButtonImageAssigner(Button[] buttons)
        {
            // Add appropriate amount of buttons to list
            for (int i = 0; i < buttons.Length; i++)
            {
                // Create button
                buttons[i] = new Button();

                // Style buttons
                buttons[i].Font = new Font(buttons[i].Font.FontFamily, 0.000001f);
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].Dock = DockStyle.Fill;

                // Make image fit correctly
                buttons[i].BackgroundImageLayout = ImageLayout.Zoom;
            }

            // While all buttons are not filled
            while (buttons[buttons.Length - 1].Text == "")
            {
                // Initialize counter
                int counter = 0;

                // Assign each button an image
                foreach (Image image in images)
                {
                    // Set pairs of cards to have the same properties
                    buttons[counter].BackgroundImage = buttons[counter + 1].BackgroundImage = image;
                    buttons[counter].Text = buttons[counter + 1].Text = counter.ToString();

                    // Increment counter by 2 to skip the partner of first card
                    counter += 2;

                    // Break out if limit reached
                    if (counter == buttons.Length)
                    {
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Takes an array and shuffles it, returning a shuffled array.
        /// </summary>
        /// <param name="buttons"></param>
        /// <returns></returns>
        private Button[] ButtonRandomizer(Button[] buttons)
        {
            // Initialize list
            List<Button> buttonsList = new List<Button>();

            // Initialize array to return
            Button[] buttonsRandomArray = new Button[buttons.Length];

            // Put initial array into list
            for(int i = 0; i < buttons.Length; i++)
            {
                buttonsList.Add(buttons[i]);
            }
            // Create new random object
            Random random = new Random();

            // Randomize array and reassign
            buttonsList = buttonsList.OrderBy(_ => random.Next()).ToList();

            // initialzie counter
            int counter = 0;

            // Put list back into array
            foreach(Button button in buttonsList)
            {
                buttonsRandomArray[counter] = button;
                counter++;
            }
            // Return shuffled array
            return buttonsRandomArray;
        }


        // private static int OnTurn(object cardOne, object cardTwo, EventArgs e)
        // {
        //     // Figure out first card to be clicked
        //     // Place first card into proper players box
        //     // Figure out second card to be clicked
        //     // Place seconds card into proper players box
        //     // Compare cards
        //     // If match, add to total matched, change card to blue and disable button
        //     // If not, return total number of cards matched
        // }
        #endregion

        #region Menu Bar Methods

        /// <summary>
        /// Loads a new instance of the game, providing names have been entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGame(object sender, EventArgs e)
        {
            // Check names entered
            if (tb_Player1.Text == "" || tb_Player2.Text == "")
            {
                // Refuse unless names entered
                MessageBox.Show("Enter player names to begin!");
                return;
            }

        }

        /// <summary>
        /// Displays a message box givibg the user information about the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pairs is a solitaire card game where" +
                " you win by removing pairs of cards with the same" +
                " rank until all cards have been removed.");
        }

        /// <summary>
        /// Saves the current game data to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveGame_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Loads the previous game from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadGame_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}