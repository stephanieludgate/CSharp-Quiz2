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
    /// Interaction logic for Task2.xaml
    /// </summary>
    public partial class Task2 : Window
    {
        public Task2()
        {
            InitializeComponent();
            // set default date selected to today
            myCalendar.SelectedDate = DateTime.Now;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDay = (DateTime)myCalendar.SelectedDate;
            Task2SecondWindow window = new Task2SecondWindow(selectedDay);
            window.Show();
        }
    }
}
