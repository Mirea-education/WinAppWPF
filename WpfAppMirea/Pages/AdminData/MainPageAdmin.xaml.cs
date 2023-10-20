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
using WpfAppMirea.Helper;

namespace WpfAppMirea.Pages.AdminData
{
    /// <summary>
    /// Логика взаимодействия для MainPageAdmin.xaml
    /// </summary>
    public partial class MainPageAdmin : Page
    {
        public MainPageAdmin()
        {
            InitializeComponent();
            GridListUser.ItemsSource = ConnectOdb.connectionPoint.User.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationData.NavigatePage.GoBack();
        }

        private void BtnProfile_Click(object sender, RoutedEventArgs e)
        {
            var data = (sender as Button).DataContext as User;
            NavigationData.NavigatePage.Navigate(new PageProfile(data));
        }

        private void BtnDeleteProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (GridListUser.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < GridListUser.SelectedItems.Count; i++)
                    {
                        User userObj = GridListUser.SelectedItems[i] as User;
                        ConnectOdb.connectionPoint.User.Remove(userObj);
                    }
                    MessageBox.Show("Данные успешно удалены!");
                    ConnectOdb.connectionPoint.SaveChanges();
                    GridListUser.ItemsSource = ConnectOdb.connectionPoint.User.ToList();
                }
                else
                {
                    MessageBox.Show("Данных нет.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnEditProfile_Click(object sender, RoutedEventArgs e)
        {
            var data = (sender as Button).DataContext as User;
            NavigationData.NavigatePage.Navigate(new PageEdit(data));
        }
    }
}
