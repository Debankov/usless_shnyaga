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
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            var user = strajnikEntities.GetContext().User.Where(x => x.id == ViewModel.user_id).FirstOrDefault();
            FIOBlock.Text = user.lname + " " + user.fname + " " + user.mname;

            if(ViewModel.user_post == "Специалист по ИБ")
            {
                PermissonButton.Visibility = Visibility.Visible;
                MandatButton.Visibility = Visibility.Visible;
            }
            else if(ViewModel.user_post == "Администратор доступа")
            {
                PermissonButton.Visibility = Visibility.Visible;
            }
        }

        private void MandatPermission_click(object sender, RoutedEventArgs e)
        {
            Mandat mandat = new Mandat();
            mandat.Show();
            this.Close();
        }

        private void ManagePermisson_click(object sender, RoutedEventArgs e)
        {
            Permissons permissons = new Permissons();
            permissons.Show();
            this.Close();

        }

    }
}
