using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        private static User userObj { get; set; }
        public PageEdit(User data)
        {
            InitializeComponent();

            userObj = data;
            TxbLogin.Text = data.Login;
            TxbName.Text = data.Name;
            TxbPass.Text = data.Password;

            CmbSelectRole.DisplayMemberPath = "Name";
            CmbSelectRole.SelectedValuePath = "Id";
            CmbSelectRole.ItemsSource = ConnectOdb.connectionPoint.Role.ToList();
            
            CmbSelectRole.Text = data.Role.Name;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<User> userList = ConnectOdb.connectionPoint.User
           .Where(x => x.Id == userObj.Id)
           .AsEnumerable()
           .Select(y => {
               y.Login = TxbLogin.Text;
               y.Name = TxbName.Text;
               y.Password = TxbPass.Text;
               y.Role = CmbSelectRole.SelectedItem as Role;
               return y;
           });

            foreach (User userData in userList)
            {
                ConnectOdb.connectionPoint.Entry(userData).State = EntityState.Modified;
            }

            ConnectOdb.connectionPoint.SaveChanges();
            MessageBox.Show("Изменения внесены!");
        }
    }
}
