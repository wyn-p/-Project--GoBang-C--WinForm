using System.Windows.Forms;

namespace GoBang
{
    internal class GameControl
    {
        public static int[,] BOARD = new int[15, 15];
        public static int CurrentPlayer = 0;
        public static int MaxCount = 0;
        public static void Init()
        {
            //initialize board
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 15; j++)
                    BOARD[i, j] = 0;
            CurrentPlayer = 1;
            MaxCount = 0;
        }
        public static void PlayerChange()
        {
            CurrentPlayer = CurrentPlayer == 1 ? 2 : 1;
        }
        public static void Check(int x, int y)
        {
            var tempClass = new Form_Game();

            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_UpperLeft(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_BottomRight(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            if (MaxCount == 4)
            {
                Form_Game.PutStoneEnable = false;
                tempClass.WinnerPanel();
            }
            MaxCount = 0;

            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_Upper(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_Bottom(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            if (MaxCount == 4)
            {
                Form_Game.PutStoneEnable = false;
                tempClass.WinnerPanel();
            }
            MaxCount = 0;

            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_UpperRight(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_BottomLeft(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            if (MaxCount == 4)
            {
                Form_Game.PutStoneEnable = false;
                tempClass.WinnerPanel();
            }
            MaxCount = 0;

            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_Left(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            CheckFunc.Check_CoD_X = x; CheckFunc.Check_CoD_Y = y;
            CheckFunc.Check_Right(CheckFunc.Check_CoD_X, CheckFunc.Check_CoD_Y);
            if (MaxCount == 4)
            {
                Form_Game.PutStoneEnable = false;
                tempClass.WinnerPanel();
            }
            MaxCount = 0;
        }
    }
    internal class CheckFunc
    {
        public static int Check_CoD_X, Check_CoD_Y;
        public static void Check_UpperLeft(int x, int y)
        {
            if (x - 1 > -1 && y - 1 > -1 && GameControl.BOARD[x - 1, y - 1] == GameControl.CurrentPlayer)
            {
                Check_CoD_X--;
                Check_CoD_Y--;
                GameControl.MaxCount++;
                Check_UpperLeft(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_Upper(int x, int y)
        {
            if (y - 1 > -1 && GameControl.BOARD[x, y - 1] == GameControl.CurrentPlayer)
            {
                Check_CoD_Y--;
                GameControl.MaxCount++;
                Check_Upper(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_UpperRight(int x, int y)
        {
            if (x + 1 < 15 && y - 1 > -1 && GameControl.BOARD[x + 1, y - 1] == GameControl.CurrentPlayer)
            {
                Check_CoD_X++;
                Check_CoD_Y--;
                GameControl.MaxCount++;
                Check_UpperRight(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_Left(int x, int y)
        {
            if (x - 1 > -1 && GameControl.BOARD[x - 1, y] == GameControl.CurrentPlayer)
            {
                Check_CoD_X--;
                GameControl.MaxCount++;
                Check_Left(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_Right(int x, int y)
        {
            if (x + 1 < 15 && GameControl.BOARD[x + 1, y] == GameControl.CurrentPlayer)
            {
                Check_CoD_X++;
                GameControl.MaxCount++;
                Check_Right(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_BottomLeft(int x, int y)
        {
            if (x - 1 > -1 && y + 1 < 15 && GameControl.BOARD[x - 1, y + 1] == GameControl.CurrentPlayer)
            {
                Check_CoD_X--;
                Check_CoD_Y++;
                GameControl.MaxCount++;
                Check_BottomLeft(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_Bottom(int x, int y)
        {
            if (y + 1 < 15 && GameControl.BOARD[x, y + 1] == GameControl.CurrentPlayer)
            {
                Check_CoD_Y++;
                GameControl.MaxCount++;
                Check_Bottom(Check_CoD_X, Check_CoD_Y);
            }
        }
        public static void Check_BottomRight(int x, int y)
        {
            if (x + 1 < 15 && y + 1 < 15 && GameControl.BOARD[x + 1, y + 1] == GameControl.CurrentPlayer)
            {
                Check_CoD_X++;
                Check_CoD_Y++;
                GameControl.MaxCount++;
                Check_BottomRight(Check_CoD_X, Check_CoD_Y);
            }
        }

    }
}
