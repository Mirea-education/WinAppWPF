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
using WpfAppMirea.Pages;

namespace WpfAppMirea
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ConnectOdb.connectionPoint = new MireaLoginEntities();

            NavigationData.NavigateFooter = FrmFooter;
            NavigationData.NavigateHeader = FrmHeader;
            NavigationData.NavigatePage = FrmBody;

            FrmFooter.Navigate(new PageFooter());
            FrmHeader.Navigate(new PageHeader());
            FrmBody.Navigate(new PageLoginAcc());

        }

    }
}
