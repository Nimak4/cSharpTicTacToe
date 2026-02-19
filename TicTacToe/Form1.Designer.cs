namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNewGame = new Button();
            buttonClose = new Button();
            labelTicTopLeft = new Label();
            labelTicTopMid = new Label();
            labelTicTopRight = new Label();
            labelTicMidLeft = new Label();
            labelTicBotLeft = new Label();
            labelTicMidMid = new Label();
            labelTicBotMid = new Label();
            labelTicMidRight = new Label();
            labelTicBotRight = new Label();
            labelWinner = new Label();
            SuspendLayout();
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(66, 330);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(75, 23);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "New Game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(147, 330);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Exit";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelTicTopLeft
            // 
            labelTicTopLeft.BorderStyle = BorderStyle.FixedSingle;
            labelTicTopLeft.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicTopLeft.Location = new Point(12, 9);
            labelTicTopLeft.Name = "labelTicTopLeft";
            labelTicTopLeft.Size = new Size(85, 85);
            labelTicTopLeft.TabIndex = 2;
            labelTicTopLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicTopMid
            // 
            labelTicTopMid.BorderStyle = BorderStyle.FixedSingle;
            labelTicTopMid.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicTopMid.Location = new Point(103, 9);
            labelTicTopMid.Name = "labelTicTopMid";
            labelTicTopMid.Size = new Size(85, 85);
            labelTicTopMid.TabIndex = 3;
            labelTicTopMid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicTopRight
            // 
            labelTicTopRight.BorderStyle = BorderStyle.FixedSingle;
            labelTicTopRight.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicTopRight.Location = new Point(194, 9);
            labelTicTopRight.Name = "labelTicTopRight";
            labelTicTopRight.Size = new Size(85, 85);
            labelTicTopRight.TabIndex = 4;
            labelTicTopRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicMidLeft
            // 
            labelTicMidLeft.BorderStyle = BorderStyle.FixedSingle;
            labelTicMidLeft.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicMidLeft.Location = new Point(12, 103);
            labelTicMidLeft.Name = "labelTicMidLeft";
            labelTicMidLeft.Size = new Size(85, 85);
            labelTicMidLeft.TabIndex = 5;
            labelTicMidLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicBotLeft
            // 
            labelTicBotLeft.BorderStyle = BorderStyle.FixedSingle;
            labelTicBotLeft.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicBotLeft.Location = new Point(12, 198);
            labelTicBotLeft.Name = "labelTicBotLeft";
            labelTicBotLeft.Size = new Size(85, 85);
            labelTicBotLeft.TabIndex = 6;
            labelTicBotLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicMidMid
            // 
            labelTicMidMid.BorderStyle = BorderStyle.FixedSingle;
            labelTicMidMid.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicMidMid.Location = new Point(103, 103);
            labelTicMidMid.Name = "labelTicMidMid";
            labelTicMidMid.Size = new Size(85, 85);
            labelTicMidMid.TabIndex = 7;
            labelTicMidMid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicBotMid
            // 
            labelTicBotMid.BorderStyle = BorderStyle.FixedSingle;
            labelTicBotMid.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicBotMid.Location = new Point(103, 198);
            labelTicBotMid.Name = "labelTicBotMid";
            labelTicBotMid.Size = new Size(85, 85);
            labelTicBotMid.TabIndex = 8;
            labelTicBotMid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicMidRight
            // 
            labelTicMidRight.BorderStyle = BorderStyle.FixedSingle;
            labelTicMidRight.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicMidRight.Location = new Point(194, 103);
            labelTicMidRight.Name = "labelTicMidRight";
            labelTicMidRight.Size = new Size(85, 85);
            labelTicMidRight.TabIndex = 9;
            labelTicMidRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTicBotRight
            // 
            labelTicBotRight.BorderStyle = BorderStyle.FixedSingle;
            labelTicBotRight.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            labelTicBotRight.Location = new Point(194, 198);
            labelTicBotRight.Name = "labelTicBotRight";
            labelTicBotRight.Size = new Size(85, 85);
            labelTicBotRight.TabIndex = 10;
            labelTicBotRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWinner
            // 
            labelWinner.BorderStyle = BorderStyle.Fixed3D;
            labelWinner.Location = new Point(12, 295);
            labelWinner.Name = "labelWinner";
            labelWinner.Size = new Size(267, 23);
            labelWinner.TabIndex = 11;
            labelWinner.Text = "Let's play! :D";
            labelWinner.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 410);
            Controls.Add(labelWinner);
            Controls.Add(labelTicBotRight);
            Controls.Add(labelTicMidRight);
            Controls.Add(labelTicBotMid);
            Controls.Add(labelTicMidMid);
            Controls.Add(labelTicBotLeft);
            Controls.Add(labelTicMidLeft);
            Controls.Add(labelTicTopRight);
            Controls.Add(labelTicTopMid);
            Controls.Add(labelTicTopLeft);
            Controls.Add(buttonClose);
            Controls.Add(buttonNewGame);
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNewGame;
        private Button buttonClose;
        private Label labelTicTopLeft;
        private Label labelTicTopMid;
        private Label labelTicTopRight;
        private Label labelTicMidLeft;
        private Label labelTicBotLeft;
        private Label labelTicMidMid;
        private Label labelTicBotMid;
        private Label labelTicMidRight;
        private Label labelTicBotRight;
        private Label labelWinner;
    }
}
