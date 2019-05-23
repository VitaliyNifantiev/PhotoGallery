using GalleryWpfNinject.Infostructure;
using GalleryWpfNinject.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace GalleryWpfNinject.ViewModels
{
    class MainViewModel : NotifyItems
    {
        ObservableCollection<IItem> items;
        OpenFileDialog fl=new OpenFileDialog();
        IRepository repo;
        IItem selectedItem;
        int itemsSize = 150;
        int fontSize = 14;
        string sort;
        public string Sort
        {
            get => sort;
            set
            {
                sort = value;
                SortMethod(sort);
            }
        }
        string style="1" ;
        public string Style
        {
            get => style;
            set
            {
                style = value;
                Notify();
            }
        }
        private void SortMethod(string sort)
        {
            switch (sort)
            {
                case "Title":
                    Items = new ObservableCollection<IItem>(Items.OrderBy(x => x.Title).Reverse());
                    break;
                case "Color":
                    Items = new ObservableCollection<IItem>(Items.OrderBy(x => x.Color).Reverse());
                    break;
                case "Year":
                    Items = new ObservableCollection<IItem>(Items.OrderBy(x => x.Year).Reverse());
                    break;
            }
        }

        public ObservableCollection<IItem> Items
        {
            get =>items;
            set
            {
                items = value;
                Notify();
            }
        }
        public IItem SelectedItem
        {
            get=>selectedItem;
            set
            {
                selectedItem = value;
                Notify();
               
            }
        }
        public int ImageSize 
        {
            get => itemsSize;
            set
            {
                itemsSize = value;
                Notify();
            }
        }
        public int FontSize
        {
            get => fontSize;
            set
            {
                fontSize = value;
                Notify();
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand AddImageCommand { get; set; }
        public ICommand RemoveForButtonCommand { get; set; }
        public ICommand OpenImageCommand { get; set; }
       // public ICommand UnselectCommand { get; set; }

        public MainViewModel(IRepository repo)
        {
            this.repo = repo;
            Items = repo.Items;
            AddCommand = new RelayCommand(x=>repo.Add(ref selectedItem));
            RemoveCommand = new RelayCommand(x => repo.Remove(selectedItem),y=>selectedItem!=null);
            AddImageCommand = new RelayCommand(param =>(repo as RepositoryCars).AddImageByButton(param,ref selectedItem));
            RemoveForButtonCommand = new RelayCommand(param =>(repo as RepositoryCars).RemoveCarForButton(param,ref selectedItem));
            OpenImageCommand = new RelayCommand(x => Process.Start(selectedItem.Image));
           // UnselectCommand = new RelayCommand(x => Unselect());
        }
        //public void Unselect()
        //{
        //    SelectedItem = null;
        //}
    }
}
