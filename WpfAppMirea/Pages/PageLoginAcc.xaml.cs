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
    }
}
