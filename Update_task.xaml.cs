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
    /// Interaction logic for Update_task.xaml
    /// </summary>
    public partial class Update_task : Window
    {
        private TodoItem todo;
        private TodoDataAccess todoDataAccess;
        public Update_task(TodoItem task)
        {
            InitializeComponent();
            todoDataAccess = new TodoDataAccess();
            todo = task;
            task_title.Text = todo.title;
            task_description.Text = todo.description;
        }

        private void Update_Button_Click(object sender, RoutedEventArgs e)
        {

            TodoItem todoitem = new TodoItem
            {
                id = todo.id,
                title = task_title.Text,
                description = task_description.Text,
                is_complete=todo.is_complete,
            };
            
            todoDataAccess.UpdateTask(todoitem);
            MessageBox.Show(todoitem.title);

        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
        }
    }
}
