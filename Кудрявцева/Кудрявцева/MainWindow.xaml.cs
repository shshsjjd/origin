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

namespace Кудрявцева
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            back.Background = new SolidColorBrush(Color.FromRgb(204, 102, 0));
            
            MainFrame.Navigate(new Loginpage());
            Manager.MainFrame = MainFrame;
            Header.Background = new SolidColorBrush(Color.FromRgb(255, 204, 153));
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                back.Visibility = Visibility.Visible;
            }
            else
            {
                back.Visibility = Visibility.Hidden;
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void bin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
