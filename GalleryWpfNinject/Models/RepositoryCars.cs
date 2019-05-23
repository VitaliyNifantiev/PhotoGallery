using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Ninject.Modules;
using Ninject;
using Microsoft.Win32;
using System.IO;
using GalleryWpfNinject.ViewModels;
using System.ComponentModel;

namespace GalleryWpfNinject.Models
{
    class RepositoryCars : NotifyItems, IRepository
    {
        ISaver save;
        ILoader load;
       // public ObservableCollection<IItem> items;
        public ObservableCollection<IItem> Items { get; set; }
       
        OpenFileDialog fl = new OpenFileDialog();

        public RepositoryCars(ISaver save, ILoader load)
        {
            Items = new ObservableCollection<IItem>();
            this.save = save;
            this.load = load;
            Items = load.LoadFromJson();
            foreach (IItem item in Items)
                item.Image = $"{Directory.GetCurrentDirectory()}\\ItemsImages\\{Path.GetFileName(item.Image)}";
           // CleanEmages.CleanImages(Items);
        }
        ~RepositoryCars()
        {
            save.SaveToJson(Items);
        }
        public void Add(ref IItem selItem)
        {
            Items.Add(new Car());
            selItem = null;
        }

        public void Remove(IItem selectedItem)
        {
            Items.Remove(selectedItem);
        }
        public void Update()
        {
            Items = new ObservableCollection<IItem>(Items);
        }

        
        public void RemoveCarForButton(object obj,ref IItem selectedItem)
        {
            if (!(obj is Button button))
                return;
            var item = TreeNavigator.FindParentOfType<ListBoxItem>(button);
            if (item == null) return;
            item.IsSelected = true;
            if (selectedItem != null)
            {
                var temp=selectedItem.Image;
                Items.Remove(selectedItem);
            }
        }
        public class TreeNavigator
        {
            public static T
                FindParentOfType<T>(DependencyObject child) where T : DependencyObject
            {
                var parentObj = child;
                do
                {
                    parentObj = VisualTreeHelper.GetParent(parentObj);
                    if (parentObj is T parent)
                        return parent;
                } while (parentObj != null);
                return null;
            }
        }

        public void AddImageByButton(object obj, ref IItem selectedItem)
        {
            if (!(obj is Button button))
                return;
            var item = TreeNavigator.FindParentOfType<ListBoxItem>(button);
            if (item == null) return;
            item.IsSelected = true;
            if (selectedItem != null)
            {
                if (fl.ShowDialog() == true)
                {
                    if (File.Exists(fl.FileName)&&!File.Exists($"{Directory.GetCurrentDirectory()}\\ItemsImages\\{Path.GetFileName(fl.FileName)}"))
                    {
                       
                        if (Directory.Exists($"{ Directory.GetCurrentDirectory()}\\ItemsImages"))
                        {

                            File.Copy(fl.FileName, $"{Directory.GetCurrentDirectory()}\\ItemsImages\\{Path.GetFileName(fl.FileName)}");
                        }
                        else
                        {
                            Directory.CreateDirectory($"{ Directory.GetCurrentDirectory()}\\ItemsImages");
                            File.Copy(fl.FileName, $"{Directory.GetCurrentDirectory()}\\ItemsImages\\{Path.GetFileName(fl.FileName)}");
                        }
                    }
                     selectedItem.Image = $"{Directory.GetCurrentDirectory()}\\ItemsImages\\{Path.GetFileName(fl.FileName)}";
                }
            }
        }

    }
}
