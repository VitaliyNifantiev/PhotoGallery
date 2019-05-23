using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryWpfNinject.Models
{
    interface IRepository
    {
        void Add(ref IItem selectedItem);
        void Remove(IItem selectedItem);
        void Update();
        ObservableCollection<IItem> Items { get; set; }
    }
}
