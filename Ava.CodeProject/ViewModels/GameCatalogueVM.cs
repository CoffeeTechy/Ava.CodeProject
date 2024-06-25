using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ava.CodeProject.Models;
using Ava.CodeProject.Views;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Ava.CodeProject.ViewModels
{
    public partial class GameCatalogueVM : ViewModelBase
    {
        public ObservableCollection<GameCatalogue> Games { get; }

        public GameCatalogueVM() 
        { 
            Games = new ObservableCollection<GameCatalogue>( new List<GameCatalogue> { });      
        }

        public string? gtitle;

        public string? gametitle 
        {
            get => gtitle;
            set
            {
                SetProperty(ref gtitle, value);
            }
        
        }

        public void addGames()
        {
            if (gametitle != null) 
            { 
                if (gametitle != string.Empty) 
                {
                    var newGame = new GameCatalogue(gametitle, false)
                    {
                        Title = gametitle,
                        Favorite = false
                    };

                    Games.Add(newGame);
                }
            } 

            gametitle = string.Empty;
        }

        public void removeGame()
        {
            int num = Games.Count;

            if (num > 0)
            {
                Games.RemoveAt(num - 1);
            }
        }

        public void removeNonFav() //still doesn't delete all non favorites
        {
            for (int i = 0; i < (Games.Count); i++) 
            { 
                if (Games[i].Favorite != true) 
                {
                    Games.RemoveAt(i);
                }               
            }
        }

        public void removeFav() //still doesn't delete all favorites
        {
            for (int i = 0; i < (Games.Count); i++)
            {
                if (Games[i].Favorite == true)
                {
                    Games.RemoveAt(i);
                }
            }
        }
    }
}
