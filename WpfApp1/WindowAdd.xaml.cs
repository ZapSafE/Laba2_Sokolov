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
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //int id = 1;
                string Name = textBox_Name.Text;
                int Age = Convert.ToInt32(textBox_Age.Text);
                string password = textBox_Password.Text;
                string status = textBox_Status.Text;
                User newUser = new User();
              //  newUser.ID = id;
                newUser.Name = Name;
                newUser.Age = Age;
                newUser.Password = password;
                newUser.Status = status;
                using (UsersContext db = new UsersContext())
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                MessageBox.Show("Данные добавлены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
