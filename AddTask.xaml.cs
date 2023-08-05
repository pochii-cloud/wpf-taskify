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

namespace TASKIFY
{
    /// <summary>
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        private TodoDataAccess todoDataAccess;
        public AddTask()
        {
            InitializeComponent();
            todoDataAccess = new TodoDataAccess();
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            if (title.Text == "" || description.Text == "")
            {
                MessageBox.Show("Please fill in all Fields");
            }
            else
            {
                var newTask = new TodoItem
                {
                    title = title.Text,
                    description = description.Text,
                    is_complete = false // Assuming the default value for new tasks is 'false' for is_complete.
                };

                todoDataAccess.InsertTask(newTask);
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                

            }
        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            this.Hide();
            mainWindow.Show();
        }
    }
}
