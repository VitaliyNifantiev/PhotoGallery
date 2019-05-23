using GalleryWpfNinject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryWpfNinject.ViewModels
{
    interface ISaver
    {
       void SaveToJson(ObservableCollection<IItem> vm);
    }
}
