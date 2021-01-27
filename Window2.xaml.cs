using BeautySolutions.View.ViewModel;
using MaterialDesignThemes.Wpf;
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

namespace appswindows
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gestion_stockEntities td1 = new gestion_stockEntities();
                if (user.Text != string.Empty && pass.Password != string.Empty)
                {
                    var users= td1.emplyees.FirstOrDefault(a => a.login_emp.Equals(user.Text));
                    if(users!=null)
                    {
                        if(users.password_emp.Equals(pass.Password))
                        {
                        
                        Window1 ls = new Window1();
                        ls.Show();
                        ls.nime.Text = "";
                        ls.nime.Text = users.nom +" "+ users.prenom;
                        this.Hide();
                            
                        }
                        else
                        {
                        eror.Text = "";
                        eror.Text = "password and usernime not correct !";
                        eror.Visibility = Visibility.Visible;
                        error.Visibility = Visibility.Visible;
                        }
                    }
                }
                else
                {
                eror.Text = "";
                eror.Text = "entrer le mod pass et nom";
                eror.Visibility = Visibility.Visible;
                error.Visibility = Visibility.Visible;

            }
        }

    }
    }
