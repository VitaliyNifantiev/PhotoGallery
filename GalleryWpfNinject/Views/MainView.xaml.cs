using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GalleryWpfNinject.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        ResourceDictionary defaultStyle;
        ResourceDictionary temp = new ResourceDictionary();
        public MainView()
        {
           
            InitializeComponent();
            defaultStyle = this.Resources;
        }

        private void cbStyle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cbStyle.SelectedIndex)
            {
                case 0:
                    this.Resources = defaultStyle;
                    break;
                case 1:
                    temp.Source = new Uri($"{Environment.CurrentDirectory}\\Styles\\Font1.xaml");
                    this.Resources = temp;
                    break;
                case 2:
                    temp.Source = new Uri($"{Environment.CurrentDirectory}\\Styles\\Font2.xaml");
                    this.Resources = temp;
                    break;
               
                case 3:
                    temp.Source = new Uri($"{Environment.CurrentDirectory}\\Styles\\Font5.xaml");
                    this.Resources = temp;
                    break;
               
            }
        }
    }
}
