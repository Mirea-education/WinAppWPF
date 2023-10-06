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

namespace WpfAppMirea.Pages.UserData
{
    /// <summary>
    /// Логика взаимодействия для MainPageClient.xaml
    /// </summary>
    public partial class MainPageClient : Page
    {
        public MainPageClient()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationData.NavigatePage.GoBack();
        }
    }
}
