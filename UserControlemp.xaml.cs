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

namespace appswindows
{
    /// <summary>
    /// Interaction logic for UserControluser.xaml
    /// </summary>
    public partial class UserControluser : UserControl
    {
        public UserControluser()
        {
            InitializeComponent();
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addemp_Click_1(object sender, RoutedEventArgs e)
        {
            Window3 ls = new Window3();
            ls.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 ls = new Window3();
            ls.Show();
            ls.ajouter.Visibility = Visibility.Hidden;
            ls.modifier.Visibility = Visibility.Visible;

        }

        private void delete2_Click(object sender, RoutedEventArgs e)
        {
            Window3 ls = new Window3();
            ls.Show();
            ls.ajouter.Visibility = Visibility.Hidden;
            ls.suppremer.Visibility = Visibility.Visible;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            gestion_stockEntities td1 = new gestion_stockEntities();
            dataemp.ItemsSource = td1.emplyees.ToList();
        }

        private void dataemp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
