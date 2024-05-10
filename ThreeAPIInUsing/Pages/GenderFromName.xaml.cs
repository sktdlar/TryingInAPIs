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
    /// Логика взаимодействия для GenderFromName.xaml
    /// </summary>
    public partial class GenderFromName : Page
    {
        public GenderFromName()
        {
            InitializeComponent();
        }

        private void NewAgeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(NameTb.Text.Length == 0)
            {
                
            }
            else
            {
                HttpClientConvertor convertor = new HttpClientConvertor();
                ResultTb.Text = "Ваш возраст... Кажется вам " + convertor.AgeFromName(NameTb.Text).age.ToString();
            }
        }
    }
}
