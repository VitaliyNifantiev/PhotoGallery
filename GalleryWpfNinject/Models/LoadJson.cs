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
    class LoadJson : ILoader
    {
        public ObservableCollection<IItem> LoadFromJson()
        {
            var settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Auto;
            string str = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\data.json");
            return  JsonConvert.DeserializeObject<ObservableCollection<IItem>>(str,settings);
        }
    }
}
