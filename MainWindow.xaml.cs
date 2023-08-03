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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TASKIFY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TodoDataAccess todoDataAccess;
        public MainWindow()
        {
            InitializeComponent();
            todoDataAccess = new TodoDataAccess();
            List<TodoItem> tasks = todoDataAccess.GetAllTasks();
            taskListBox.ItemsSource = tasks;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddTask addTask= new AddTask();
            addTask.Show();
            Console.WriteLine("add task open");
            this.Close();
        }
    }
}
