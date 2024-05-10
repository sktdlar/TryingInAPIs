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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThreeAPIInUsing.Components.Dogs;
using ThreeAPIInUsing.Components.RandomFact;

namespace ThreeAPIInUsing.Pages
{
    /// <summary>
    /// Логика взаимодействия для DogPage.xaml
    /// </summary>
    public partial class DogPage : Page
    {
        public DogPage()
        {
            InitializeComponent();
        }
        HttpClientConvertor convertor = new HttpClientConvertor();
        private void NewFactBtn_Click(object sender, RoutedEventArgs e) => DogPic.Source = convertor.DogToImage().GetPicture();
    }
}
