using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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

namespace WpfApp17
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        bookstore2Entities db = new bookstore2Entities();
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            


        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
                if (txtID.Text != "" && txtName.Text != "" && txtNationality.Text != "")
                {
                    author auth = new author();
                    int id = int.Parse(txtID.Text);
                    auth.author_id = id;
                    auth.author_name = txtName.Text;
                    auth.nationality = txtNationality.Text;
                    db.authors.Add(auth);
                    db.SaveChanges();
                    Page2 page = new Page2();
                    this.NavigationService.Navigate(page);
                }
                else
                {
                    MessageBox.Show("Enterr!?");
                }
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
