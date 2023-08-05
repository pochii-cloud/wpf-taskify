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



        private void TaskListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                var selectedTask = (TodoItem)taskListBox.SelectedItem;
                selectedTask.is_complete = !selectedTask.is_complete; // Mark the task as complete

                todoDataAccess.UpdateTask(selectedTask); // Update the task in the database

                // After updating the task, refresh the ListBox to show the updated tasks.
                List<TodoItem> tasks = todoDataAccess.GetAllTasks();
                taskListBox.ItemsSource = tasks;
            }
        }


        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button deleteButton && deleteButton.Tag is int taskId)
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    todoDataAccess.DeleteTask(taskId);

                    // After deleting the task, you might want to refresh the ListBox to show the updated tasks.
                    List<TodoItem> tasks = todoDataAccess.GetAllTasks();
                    taskListBox.ItemsSource = tasks;
                }
            }
        }

        private void Open_Update_Window(object sender, RoutedEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
               

                var selectedTask = (TodoItem)taskListBox.SelectedItem;

                Update_task updateTaskWindow = new Update_task(selectedTask);
                updateTaskWindow.ShowDialog();

                // After updating the task, refresh the ListBox to show the updated tasks.
                List<TodoItem> tasks = todoDataAccess.GetAllTasks();
                taskListBox.ItemsSource = tasks;
            }
            else
            {
                MessageBox.Show("Please select a task to update.");
            }
            
        }
    }
}
