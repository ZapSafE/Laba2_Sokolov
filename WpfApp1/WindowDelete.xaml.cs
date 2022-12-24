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
using System.Data.Entity;
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для WindowDelete.xaml
    /// </summary>
    public partial class WindowDelete : Window
    {
        public WindowDelete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_Id.Text);
                User user = new User {ID = id};

                using (UsersContext db = new UsersContext())
                {
                    db.Users.Attach(user);
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
                MessageBox.Show("Пользователь удален");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
