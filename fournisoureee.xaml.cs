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
using System.Windows.Shapes;

namespace appswindows
{
    /// <summary>
    /// Interaction logic for fournisoureee.xaml
    /// </summary>
    public partial class fournisoureee : Window
    {
        public fournisoureee()
        {
            InitializeComponent();
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
                adpic3.ImageSource = new BitmapImage(new Uri(op.FileName));
            }
        }
        private void ajouter_Click(object sender, RoutedEventArgs e)
        {
            UserControluser usercont = new UserControluser();
            byte[] image = null;
            FileStream stream = new FileStream(source, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            image = brs.ReadBytes((int)stream.Length);
            fornisuer ls = new fornisuer();
            gestion_stockEntities td1 = new gestion_stockEntities();
            int ids = int.Parse(id.Text);
            var forni = td1.fornisuers.Where(a => a.id_fornisuer == ids).Count();
            if (forni == 0)
            {
                ls.id_fornisuer = ids;
                ls.nom_fourniseur = nime.Text;
                ls.tele_forniseur = telephone.Text;
                ls.address_forniseur = adress.Text;
                ls.image = image;
                ls.note_forniseur = note.Text;
                td1.fornisuers.Add(ls);
                td1.SaveChanges();
                accpet lm = new accpet();
                lm.Show();
                this.Hide();
            }
            else
            {
                accpet lm = new accpet();
                lm.Show();
                lm.acp.Visibility = Visibility.Hidden;
                lm.bacp.Visibility = Visibility.Hidden;
                lm.textp.Text = "";
                lm.textp.Text = "fourniseur n'est pas accepte";
                lm.@ref.Visibility = Visibility.Visible;
                lm.bref.Visibility = Visibility.Visible;
            }
        }

        private void modifier_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void reshersher_Click(object sender, RoutedEventArgs e)
        {
            gestion_stockEntities td1 = new gestion_stockEntities();
            int ids = int.Parse(id.Text);
            fornisuer fors = td1.fornisuers.Where(a => a.id_fornisuer == ids).First();
            nime.Visibility = Visibility.Visible;
            adress.Visibility = Visibility.Visible;
            note.Visibility = Visibility.Visible;
            telephone.Visibility = Visibility.Visible;
            usericon.Visibility = Visibility.Visible;
           adressicon.Visibility = Visibility.Visible;
            noteicon.Visibility = Visibility.Visible;
            phoneicon.Visibility = Visibility.Visible;
            reshersher.Visibility = Visibility.Hidden;
            modifier.Visibility = Visibility.Visible;
            nime.Text = fors.nom_fourniseur;
            telephone.Text = fors.tele_forniseur;
            note.Text = fors.note_forniseur;
        }


        private void telephone_TextChanged(object sender, TextChangedEventArgs e)
        {
            string actualdata = string.Empty;
            char[] entereddata = telephone.Text.ToCharArray();
            foreach (char aChar in entereddata.AsEnumerable())
            {
                if (Char.IsDigit(aChar))
                {
                    actualdata = actualdata + aChar;
                    // MessageBox.Show(aChar.ToString());
                }
                else
                {
                    MessageBox.Show(aChar + " is not numeric");
                    actualdata.Replace(aChar, ' ');
                    actualdata.Trim();
                    warning.Visibility = Visibility.Visible;
                }
            }
            telephone.Text = actualdata;
        }
    }
}
