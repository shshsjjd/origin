using EasyCaptcha.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Логика взаимодействия для Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        string answer;
        public Loginpage()
        {
            InitializeComponent();
            Cap.CreateCaptcha(Captcha.LetterOption.Alphanumeric, 5);
            answer = Cap.CaptchaText;
            Guest.Background = new SolidColorBrush(Color.FromRgb(204, 102, 0));
            Enter.Background = new SolidColorBrush(Color.FromRgb(204, 102, 0));
        }

        public enum LetterOption
        {
            Number,
            Alphabet,
            Alphanumeric,
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            User usr = new User()
            {
                UserRole = 4,
            };

            Manager.MainFrame.Navigate(new ShopPage(usr));
        }
        bool CheckCap = false;
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            var context = new TradeEntities();
            var User = context.User.Where(u => u.UserLogin == ULogin.Text && u.UserPassword == UPass.Password).FirstOrDefault();

            if (User != null)
            {
                if (!CheckCap)
                {
                    Manager.MainFrame.Navigate(new ShopPage(User));
                }
                else if (CheckCap && answer == CapAnsw.Text)
                {
                    Manager.MainFrame.Navigate(new ShopPage(User));
                }
                else
                {
                    Cap.CreateCaptcha(EasyCaptcha.Wpf.Captcha.LetterOption.Alphanumeric, 4);
                    answer = Cap.CaptchaText;
                }


            }
            else
            {
                CheckCap = true;
                MessageBox.Show("Ошибка!");
            }


        }
    }
}
