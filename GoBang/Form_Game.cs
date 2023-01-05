using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GoBang
{
    public partial class Form_Game : Form
    {
        Pen pen = new Pen(Color.Black, 3);
        Brush brush_White = new SolidBrush(Color.White);
        Brush brush_Black = new SolidBrush(Color.Black);
        Graphics Board;
        PointF Cursor_Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        int[] Point_in_Board = new int[2];
        float[] Board_Prop_Data = new float[3];
        PointF[] Board_Bound = new PointF[2];
        public static bool PutStoneEnable;
        public Form_Game()
        {
            InitializeComponent();
        }
        public void Form_Game_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
            Board_Init();
        }
        private void Board_Init()
        {
            PutStoneEnable = true;
            float Board_H = this.Height - 80, Board_W = this.Width - 80;
            float r = 0, p = (Board_H - 80) / 15;
            Board_Bound[0].X = Board_W; Board_Bound[0].Y = Board_H;
            label1.Text = "Board_W=" + Board_W.ToString();
            label2.Text = "Board_H=" + Board_H.ToString();
            label4.Text = "p=" + p.ToString();
            Board_H -= p / 2;
            Board = this.CreateGraphics();
            Board.Clear(Color.BurlyWood);
            for (int i = 15; i > 0; i--)//Vertical
            {
                Board.DrawLine(pen, Board_W - r, Board_H, Board_W - r, 80 + p / 2);
                r += p;
            }
            Board_Bound[1].X = Board_W - r; Board_Bound[1].Y = 80;
            r = 0;
            for (int i = 15; i > 0; i--)//Horizontal
            {
                Board.DrawLine(pen, Board_W, Board_H - r, Board_W - Board_H + 80 + p / 2, Board_H - r);
                r += p;
            }
            Board_Prop_Data[0] = Board_W;
            Board_Prop_Data[1] = Board_H;
            Board_Prop_Data[2] = p;
            Board.Dispose();
            GameControl.Init();
        }

        private void Game_Status_Shut(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("結束遊戲？", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) System.Environment.Exit(0);
        }

        private void Game_Process_Restart()
        {
            DialogResult result = MessageBox.Show("重新開始？", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) Board_Init();
        }

        private void Form_Game_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor_Location = e.Location;
            Label_MouseCoD.Text = "Coordinate of Mouse: [" + Cursor.Position.X.ToString() + "," + Cursor.Position.Y.ToString() + "]";
        }
        private void Board_PutStone(int CurrentPlayer, PointF point, float p)
        {
            Board = this.CreateGraphics();
            Board.FillEllipse(CurrentPlayer == 1 ? brush_Black : brush_White, Board_Bound[1].X + Point_in_Board[0] * p - p / 4, Board_Bound[1].Y + Point_in_Board[1] * p + p / 4, p / 2, p / 2);
            Board.Dispose();
            GameControl.BOARD[Point_in_Board[0], Point_in_Board[1]] = GameControl.CurrentPlayer;
            GameControl.Check(Point_in_Board[0], Point_in_Board[1]);
        }

        private void Form_Game_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WarningMessage.Text = " ";
            if (PutStoneEnable)
            {
                if (Cursor_Location.X < Board_Bound[0].X && Cursor_Location.X > Board_Bound[1].X && Cursor_Location.Y < Board_Bound[0].Y && Cursor_Location.Y > Board_Bound[1].Y)
                {
                    if (Point_to_Board(Cursor_Location))
                    {
                        Board_PutStone(GameControl.CurrentPlayer, Cursor_Location, Board_Prop_Data[2]);
                        GameControl.PlayerChange();
                    }
                    else WarningMessage.Text = "This point can't be replaced.";
                }
            }
            else MessageBox.Show("Please start a new game.", "Information");
        }
        private bool Point_to_Board(PointF point)
        {
            Point_in_Board[0] = (int)Math.Round(point.X / Board_Prop_Data[2], 0, MidpointRounding.AwayFromZero) - 12;
            Point_in_Board[1] = (int)Math.Round(point.Y / Board_Prop_Data[2], 0, MidpointRounding.AwayFromZero) - 2;
            return GameControl.BOARD[Point_in_Board[0], Point_in_Board[1]] == 0 ? true : false;
        }

        private void clickGame_Process_Restart(object sender, EventArgs e)
        {
            Game_Process_Restart();
        }
        public void WinnerPanel()
        {
            MessageBox.Show("Winner is: Player" + GameControl.CurrentPlayer.ToString(), "Congratulate!", MessageBoxButtons.OK);
        }

    }
}
