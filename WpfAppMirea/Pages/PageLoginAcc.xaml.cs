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
using WpfAppMirea.Pages.AdminData;
using WpfAppMirea.Pages.UserData;

namespace WpfAppMirea.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLoginAcc.xaml
    /// </summary>
    public partial class PageLoginAcc : Page
    {
        public PageLoginAcc()
        {
            InitializeComponent();

            
        }

        private void BtnCreateAcc_Click(object sender, RoutedEventArgs e)
        {
            NavigationData.NavigatePage.Navigate(new PageCreateAcc());
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var userData = ConnectOdb.connectionPoint.User.FirstOrDefault(
                    x => x.Login == TxbLogin.Text && x.Password == PsbPass.Password
                    );

                if (userData != null)
                {
                    MessageBox.Show($"Вы успешно вошли! Ваше имя: {userData.Name}");
                    switch (userData.Role.Name)
                    {
                        case "Админ":
                            NavigationData.NavigatePage.Navigate(new MainPageAdmin());
                            break;
                        case "Клиент":
                            NavigationData.NavigatePage.Navigate(new MainPageClient());
                            break;
                        default:
                            break;
                    }
                }
                else MessageBox.Show("Данные не корректны!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
