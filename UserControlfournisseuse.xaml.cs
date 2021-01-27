using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for UserControlProviders.xaml
    /// </summary>
    public partial class UserControlProviders : UserControl
    {
        public UserControlProviders()
        {
            InitializeComponent();
        }

        private void addprovider_Click(object sender, RoutedEventArgs e)
        {
            fournisoureee lm = new fournisoureee();
            lm.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fournisoureee ls = new fournisoureee();
            ls.Show();
            ls.nime.Visibility = Visibility.Hidden;
            ls.adress.Visibility = Visibility.Hidden;
            ls.note.Visibility = Visibility.Hidden;
            ls.telephone.Visibility = Visibility.Hidden;
            ls.usericon.Visibility = Visibility.Hidden;
            ls.adressicon.Visibility = Visibility.Hidden;
            ls.noteicon.Visibility = Visibility.Hidden;
            ls.phoneicon.Visibility = Visibility.Hidden;
            ls.reshersher.Visibility = Visibility.Visible;
            ls.ajouter.Visibility = Visibility.Hidden;
        
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            gestion_stockEntities td1 = new gestion_stockEntities();
            datafor.ItemsSource = td1.fornisuers.ToList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
