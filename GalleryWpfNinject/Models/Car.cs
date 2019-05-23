using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GalleryWpfNinject.Models
{
    class Car : NotifyItems, IItem
    {
        string image;
        string title;
        string color;
        int year;
        int width;
        int height;
        public string Title
        {
            get => title;
            set
            {
                title = value;
                Notify();
            }
        }
        public string Color
        {
            get => color;
            set
            {
                color = value;
                Notify();
            }
        }
        public int Year
        {
            get => year;
            set
            {
                year = value;
                Notify();
            }
        }
        public string Image
        {
            get => image;
            set
            {
                image = value;
                Notify();
            }
        }
        public int Width
        {
            get => width;
            set
            {
                width = value;
                Notify();
            }
        }

        public int Height
        {
            get => height;
            set
            {
                height = value;
                Notify();
            }
        }
        public Car()
        {
            Title = "Non";
            Color = "Non";
            Year = 0;
            Image = "";
        }
        //static public ObservableCollection<IItem> GetCars()
        //{
        //    return new ObservableCollection<IItem>
        //    {
        //        new Car {Title = "Lexus", Color = "Black", Year = 2017,Image="d:\\1.jpg"},
        //        new Car {Title = "Mazda", Color = "Red", Year = 1999,Image="d:\\1.jpg"},
        //        new Car {Title = "Subaru", Color = "Blue", Year = 2006},
        //        new Car {Title = "Mercedes", Color = "Black", Year = 2012},
        //        new Car {Title = "Bentley", Color = "White", Year = 2015}

        //    };
        //}
    }
}
