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

namespace WpfAppMirea.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageCreateAcc.xaml
    /// </summary>
    public partial class PageCreateAcc : Page
    {
        public PageCreateAcc()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationData.NavigatePage.GoBack();
        }

        private void BtnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //if (ConnectOdb.connectionPoint.User.Select(x => x.Login).Contains(TxbLogin.Text))
                //    MessageBox.Show("Пользователь с таким логином есть");

                if (ConnectOdb.connectionPoint.User.Count(x => x.Login == TxbLogin.Text) > 0)
                    MessageBox.Show("Пользователь с таким логином есть");
                else {
                    User userObj = new User()
                    {
                        Login = TxbLogin.Text,
                        Password = TxbRePass.Text,
                        RoleId = 1,
                        Name = TxbName.Text
                    };

                    ConnectOdb.connectionPoint.User.Add(userObj);
                    ConnectOdb.connectionPoint.SaveChanges();
                    MessageBox.Show("Информация успешно добавлена", "Успех", 
                                    MessageBoxButton.OK, 
                                    MessageBoxImage.Information);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
