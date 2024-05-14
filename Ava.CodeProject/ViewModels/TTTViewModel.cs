using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ava.CodeProject.ViewModels
{
    public partial class TTTViewModel : ViewModelBase
    {
        [ObservableProperty]
        private int num;

        [ObservableProperty]
        private string player;

        public TTTViewModel() { num = 0; player = string.Empty; xwins = 0; owins = 0;
            Btn1enabled = true;
            Btn2enabled = true;
            Btn3enabled = true;
            Btn4enabled = true;
            Btn5enabled = true;
            Btn6enabled = true;
            Btn7enabled = true;
            Btn8enabled = true;
            Btn9enabled = true;
        }

        [ObservableProperty]       
        private string btn1_player; 

        [ObservableProperty]
        private string btn2_player;

        [ObservableProperty]
        private string btn3_player;

        [ObservableProperty]
        private string btn4_player;

        [ObservableProperty]
        private string btn5_player;

        [ObservableProperty]
        private string btn6_player;

        [ObservableProperty]
        private string btn7_player;

        [ObservableProperty]
        private string btn8_player;

        [ObservableProperty]
        private string btn9_player;

        [ObservableProperty]
        private bool btn1enabled;

        [ObservableProperty]
        private bool btn2enabled;

        [ObservableProperty]
        private bool btn3enabled;

        [ObservableProperty]
        private bool btn4enabled;

        [ObservableProperty]
        private bool btn5enabled;

        [ObservableProperty]
        private bool btn6enabled;

        [ObservableProperty]
        private bool btn7enabled;

        [ObservableProperty]
        private bool btn8enabled;

        [ObservableProperty]
        private bool btn9enabled;

        [ObservableProperty]
        private int xwins;

        [ObservableProperty]
        private int owins;

        public void Turns()
        {
            if (Num % 2 == 0)
            {
                Player = "X";
            }
            else
            {
                Player = "O";
            }
        }

        public void Button1_Click()
        {
            Turns();
            Btn1_player = Player;
            Num++;
            Btn1enabled = false;
        }

        public void Button2_Click()
        {          
            Turns();
            Btn2_player = Player;
            Num++;
            Btn2enabled = false;
        }

        public void Button3_Click()
        {
            Turns();
            Btn3_player = Player;
            Num++;
            Btn3enabled = false;
        }

        public void Button4_Click()
        {        
            Turns();
            Btn4_player = Player;
            Num++;
            Btn4enabled = false;
        }

        public void Button5_Click()
        {
            Turns();
            Btn5_player = Player;
            Num++;
            Btn5enabled = false;
        }

        public void Button6_Click()
        {
            Turns();
            Btn6_player = Player;
            Num++;
            Btn6enabled = false;
        }

        public void Button7_Click()
        {
            Turns();
            Btn7_player = Player;
            Num++;
            Btn7enabled = false;
        }

        public void Button8_Click()
        {
            Turns();
            Btn8_player = Player;
            Num++;
            Btn8enabled = false;
        }

        public void Button9_Click()
        {
            Turns();
            Btn9_player = Player;
            Num++;
            Btn9enabled = false;
        }

        public void ResetGame()
        {
            XWinTally();
            OWinTally();
            Btn1enabled = true; Btn1_player = string.Empty;
            Btn2enabled = true; Btn2_player = string.Empty;
            Btn3enabled = true; Btn3_player = string.Empty;
            Btn4enabled = true; Btn4_player = string.Empty;
            Btn5enabled = true; Btn5_player = string.Empty;
            Btn6enabled = true; Btn6_player = string.Empty;
            Btn7enabled = true; Btn7_player = string.Empty;
            Btn8enabled = true; Btn8_player = string.Empty;
            Btn9enabled = true; Btn9_player = string.Empty;
            Num = 0;
        }

        public void XWinTally()
        {
            if (Btn1_player == "X" && Btn2_player == "X" && Btn3_player == "X") //First row
            {
                Xwins++;
            }
            else if (Btn4_player == "X" && Btn5_player == "X" && Btn6_player == "X") //second row
            {
                Xwins++;
            }
            else if (Btn7_player == "X" && Btn8_player == "X" && Btn9_player == "X") //thrid row
            {
                Xwins++;
            }
            else if (Btn1_player == "X" && Btn4_player == "X" && Btn7_player == "X") //first column
            {
                Xwins++;
            }
            else if (Btn2_player == "X" && Btn5_player == "X" && Btn8_player == "X") //second column
            {
                Xwins++;
            }
            else if (Btn3_player == "X" && Btn6_player == "X" && Btn9_player == "X") //third column
            {
                Xwins++;
            }
            else if (Btn1_player == "X" && Btn4_player == "X" && Btn9_player == "X") //first diag
            {
                Xwins++;
            }
            else if (Btn3_player == "X" && Btn4_player == "X" && Btn7_player == "X") //second diag
            {
                Xwins++;
            }
        }

        public void OWinTally()
        {
            if (Btn1_player == "O" && Btn2_player == "O" && Btn3_player == "O") //First row
            {
                Owins++;
            }
            else if (Btn4_player == "O" && Btn5_player == "O" && Btn6_player == "O") //second row
            {
                Owins++;
            }
            else if (Btn7_player == "O" && Btn8_player == "O" && Btn9_player == "O") //thrid row
            {
                Owins++;
            }
            else if (Btn1_player == "O" && Btn4_player == "O" && Btn7_player == "O") //first column
            {
                Owins++;
            }
            else if (Btn2_player == "O" && Btn5_player == "O" && Btn8_player == "O") //second column
            {
                Owins++;
            }
            else if (Btn3_player == "O" && Btn6_player == "O" && Btn9_player == "O") //third column
            {
                Owins++;
            }
            else if (Btn1_player == "O" && Btn4_player == "O" && Btn9_player == "O") //first diag
            {
                Owins++;
            }
            else if (Btn3_player == "O" && Btn4_player == "O" && Btn7_player == "O") //second diag
            {
                Owins++;
            }
        }
    }
}
