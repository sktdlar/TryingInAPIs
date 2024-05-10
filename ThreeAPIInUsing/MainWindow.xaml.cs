using System.Text;
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
using ThreeAPIInUsing.Pages;

namespace ThreeAPIInUsing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new DogPage());
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CatPage());
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate (new DogPage());
        }

        private void Third_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new GenderFromName());
        }
    }
}