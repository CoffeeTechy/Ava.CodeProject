using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public TTTViewModel() { num = 0; player = string.Empty; 
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
            Btn1enabled = true; Btn1_player = string.Empty;
            Btn2enabled = true; Btn2_player = string.Empty;
            Btn3enabled = true; Btn3_player = string.Empty;
            Btn4enabled = true; Btn4_player = string.Empty;
            Btn5enabled = true; Btn5_player = string.Empty;
            Btn6enabled = true; Btn6_player = string.Empty;
            Btn7enabled = true; Btn7_player = string.Empty;
            Btn8enabled = true; Btn8_player = string.Empty;
            Btn9enabled = true; Btn9_player = string.Empty;
        }
    }
}
