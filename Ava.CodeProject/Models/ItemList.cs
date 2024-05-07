using Ava.CodeProject.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ava.CodeProject.Models
{
    public partial class ItemList : ObservableObject
    {
        [ObservableProperty]
        private string? _listItem;

        [ObservableProperty]
        private int _number;

        public ItemList(string tasks, int num) 
        {
            ListItem = tasks;
            Number = num;
        }

        //Normally would do Task { get; set; }, but ObservableProperty does that for us
        //Normally would do Number { get; set; }, but ObservableProperty does that for us
    }
}
