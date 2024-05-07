using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ava.CodeProject.Models
{
    public partial class GameCatalogue : ObservableObject
    {
        [ObservableProperty]
        private string? _title;

        [ObservableProperty]
        private bool _favorite;

        public GameCatalogue(string gameTitle, bool fav) { Title = gameTitle; Favorite = fav; }
    }
}
