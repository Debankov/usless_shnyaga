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

namespace Session2
{
    /// <summary>
    /// Логика взаимодействия для Permissons.xaml
    /// </summary>
    public partial class Permissons : Window
    {
        public Permissons()
        {
            InitializeComponent();
            var user = strajnikEntities.GetContext().User.Where(x => x.id == ViewModel.user_id).FirstOrDefault();
            FIOBlock.Text = user.lname + " " + user.fname + " " + user.mname;
        }

        private void SaveButton_click(object sender, RoutedEventArgs e)
        {
            strajnikEntities content = new strajnikEntities();

            User user = new User
            {
                fname = FNAME.Text,
                lname = LNAME.Text,
                mname = MNAME.Text,
                post = POST.Text,
                
            };

            content.User.Add(user);
            content.SaveChanges();
            MessageBox.Show("Пользователь создан", "АЛЕРТ");
            HomeWindow homewindow = new HomeWindow();
            homewindow.Show();
            this.Close();
        }

        private void ExitButton_click(object sender, RoutedEventArgs e)
        {
            HomeWindow homewindow = new HomeWindow();
            homewindow.Show();
            this.Close();
        }
    }
}
