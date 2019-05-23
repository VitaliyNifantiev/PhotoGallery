using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalleryWpfNinject.Models;
using GalleryWpfNinject.ViewModels;
using Ninject.Modules;

namespace GalleryWpfNinject.Infostructure
{
    class MyDIModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IItem>().To<Car>();
            this.Bind<IRepository>().To<RepositoryCars>();
            this.Bind<ISaver>().To<SaveJson>();
            this.Bind<ILoader>().To<LoadJson>();
        }
    }
}
