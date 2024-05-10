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
using ThreeAPIInUsing.Components.RandomFact;

namespace ThreeAPIInUsing.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatPage.xaml
    /// </summary>
    public partial class CatPage : Page
    {
        HttpClientConvertor httpClientConvertor = new HttpClientConvertor();

        public CatPage()
        {
            InitializeComponent();
        }

        private void NewFactBtn_Click(object sender, RoutedEventArgs e)
        {
            FactTb.Text = httpClientConvertor.GetCatFact().fact;
        }
    }
}
