using System.ComponentModel;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        // Variables
        bool turn = true;
        int turn_count = 0;
        string p1Name;
        string p2Name;
        string p1Symbol;
        string p2Symbol;
        string ovlWin = "";

        // Button Arrays
        private Button[,] butt = new Button[3, 3];

        // Enables Game Buttons
        private void enableButtons()
        {
            btnTL.Enabled = true;
            btnTC.Enabled = true;
            btnTR.Enabled = true;
            btnCL.Enabled = true;
            btnCC.Enabled = true;
            btnCR.Enabled = true;
            btnBL.Enabled = true;
            btnBC.Enabled = true;
            btnBR.Enabled = true;
        }

        // Disables Game Buttons
        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                btnTL.Enabled = false;
                btnTC.Enabled = false;
                btnTR.Enabled = false;
                btnCL.Enabled = false;
                btnCC.Enabled = false;
                btnCR.Enabled = false;
                btnBL.Enabled = false;
                btnBC.Enabled = false;
                btnBR.Enabled = false;
            }
        }

        // Updates the overall winner textbox each time a new winner is added to the ListBox
        private void UpdateOverallWinner()
        {
            // Initialize counters
            int p1Count = 0;
            int p2Count = 0;
            bool isDraw = true;

            // Loops through the items in statsListBox
            foreach (var item in statsListBox.Items)
            {
                string ovlWin = item.ToString();

                // Check if the winner is player 1
                if (ovlWin == p1Name)
                {
                    p1Count++;
                    isDraw = false; // Checks if there's at least one win by p1
                }
                // Check if the winner is player 2
                else if (ovlWin == p2Name)
                {
                    p2Count++;
                    isDraw = false; //Checks if there's at least one win by p1
                }
            }

            // Deems the overall winner based on the amount of times their name appears in the listbox
            if (p1Count > p2Count)
            {
                overallWText.Text = p1Name;
            }
            else if (p2Count > p1Count)
            {
                overallWText.Text = p2Name;
            }
            else if (!isDraw)
            {
                overallWText.Text = "Draw!";
            }
            else
            {
                overallWText.Text = ""; // No winner, no draw
            }
        }


        // Checks for a winner
        private void checkForWinner()
        {
            // Initializes the winning symbol and player
            string winningSymbol = "";
            string winningPlayer = "";

            for (int i = 0; i < 3; i++)
            {
                // Horizontal Checks
                if (butt[i, 0].Text.ToLower() == butt[i, 1].Text.ToLower() && butt[i, 1].Text.ToLower() == butt[i, 2].Text.ToLower() && !butt[i, 0].Enabled)
                {
                    winningSymbol = butt[i, 0].Text.ToLower();
                    break;
                }

                // Vertical Checks
                if (butt[0, i].Text.ToLower() == butt[1, i].Text.ToLower() && butt[1, i].Text.ToLower() == butt[2, i].Text.ToLower() && !butt[0, i].Enabled)
                {
                    winningSymbol = butt[0, i].Text.ToLower();
                    break;
                }
            }

            // Diagonal Checks
            if (winningSymbol == "")
            {
                if (butt[0, 0].Text.ToLower() == butt[1, 1].Text.ToLower() && butt[1, 1].Text.ToLower() == butt[2, 2].Text.ToLower() && !butt[0, 0].Enabled)
                {
                    winningSymbol = butt[0, 0].Text.ToLower();
                }
                else if (butt[0, 2].Text.ToLower() == butt[1, 1].Text.ToLower() && butt[1, 1].Text.ToLower() == butt[2, 0].Text.ToLower() && !butt[0, 2].Enabled)
                {
                    winningSymbol = butt[0, 2].Text.ToLower();
                }
            }

            // Checks which symbol won and who owns the symbol
            if (winningSymbol != "")
            {
                if (winningSymbol == p1Symbol)
                {
                    winningPlayer = p1Name;
                }
                else
                {
                    winningPlayer = p2Name;
                }

                // Disables the game buttons, enables the continue button and updates the textboxes and listbox
                disableButtons();
                contBtn.Enabled = true;
                winnerText.Text = winningPlayer;
                statsListBox.Items.Add(winnerText.Text);
                UpdateOverallWinner();
            }

            // Draw if all games buttons are clicked
            else if (turn_count == 9)
            {
                contBtn.Enabled = true;
                disableButtons();
                winnerText.Text = "Draw";
            }
        }




        public Form1()
        {
            InitializeComponent();
            // Sets button array to the game buttons
            butt[0, 0] = btnTL;
            butt[0, 1] = btnTC;
            butt[0, 2] = btnTR;
            butt[1, 0] = btnCL;
            butt[1, 1] = btnCC;
            butt[1, 2] = btnCR;
            butt[2, 0] = btnBL;
            butt[2, 1] = btnBC;
            butt[2, 2] = btnBR;

            // Sets the overall winner text as empty so it doesn't appear as a Draw
            overallWText.Text = "";
        }

        // Resets the entire form
        private void resetBtn_Click(object sender, EventArgs e)
        {
            p1NameText.Clear();
            p1NameText.Focus();
            p2NameText.Clear();
            p1SymbolText.Clear();
            p2SymbolText.Clear();
            winnerText.Clear();
            overallWText.Clear();
            statsListBox.Items.Clear();
            currentTurnText.Clear();
            startBtn.Enabled = true;
            contBtn.Enabled = false;
            p1NameText.Enabled = true;
            p1SymbolText.Enabled = true;
            p2NameText.Enabled = true;
            p2SymbolText.Enabled = true;
            disableButtons();
            btnTL.Text = "";
            btnTC.Text = "";
            btnTR.Text = "";
            btnCL.Text = "";
            btnCC.Text = "";
            btnCR.Text = "";
            btnBL.Text = "";
            btnBC.Text = "";
            btnBR.Text = "";

        }

        // Starts the game
        private void startBtn_Click(object sender, EventArgs e)
        {
            p1Name = p1NameText.Text.ToLower();
            p2Name = p2NameText.Text.ToLower();
            p1Symbol = p1SymbolText.Text.ToLower();
            p2Symbol = p2SymbolText.Text.ToLower();
            if (p1Name == p2Name)
            {
                MessageBox.Show("Player 1 and Player 2 names cannot be the same.");
                return;
            }
            if (p1Symbol == p2Symbol)
            {
                MessageBox.Show("Player 1 and Player 2 symbols cannot be the same.");
                return;
            }

            if (p1Symbol.Length != 1 || p2Symbol.Length != 1)
            {
                MessageBox.Show("Both symbols must be exactly one character.");
                return;
            }

            // Disables the Game Setup if everything is valid
            startBtn.Enabled = false;
            p1NameText.Enabled = false;
            p1SymbolText.Enabled = false;
            p2NameText.Enabled = false;
            p2SymbolText.Enabled = false;
            enableButtons();
            currentTurnText.Text = p1Name;
        }


        // A linked click button for every button in the Game Area
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int row = -1, col = -1;

            // Finds the row and column of the clicked button
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (butt[i, j] == button)
                    {
                        row = i;
                        col = j;
                        break;
                    }
                }
            }

            if (row != -1 && col != -1)
            {
                if (button.Text == "")
                {
                    // Check whose turn it is and set the symbol to the button
                    if (turn)
                    {
                        button.Text = p1Symbol;
                        currentTurnText.Text = p2Name;
                    }
                    else
                    {
                        button.Text = p2Symbol;
                        currentTurnText.Text = p1Name;
                    }

                    // Disables the button the player has clicked
                    button.Enabled = false;
                    // Increment the turn_count
                    turn_count++;
                    // Calls to check winner
                    checkForWinner();
                    // Calls the update overall method
                    UpdateOverallWinner();
                    // Toggles the turn
                    turn = !turn;
                }
            }
        }

        // Continue Button
        private void contBtn_Click(object sender, EventArgs e)
        {
            // Resets the game buttons, the turn counter and clears the winner textbox
            turn_count = 0;
            contBtn.Enabled = false;
            winnerText.Clear();
            enableButtons();
            currentTurnText.Text = p1Name;
            btnTL.Text = "";
            btnTC.Text = "";
            btnTR.Text = "";
            btnCL.Text = "";
            btnCC.Text = "";
            btnCR.Text = "";
            btnBL.Text = "";
            btnBC.Text = "";
            btnBR.Text = "";
        }
    }
}