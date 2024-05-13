using Ava.CodeProject.Models;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Net.Security;

namespace Ava.CodeProject.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static

#pragma warning restore CA1822 // Mark members as static

        //greeting and pane 

        [ObservableProperty]
        private string _greeting = "Welcome to Avalonia! \n\nPress the XX button to change the greeting to a goodbye";

        [ObservableProperty]
        public string _explain = "Then click the refresh tab for the button to change the text back to a greeting!";

        [ObservableProperty]
        private bool _paneOpen = false; //holds true or false value if pane is open or closed

        [ObservableProperty]
        private string _isOpen = ">>"; //arrow direction for button depending on if pane is open or closed

        [RelayCommand]
        public void OpenPane() //handles both open and closing pane as well as arrow direction
        {
            PaneOpen = !PaneOpen;

            if (PaneOpen)
                IsOpen = "<<";

            else if (!PaneOpen)
                IsOpen = ">>";
        }

        [RelayCommand]
        public void ChangeGreeting() //changes the greeting in the welcome tab to goodbye
        {
            Greeting = "And goodbye!";
        }

        [RelayCommand]
        public void RefreshGreeting() //changes again to say welcome
        {
            Greeting = "Welcome again!";
            Explain = "";
        }

        //Color options

        [ObservableProperty]            //the standard for splitbutton is to say choose option
        string _opt = "Choose a color...";

        [RelayCommand]                  //changes split button to say Green if selected
        public void SplitButtonOption1()
        {
            Opt = "Green";
        }

        [RelayCommand]                  //changes split button to say Red if selected
        public void SplitButtonOption2()
        {
            Opt = "Red";
        }

        [RelayCommand]
        public void SplitButtonOption3() //changes split button to say Grey if selected
        {
            Opt = "Gray";
        }

        public void SplitButtonOption4()
        {
            Opt = "Reset";
        }

        [ObservableProperty]            //holds value for back ground color of Tab Control
        private string _bcolor = string.Empty;

        [RelayCommand]                  //changes background color of Tab Control depending on option selected
        public void SplitButtonCommand()
        {
            if (Opt == "Green")
            {
                Bcolor = "green";
            }

            else if (Opt == "Red")
                Bcolor = "red";

            else if (Opt == "Gray")
                Bcolor = "gray";
            else
            {
                Bcolor = string.Empty;
                Opt = "Choose a color...";
            }                
        }

        [RelayCommand]
        public void newWindow()
        {
            var window = new SettingsView();
            window.Show();
        }

        public void newGame()
        {
            var window = new TTTView();
            window.Show();
        }

    }

    
}
