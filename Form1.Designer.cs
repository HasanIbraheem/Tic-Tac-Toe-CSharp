namespace WinFormsApp4
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
            lblTicTacToe = new Label();
            label2 = new Label();
            lbl1 = new Label();
            lblTurn = new Label();
            lbl2 = new Label();
            lblWinner = new Label();
            btnRestart = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // lblTicTacToe
            // 
            lblTicTacToe.AutoSize = true;
            lblTicTacToe.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicTacToe.ForeColor = Color.White;
            lblTicTacToe.Location = new Point(278, 20);
            lblTicTacToe.Name = "lblTicTacToe";
            lblTicTacToe.Size = new Size(426, 65);
            lblTicTacToe.TabIndex = 0;
            lblTicTacToe.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.Yellow;
            lbl1.Location = new Point(65, 132);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(100, 50);
            lbl1.TabIndex = 2;
            lbl1.Text = "Turn";
            // 
            // lblTurn
            // 
            lblTurn.AutoSize = true;
            lblTurn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTurn.ForeColor = Color.White;
            lblTurn.Location = new Point(45, 195);
            lblTurn.Name = "lblTurn";
            lblTurn.Size = new Size(140, 45);
            lblTurn.TabIndex = 3;
            lblTurn.Text = "Player 1";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.Yellow;
            lbl2.Location = new Point(51, 249);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(129, 45);
            lbl2.TabIndex = 4;
            lbl2.Text = "Winner";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWinner.ForeColor = Color.FromArgb(0, 192, 0);
            lblWinner.ImageAlign = ContentAlignment.MiddleRight;
            lblWinner.Location = new Point(45, 306);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(189, 45);
            lblWinner.TabIndex = 5;
            lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            btnRestart.BackColor = Color.Black;
            btnRestart.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnRestart.ForeColor = Color.White;
            btnRestart.Location = new Point(36, 365);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(179, 47);
            btnRestart.TabIndex = 6;
            btnRestart.Text = "Restart Game";
            btnRestart.UseVisualStyleBackColor = false;
            btnRestart.Click += btnRestart_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.question_mark_96;
            button2.Location = new Point(460, 104);
            button2.Name = "button2";
            button2.Size = new Size(75, 88);
            button2.TabIndex = 7;
            button2.Tag = "?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.question_mark_96;
            button1.Location = new Point(333, 105);
            button1.Name = "button1";
            button1.Size = new Size(75, 87);
            button1.TabIndex = 8;
            button1.Tag = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.question_mark_96;
            button3.Location = new Point(583, 104);
            button3.Name = "button3";
            button3.Size = new Size(75, 88);
            button3.TabIndex = 9;
            button3.Tag = "?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.question_mark_96;
            button4.Location = new Point(333, 211);
            button4.Name = "button4";
            button4.Size = new Size(75, 91);
            button4.TabIndex = 10;
            button4.Tag = "?";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.question_mark_96;
            button5.Location = new Point(460, 211);
            button5.Name = "button5";
            button5.Size = new Size(75, 84);
            button5.TabIndex = 11;
            button5.Tag = "?";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = Properties.Resources.question_mark_96;
            button6.Location = new Point(583, 211);
            button6.Name = "button6";
            button6.Size = new Size(75, 84);
            button6.TabIndex = 12;
            button6.Tag = "?";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.question_mark_96;
            button7.Location = new Point(333, 320);
            button7.Name = "button7";
            button7.Size = new Size(75, 92);
            button7.TabIndex = 13;
            button7.Tag = "?";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.question_mark_96;
            button8.Location = new Point(460, 320);
            button8.Name = "button8";
            button8.Size = new Size(75, 92);
            button8.TabIndex = 14;
            button8.Tag = "?";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Transparent;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.question_mark_96;
            button9.Location = new Point(583, 320);
            button9.Name = "button9";
            button9.Size = new Size(75, 92);
            button9.TabIndex = 15;
            button9.Tag = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(924, 544);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnRestart);
            Controls.Add(lblWinner);
            Controls.Add(lbl2);
            Controls.Add(lblTurn);
            Controls.Add(lbl1);
            Controls.Add(label2);
            Controls.Add(lblTicTacToe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicTacToe;
        private Label label2;
        private Label lbl1;
        private Label lblTurn;
        private Label lbl2;
        private Label lblWinner;
        private Button btnRestart;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
