using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {

        string RN;

        public ShopPage(User usr)
        {
           
            InitializeComponent();
            bbin.Background = new SolidColorBrush(Color.FromRgb(204, 102, 0));
            switch (usr.UserRole)
            {
                case 4:
                    RN = RN = "Гость";
                    break;

                case 1:
                    RN = "Клиент";
                    break;

                case 2:
                    RN = "Менеджер";
                    break;

                case 3:
                    RN = "Администратор";
                    break;


            }
            role.Text = RN;
        }

        private void bbin_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new bin());
        }
    }
}
