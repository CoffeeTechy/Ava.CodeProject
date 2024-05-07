using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Ava.CodeProject.Models
{
    public partial class CBList : ObservableObject
    {
        [ObservableProperty]
        private string? _cbitem;

        [ObservableProperty]
        private bool _done;        

        public CBList(string? item, bool isdone)
        {
            Cbitem = item;
            Done = isdone;
        }
    }
}
