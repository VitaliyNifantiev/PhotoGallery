using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GalleryWpfNinject.Models
{
    class CleanEmages
    {
      // static ObservableCollection<IItem> Items { get; set; }
      static  public void CleanImages(ObservableCollection<IItem> items)
        {
            //List<string> realImages = new List<string>();
            ////Items = items;
            //var allImages = Directory.GetFiles("ItemsImages");
            //foreach (var item in items)
            //    realImages.Add(item.Image);
            //foreach (var item in allImages )
            //    if (!realImages.Contains(item))
            //        File.Delete(item);
        }
       
    }
}
