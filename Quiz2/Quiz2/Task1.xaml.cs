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

namespace Quiz2
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // RESET clears fields
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // SAVE shows user info in MessageBox
            if(txtFirstName.Text != "" && txtLastName.Text != "" && txtPhoneNumber.Text != "")
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string phoneNum = txtPhoneNumber.Text;
                MessageBox.Show($"First Name : {firstName}\nLast Name : {lastName}\nPhone Number : {phoneNum}", "Success", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Please enter all fields", "Incomplete Entry", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
