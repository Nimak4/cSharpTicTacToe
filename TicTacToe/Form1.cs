using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            // Clears all the text boxes each time the user creates a new game:
            // I forgot to do this and it led to a lot of unnecesary debugging xD
            labelTicTopLeft.Text = ""; labelTicTopMid.Text = ""; labelTicTopRight.Text = "";
            labelTicMidLeft.Text = ""; labelTicMidMid.Text = ""; labelTicMidRight.Text = "";
            labelTicBotLeft.Text = ""; labelTicBotMid.Text = ""; labelTicBotRight.Text = ""; 

            // gameArray visualized (first is ROW second is COLUMN):
            // 0,0 | 0,1 | 0,2
            // 1,0 | 1,1 | 1,2
            // 2,0 | 2,1 | 2,2

            // Constants for array size, start and end of range (so we get 0 and 1 from rand)
            const int arrayWidthHeight = 3, rangeStart = 0, rangeEnd = 2;
            // initalizing a 2d array!
            int[,] gameArray = new int[arrayWidthHeight, arrayWidthHeight];

            var rand = new Random();

            // should repeat 3 times!
            for (int rowCount = 0; rowCount < arrayWidthHeight; rowCount++)
            {
                // should repeat 9 times total I hope!
                for (int colCount = 0; colCount < arrayWidthHeight; colCount++)
                {
                    // getting a random number 0-1 then adding it to the array
                    int randomNumber = rand.Next(rangeStart, rangeEnd);
                    gameArray[rowCount, colCount] = randomNumber;

                    // checking for winner!
                    string winnerFound = checkIfWinner(gameArray, rowCount, colCount);

                    //updating text boxes!
                    updateBoxes(gameArray, rowCount, colCount);

                    // if winnerFound returns a win or draw string, change the label and stop looping! I used break back when
                    // this was just one loop, but using return stops both!
                    if (winnerFound == "Owin")
                    {
                        labelWinner.Text = "O is the winner!";
                        return;
                    }
                    else if (winnerFound == "Xwin")
                    {
                        labelWinner.Text = "X is the winner!";
                        return;
                    }
                    else if (winnerFound == "DRAW")
                    {
                        labelWinner.Text = "Nobody is the winner. Sad...";
                        return;
                    }
                }
            }
        }
        private string checkIfWinner(int[,] boxesArray, int rowCount, int colCount)
        {
            // this one's a bit of a mess, i wrote out pseudocode after i worked through how I was meant to have the program
            // check for a winner each time it looped.
            // if the pseudocode doesn't line up sometimes, that's because i had to rework a couple of times when i realized
            // i wasn't accounting for X or Y winning, just if there WAS a winner or a draw.
            // So I decided to return a string instead of a bool!

            // array elements visualized ROW,COL:
            // 0,0 | 0,1 | 0,2
            // 1,0 | 1,1 | 1,2
            // 2,0 | 2,1 | 2,2

            // if there are 3 items in the array
            if (rowCount == 0 && colCount == 2)
            {
                //   check if (0,0), (0,1), (0,2) are all X or O
                //   if so, return a win condition!
                // ? | ? | ?
                // _ | _ | _
                // _ | _ | _
                if (boxesArray[0, 0] == 0 && boxesArray[0, 1] == 0 && boxesArray[0, 2] == 0)
                {
                    return "Owin";
                }
                else if (boxesArray[0, 0] == 1 && boxesArray[0, 1] == 1 && boxesArray[0, 2] == 1)
                {
                    return "Xwin";
                }
            }
            // else if there are 6 items in the array
            else if (rowCount == 1 && colCount == 2)
            {
                //   check if items (1,0), (1,1), (1,2) are all X or 0
                //   if so, return a win
                // _ | _ | _
                // ? | ? | ?
                // _ | _ | _
                if (boxesArray[1, 0] == 0 && boxesArray[1, 1] == 0 && boxesArray[1, 2] == 0)
                {
                    return "Owin";
                }
                else if (boxesArray[1, 0] == 1 && boxesArray[1, 1] == 1 && boxesArray[1, 2] == 1)
                {
                    return "Xwin";
                }
            }
            // else if there are 7 items in the array
            else if (rowCount == 2 && colCount == 0)
            {
                //    check if items (0,0), (1,0), (2,0) are all X or O OR
                //    check if items 2, 4, 6 are all X or O
                //    if so, return a win
                // ? | _ | ?
                // ? | ? | _
                // ? | _ | _
                if ((boxesArray[0, 0] == 0 && boxesArray[1, 0] == 0 && boxesArray[2, 0] == 0) ||
                    (boxesArray[0, 2] == 0 && boxesArray[1, 1] == 0 && boxesArray[2, 0] == 0))
                {
                    return "Owin";
                }
                else if ((boxesArray[0, 0] == 1 && boxesArray[1, 0] == 1 && boxesArray[2, 0] == 1) ||
                         (boxesArray[0, 2] == 1 && boxesArray[1, 1] == 1 && boxesArray[2, 0] == 1))
                {
                    return "Xwin";
                }
            }
            // else if there are 8 items in the array
            else if (rowCount == 2 && colCount == 1)
            {
                // else if there are 8 items in the array
                //    check if items (0,1), (1,1), (2,1) are all X or O
                //    if so, return a win
                // _ | ? | _
                // _ | ? | _
                // _ | ? | _
                if (boxesArray[0,1] == 0 && boxesArray[1,1] == 0 && boxesArray[2,1] == 0)
                {
                    return "Owin";
                }
                else if (boxesArray[0,1] == 1 && boxesArray[1,1] == 1 && boxesArray[2,1] == 1)
                {
                    return "Xwin";
                }
            }
            else if (rowCount == 2 && colCount == 2)
            {
                // else if there are 9 items in the array
                //    check if items (0,2), (1,2), (2,2) are all X or O
                //    check if items (0,0), (1,1), (2,2) are all X or O
                //    check if items (2,0), (2,1), (2,2) are all X or O
                //    if so, return a win
                // ? | _ | ?
                // _ | ? | ?
                // ? | ? | ?
                if  ((boxesArray[0,2] == 0 && boxesArray[1,2] == 0 && boxesArray[2,2] == 0) ||
                     (boxesArray[0,0] == 0 && boxesArray[1,1] == 0 && boxesArray[2,2] == 0) ||
                     (boxesArray[2,0] == 0 && boxesArray[2,1] == 0 && boxesArray[2,2] == 0) )
                {
                    return "Owin";
                }
                else if  ((boxesArray[0,2] == 1 && boxesArray[1,2] == 1 && boxesArray[2,2] == 1) ||
                          (boxesArray[0,0] == 1 && boxesArray[1,1] == 1 && boxesArray[2,2] == 1) ||
                          (boxesArray[2,0] == 1 && boxesArray[2,1] == 1 && boxesArray[2,2] == 1) )
                {
                    return "Xwin";
                }
                else
                {
                    // if ALL THAT DOESNT GO OFF RETURN DRAW
                    return "DRAW";
                }
                
            }
            return ""; // returning blank when it doesn't find anything to keep the main loop going

        }
        private void updateBoxes(int[,] boxesArray, int rowCount, int colCount)
        {
            // checking each value by checking if the counts are a certian number
            // this way we can see "if it's at the middle, update the middle with X or O"
            // and calling it like this allows it to stop updating the game when a winner is found

            if (rowCount == 0 && colCount == 0)
            {
                if (boxesArray[0,0] == 0)
                {
                    labelTicTopLeft.Text = "O";
                }
                else if (boxesArray[0,0] == 1)
                {
                    labelTicTopLeft.Text = "X";
                }
            }
            else if (rowCount == 0 && colCount == 1)
            {
                if (boxesArray[0,1] == 0)
                {
                    labelTicTopMid.Text = "O";
                }
                else if (boxesArray[0,1] == 1)
                {
                    labelTicTopMid.Text = "X";
                }
            }
            else if (rowCount == 0 && colCount == 2)
            {
                if (boxesArray[0,2] == 0)
                {
                    labelTicTopRight.Text = "O";
                }
                else if (boxesArray[0,2] == 1)
                {
                    labelTicTopRight.Text = "X";
                }
            }
            else if (rowCount == 1 && colCount == 0)
            {
                if (boxesArray[1,0] == 0)
                {
                    labelTicMidLeft.Text = "O";
                }
                else if (boxesArray[1,0] == 1)
                {
                    labelTicMidLeft.Text = "X";
                }
            }
            else if (rowCount == 1 && colCount == 1)
            {
                if (boxesArray[1,1] == 0)
                {
                    labelTicMidMid.Text = "O";
                }
                else if (boxesArray[1,1] == 1)
                {
                    labelTicMidMid.Text = "X";
                }
            }
            else if (rowCount == 1 && colCount == 2)
            {
                if (boxesArray[1,2] == 0)
                {
                    labelTicMidRight.Text = "O";
                }
                else if (boxesArray[1,2] == 1)
                {
                    labelTicMidRight.Text = "X";
                }
            }
            else if (rowCount == 2 && colCount == 0)
            {
                if (boxesArray[2,0] == 0)
                {
                    labelTicBotLeft.Text = "O";
                }
                else if (boxesArray[2,0] == 1)
                {
                    labelTicBotLeft.Text = "X";
                }
            }
            else if (rowCount == 2 && colCount == 1)
            {
                if (boxesArray[2,1] == 0)
                {
                    labelTicBotMid.Text = "O";
                }
                else if (boxesArray[2,1] == 1)
                {
                    labelTicBotMid.Text = "X";
                }
            }
            else if (rowCount == 2 && colCount == 2)
            {
                if (boxesArray[2,2] == 0)
                {
                    labelTicBotRight.Text = "O";
                }
                else if (boxesArray[2,2] == 1)
                {
                    labelTicBotRight.Text = "X";
                }
            }
        }
    }
}
