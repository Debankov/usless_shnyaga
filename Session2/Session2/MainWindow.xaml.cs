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

namespace Session2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PassBox.Password;
            string secret = SecretBox.Password;
            string post = PostBox.Text;
            bool valid = false;



            var users = strajnikEntities.GetContext().User.ToList();

            foreach(var user in users)
            {
                if(login == user.login && password == user.password && secret == user.secret_prhase && post == user.post)
                {
                    valid = true;
                    ViewModel.user_id = user.id;
                    ViewModel.user_post = user.post;
                    MessageBox.Show("Успешна авторизация", "АЛЕРТ");
                    HomeWindow homeWindow = new HomeWindow();
                    homeWindow.Show();
                    this.Close();
                    break;
                }
            }
            if(!valid)
            MessageBox.Show("Такого пользователя не cущесвутет", "АЛЕРТ");

        }
    }
}
