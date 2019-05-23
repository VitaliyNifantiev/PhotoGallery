using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalleryWpfNinject.Models;
using Newtonsoft.Json;

namespace GalleryWpfNinject.ViewModels
{
    class SaveJson:ISaver
    {
        public void SaveToJson(ObservableCollection<IItem> vm)
        {
            var settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Auto;
            string str = JsonConvert.SerializeObject(vm, settings);
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\data.json",str);
        }

    }
}
