using WinFormsApp4.Properties;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
  
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;
        }

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;

        void EndGame()
        {
            lblTurn.Text = "GameOver";
            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    return;
                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    return;
                default:
                    lblWinner.Text = "Draw";
                    return;
            }
            MessageBox.Show("GameOver ", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CheckValues(Button btn1,Button btn2,Button btn3)
        {
            if(btn1.Tag.ToString()!="?"&& btn1.Tag.ToString()== btn2.Tag.ToString()&& btn1.Tag.ToString()== btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;
                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }
            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;

          
            if (CheckValues(button4, button5, button6))
                return;

            
            if (CheckValues(button7, button8, button9))
                return;

            
            if (CheckValues(button1, button4, button7))
                return;

            
            if (CheckValues(button2, button5, button8))
                return;

           
            if (CheckValues(button3, button6, button9))
                return;

            

            
            if (CheckValues(button1, button5, button9))
                return;

            
            if (CheckValues(button3, button5, button7))
                return;
        }

        public void ChangeImage(Button btn)
        {
            if (GameStatus.GameOver)
                return;

            if (btn.Tag.ToString() != "?")
            {
                MessageBox.Show("Warning", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (PlayerTurn==enPlayer.Player1)
            {
                btn.Image = Resources.X;
                PlayerTurn = enPlayer.Player2;
                lblTurn.Text = "Player 2";
                btn.Tag = "X";            
            }
            else
            {
                btn.Image = Resources.O;
                PlayerTurn = enPlayer.Player1;
                lblTurn.Text = "Player 1";    
                btn.Tag = "O";
                
            }

            GameStatus.PlayCount++;

            CheckWinner();

            if (GameStatus.GameOver)
                return;

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.Winner = enWinner.Draw;
                GameStatus.GameOver = true;
                EndGame();
            }

        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 10;


            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 300, 200, 700, 200);
            e.Graphics.DrawLine(Pen, 300, 310, 700, 310);
            e.Graphics.DrawLine(Pen, 430, 120, 430, 400);
            e.Graphics.DrawLine(Pen, 560, 120, 560, 400);
            

        }

        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        
    

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ResettButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void RestartButton()
        {
            ResettButton(button1);
            ResettButton(button2);
            ResettButton(button3);
            ResettButton(button4);
            ResettButton(button5);
            ResettButton(button6);
            ResettButton(button7);
            ResettButton(button8);
            ResettButton(button9);

            PlayerTurn = enPlayer.Player1;
            lblTurn.Text = "Player 1";
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameInProgress;
            lblWinner.Text = "In Progress";
            
        }
      
        
     
  

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartButton();
        }
    }
}
