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
    /// Interaction logic for Task2SecondWindow.xaml
    /// </summary>
    public partial class Task2SecondWindow : Window
    {
        public Task2SecondWindow()
        {
            InitializeComponent();
        }

        // pass using constructor
        public Task2SecondWindow(DateTime dateTime)
        {
            InitializeComponent();
            txtDate.Text = dateTime.ToString();
        }
    }
}
