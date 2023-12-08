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
using EkzamenUtkin.Pages;
using EkzamenUtkin.ApplicationData;

namespace EkzamenUtkin.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnToComeIn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = BD_UtkinEntities1.GetContext().Users.FirstOrDefault(x => x.U_Login == txbLogin.Text && x.U_Parol == psbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Пользователь с таким логином и паролем не найден!", "Ошибка Авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    

                    AppFrame.MainFrame.Navigate(new PageTovar());

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка:" + Ex.Message.ToString(), "Критическая работа приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}

