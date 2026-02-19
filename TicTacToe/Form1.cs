using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Security.Cryptography;

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

            // Constants for array size, start and end of range (so we get 0 and 1 from rand)
            const int arraySize = 9, rangeStart = 0, rangeEnd = 2;
            int[] gameArray = new int[arraySize];

            var rand = new Random();

            // should repeat 9 times i hope!
            for (int count = 0; count < arraySize; count++)
            {
                // getting a random number 0-1 then adding it to the array
                int randomNumber = rand.Next(rangeStart, rangeEnd);
                gameArray[count] = randomNumber;

                // checking for winner!
                string winnerFound = checkIfWinner(gameArray, count);
                // updating text boxes!
                updateBoxes(gameArray, count);

                if (winnerFound == "Owin")
                {
                    labelWinner.Text = "O is the winner!";
                    break;
                }
                else if (winnerFound == "Xwin")
                {
                    labelWinner.Text = "X is the winner!";
                    break;
                }
                else if (winnerFound == "DRAW")
                {
                    labelWinner.Text = "Nobody is the winner. Sad...";
                    break;
                }
            }



        }
        private string checkIfWinner(int[] boxesArray, int count)
        {
            // this one's a bit of a mess, i wrote out pseudocode after i worked through how I was meant to have the program
            // check for a winner each time it looped.
            // if the pseudocode doesn't line up sometimes, that's because i had to rework a couple of times when i realized
            // i wasn't accounting for X or Y winning, just if there WAS a winner or a draw.
            // So I decided to return a string instead of a bool!

            // array elements visualized:
            // 0 | 1 | 2
            // 3 | 4 | 5
            // 6 | 7 | 8

            // if there are 3 items in the array
            if (count == 2)
            {
                //   check if 0, 1, 2 (1-3) are all X or O
                //   if so, return true
                // ? | ? | ?
                // _ | _ | _
                // _ | _ | _
                if (boxesArray[0] == 0 && boxesArray[1] == 0 && boxesArray[2] == 0)
                {
                    return "Owin";
                }
                else if (boxesArray[0] == 1 && boxesArray[1] == 1 && boxesArray[2] == 1)
                {
                    return "Xwin";
                }
            }
            // else if there are 6 items in the array
            else if (count == 5)
            {
                //   check if items 3, 4, 5 (4-6) are all X or 0
                //   if so, return true
                // _ | _ | _
                // ? | ? | ?
                // _ | _ | _
                if (boxesArray[3] == 0 && boxesArray[4] == 0 && boxesArray[5] == 0)
                {
                    return "Owin";
                }
                else if (boxesArray[3] == 1 && boxesArray[4] == 1 && boxesArray[5] == 1)
                {
                    return "Xwin";
                }
            }
            // else if there are 7 items in the array
            else if (count == 6)
            {
                //    check if items 0, 3, 6 are all X or O OR
                //    check if items 2, 4, 6 are all X or O
                //    if so, return true
                // ? | _ | ?
                // ? | ? | _
                // ? | _ | _
                if ((boxesArray[0] == 0 && boxesArray[3] == 0 && boxesArray[6] == 0) ||
                    (boxesArray[2] == 0 && boxesArray[4] == 0 && boxesArray[6] == 0) )
                {
                    return "Owin";
                }
                else if ((boxesArray[0] == 1 && boxesArray[3] == 1 && boxesArray[6] == 1) ||
                         (boxesArray[2] == 1 && boxesArray[4] == 1 && boxesArray[6] == 1) )
                {
                    return "Xwin";
                }
            }
            // else if there are 8 items in the array
            else if (count == 7)
            {
                // else if there are 8 items in the array
                //    check if items 1, 4, 7 are all X or O
                //    if so, return true
                // _ | ? | _
                // _ | ? | _
                // _ | ? | _
                if (boxesArray[1] == 0 && boxesArray[4] == 0 && boxesArray[7] == 0)
                {
                    return "Owin";
                }
                else if (boxesArray[1] == 1 && boxesArray[4] == 1 && boxesArray[7] == 1)
                {
                    return "Xwin";
                }
            }
            else if (count == 8)
            {
                // else if there are 9 items in the array
                //    check if items 2, 5, 8 are all X or O
                //    check if items 0. 4. 8 are all X or O
                //    check if items 6, 7, 8 are all X or O
                //    if so, return true
                // ? | _ | ?
                // _ | ? | ?
                // ? | ? | ?
                if  ((boxesArray[2] == 0 && boxesArray[5] == 0 && boxesArray[8] == 0) ||
                     (boxesArray[0] == 0 && boxesArray[4] == 0 && boxesArray[8] == 0) ||
                     (boxesArray[6] == 0 && boxesArray[7] == 0 && boxesArray[8] == 0) )
                {
                    return "Owin";
                }
                else if  ((boxesArray[2] == 1 && boxesArray[5] == 1 && boxesArray[8] == 1) ||
                          (boxesArray[0] == 1 && boxesArray[4] == 1 && boxesArray[8] == 1) ||
                          (boxesArray[6] == 1 && boxesArray[7] == 1 && boxesArray[8] == 1) )
                {
                    return "Xwin";
                }
                else
                {
                    return "DRAW";
                }
                // if ALL THAT DOESNT GO OFF RETURN FALSE
            }
            // TEST MAY RETURN DRAW EVERY TIME
            // MessageBox.Show("TIE");
            return ""; // returning blank when it doesnt find anything??

        }
        private void updateBoxes(int[] boxesArray, int count)
        {
            if (count == 0)
            {
                if (boxesArray[0] == 0)
                {
                    labelTicTopLeft.Text = "O";
                }
                else if (boxesArray[0] == 1)
                {
                    labelTicTopLeft.Text = "X";
                }
            }
            else if (count == 1)
            {
                if (boxesArray[1] == 0)
                {
                    labelTicTopMid.Text = "O";
                }
                else if (boxesArray[1] == 1)
                {
                    labelTicTopMid.Text = "X";
                }
            }
            else if (count == 2)
            {
                if (boxesArray[2] == 0)
                {
                    labelTicTopRight.Text = "O";
                }
                else if (boxesArray[2] == 1)
                {
                    labelTicTopRight.Text = "X";
                }
            }
            else if (count == 3)
            {
                if (boxesArray[3] == 0)
                {
                    labelTicMidLeft.Text = "O";
                }
                else if (boxesArray[3] == 1)
                {
                    labelTicMidLeft.Text = "X";
                }
            }
            else if (count == 4)
            {
                if (boxesArray[4] == 0)
                {
                    labelTicMidMid.Text = "O";
                }
                else if (boxesArray[4] == 1)
                {
                    labelTicMidMid.Text = "X";
                }
            }
            else if (count == 5)
            {
                if (boxesArray[5] == 0)
                {
                    labelTicMidRight.Text = "O";
                }
                else if (boxesArray[5] == 1)
                {
                    labelTicMidRight.Text = "X";
                }
            }
            else if (count == 6)
            {
                if (boxesArray[6] == 0)
                {
                    labelTicBotLeft.Text = "O";
                }
                else if (boxesArray[6] == 1)
                {
                    labelTicBotLeft.Text = "X";
                }
            }
            else if (count == 7)
            {
                if (boxesArray[7] == 0)
                {
                    labelTicBotMid.Text = "O";
                }
                else if (boxesArray[7] == 1)
                {
                    labelTicBotMid.Text = "X";
                }
            }
            else if (count == 8)
            {
                if (boxesArray[8] == 0)
                {
                    labelTicBotRight.Text = "O";
                }
                else if (boxesArray[8] == 1)
                {
                    labelTicBotRight.Text = "X";
                }
            }
        }
    }
}
