using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryWpfNinject.Models
{
    interface IItem
    {
        string Title { get; set; }
        string Color { get; set; }
        int Year { get; set; }
        string Image { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
