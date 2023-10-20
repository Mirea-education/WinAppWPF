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
    /// Логика взаимодействия для PageProfile.xaml
    /// </summary>
    public partial class PageProfile : Page
    {
        public PageProfile(User data)
        {
            InitializeComponent();
            TxbLogin.Text = data.Login;
            TxbNameUser.Text = data.Name;
            TxbRole.Text = data.Role.Name;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationData.NavigatePage.GoBack();
        }
    }
}
