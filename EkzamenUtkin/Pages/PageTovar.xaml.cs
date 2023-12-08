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
using EkzamenUtkin.ApplicationData;
using EkzamenUtkin.Pages;

namespace EkzamenUtkin.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTovar.xaml
    /// </summary>
    public partial class PageTovar : Page
    {
        public PageTovar()
        {
            InitializeComponent();
            DGridTovar.ItemsSource = BD_UtkinEntities1.GetContext().Tovar_Dekor.ToList();
        }

        private void DGridTovar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DGridTovar_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.MainFrame.Navigate(new PageLogin());
        }
    }
}
