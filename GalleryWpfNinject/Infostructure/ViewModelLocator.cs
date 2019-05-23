using GalleryWpfNinject.Models;
using GalleryWpfNinject.ViewModels;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GalleryWpfNinject.Infostructure
{
    class ViewModelLocator: NotifyItems
    {
       // ISaver save=new SaveJson();
       // ILoader load=new LoadJson();
        IKernel kernel;
        //  public ICommand LoadJsonCommand { get; set; }
        // public ICommand SaveJsonCommand { get; set; }
      
        MainViewModel mainView;

        public ViewModelLocator()
        {
            kernel = new StandardKernel(new MyDIModule());
           
           // LoadJsonCommand = new RelayCommand(x => LoadViewModel());
           // SaveJsonCommand = new RelayCommand(x => SaveViewModel());
        }
        public MainViewModel MainViewModel
        {
            get => kernel.Get<MainViewModel>();
        }

      
        //public void LoadViewModel()
        //{
        //    MainViewModel = load.LoadFromJson();
        //    if (mainView == null)
        //        mainView= kernel.Get<MainViewModel>();


        //}
        //public void SaveViewModel()
        //{
        //    save.SaveToJson(mainView);
        //}
    }

}
