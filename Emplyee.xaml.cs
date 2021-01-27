using Microsoft.Win32;
using Prism.Services.Dialogs;
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
using System.Windows.Shapes;

namespace appswindows
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
        string source = "";
        private void suppremer_Copy_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                source = op.FileName.ToString();
                picbox.ImageSource = new BitmapImage(new Uri(op.FileName));
            }
        }
        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            UserControluser usercont = new UserControluser();
            byte[] image = null;
            if (source == "")
            {
                MessageBox.Show("add picture of emplyee");
            }
            else
            {
                FileStream stream = new FileStream(source, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                image = brs.ReadBytes((int)stream.Length);
            }
            emplyee ls = new emplyee();
            gestion_stockEntities td1 = new gestion_stockEntities();
            int ids = int.Parse(id.Text);
            var emp = td1.emplyees.Where(a=> a.id_emp ==ids).Count(); 
            if(emp == 0)
            {
                ls.id_emp = int.Parse(id.Text);
                ls.login_emp = usernime.Text;
                ls.password_emp = password.Password;
                ls.nom = nime.Text;
                ls.Ntele = int.Parse(telephone.Text);
                ls.type_emp = ((ComboBoxItem)catigo.SelectedItem).Content.ToString();
                ls.image_emp = image;
                ls.note = note.Text;
                ls.prenom = second.Text;
                td1.emplyees.Add(ls);
                td1.SaveChanges();
                accpet lm = new accpet();
                lm.Show();
                this.Hide();
                usercont.dataemp.Items.Refresh();
            }
            else
            {
                accpet lm = new accpet();
                lm.Show();
                lm.acp.Visibility = Visibility.Hidden;
                lm.bacp.Visibility = Visibility.Hidden;
                lm.textp.Text = "";
                lm.textp.Text = "emplyee n'est pas accepte";
                lm.@ref.Visibility = Visibility.Visible;
                lm.bref.Visibility = Visibility.Visible;
            }
        }

        private byte[] ImageToBinary(ImageSource imageSource)
        {
            throw new NotImplementedException();
        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
            gestion_stockEntities td1 = new gestion_stockEntities();
            int ids = int.Parse(id.Text);
            emplyee emp = td1.emplyees.Where(a => a.id_emp == ids).First();
            usernime.Text = emp.login_emp;
            password.Password=emp.password_emp;
            nime.Text=emp.nom;
            telephone.Text = emp.Ntele.ToString();
            note.Text= emp.note;
            second.Text =emp.prenom ;
        }

        private void suppremer_Click(object sender, RoutedEventArgs e)
        {
            gestion_stockEntities td1 = new gestion_stockEntities();
            int ids = int.Parse(id.Text);
            emplyee emp = td1.emplyees.Where(a => a.id_emp == ids).First();
            td1.emplyees.Remove(emp);
            td1.SaveChanges();
        }
    }
}
