using Ava.CodeProject.Models;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ava.CodeProject.ViewModels
{
    public partial class ItemListViewModel : ViewModelBase
    {

        public ObservableCollection<ItemList> itemList { get; }
        public int itemNum { get; set; }


        public ItemListViewModel()
        {
            itemNum = 1;

            itemList = new ObservableCollection<ItemList>(new List<ItemList> { });
        }

        public string? anItem;

        public string? AddItem 
        {
            get => anItem;
            set
            {
                SetProperty(ref anItem, value);
            }
        }

        public void addToList()
        {
            if (AddItem != null)
            {
                if (AddItem != string.Empty)
                {
                    var item = new ItemList(AddItem, itemNum)
                    {
                        ListItem = AddItem,
                        Number = itemNum
                    };

                    itemList.Add(item);

                    itemNum += 1;
                }
            }
            AddItem = string.Empty;         
        }

        public void EraseList()
        {
            itemList.Clear();

            itemNum = 1;
        }

        public void EraseLast()
        {
            int num = itemList.Count;

            if (num > 0) 
            {
                itemList.RemoveAt(num - 1);
            }

            if (itemList.Count == 0)
            {
                itemNum = 1;
            }
        }

    }
}
