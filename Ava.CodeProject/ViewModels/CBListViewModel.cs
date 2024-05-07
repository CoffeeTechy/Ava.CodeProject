using Ava.CodeProject.Models;
using Ava.CodeProject.Views;
using Avalonia.Controls;
using Avalonia.Controls.Converters;
using Avalonia.Interactivity;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ava.CodeProject.ViewModels
{
    public partial class CBListViewModel : ViewModelBase
    {

        public ObservableCollection<CBList> CbList { get; }

        public CBListViewModel()
        {

            CbList = new ObservableCollection<CBList>(new List<CBList> { });
        }

        public string? aTask;

        public string? AddTask 
        {
            get => aTask; 
            set
            {
                SetProperty(ref aTask, value);
            }
        }

        public void addCheckBox()
        {
            if (AddTask != null) 
            {
                if (AddTask != string.Empty)
                {
                    var checkbox = new CBList(AddTask, false)
                    {
                        Cbitem = AddTask,
                        Done = false
                    };

                    CbList.Add(checkbox);
                }                
            }
            AddTask = string.Empty;
        }

        public void EraseCBList()
        {
            CbList.Clear();
        }

        public void EraseTask()
        {
            int num = CbList.Count;
           
            if (num > 0)
            {
                CbList.RemoveAt(num - 1);
            }                       
        }


    }
}
