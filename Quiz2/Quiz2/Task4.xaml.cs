using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        public Task4()
        {
            InitializeComponent();

            //students.Add(new Student { Id = 1, Name = "Steph" });
            //students.Add(new Student { Id = 2, Name = "Devon" });
            //students.Add(new Student { Id = 3, Name = "Trevor" });
            //students.Add(new Student { Id = 4, Name = "Rachel" });
            //students.Add(new Student { Id = 5, Name = "Josh" });
            lstStudents.ItemsSource = students;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            int studentId = Convert.ToInt32(txtId.Text);
            bool studentExists = false;
            // only accepting numbers 1-5
            if (studentId <= 0 || studentId > 5)
            {
                MessageBox.Show("No student with that ID");
            }
            else
            {
                // Available student IDs
                if (students.Count < 1)
                {
                    students.Add(new Student { Id = studentId ,Name = ("Student "+studentId) });
                }
                else
                {
                    foreach (Student std in students)
                    {
                        if (std.Id == studentId)
                        {
                            studentExists = true;
                            MessageBox.Show("This student is already in the list!");
                            break;
                        }
                    }

                    if(!studentExists)
                    {
                        // student is not yet in list, add it!
                        students.Add(new Student { Id = studentId, Name = ("Student " + studentId) });
                    }
                }
            }
        }
    }
}
