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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        taskEntities3 _context= new taskEntities3();
        Task _select = new Task();
        
        public Window1()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            list.ItemsSource=_context.Tasks.ToList();
        }
        private void clear()
        {
            id.Text = " ";
            title.Text = " ";
            descrip.Text = " ";
            state.Text = " ";  
            empname.Text = " "; 
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(list.SelectedItem is Task task)
            {
                _select=task;

                id.Text=_select.taske_id.ToString();
                title.Text = _select.task_title;
                descrip.Text = _select.task_descrip;
                state.Text = _select.task_status;
                empname.Text = _select.employee_name;
                

            }



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = new Task
            {
                taske_id=int.Parse(id.Text),
                task_descrip=descrip.Text,
                task_status=state.Text,
                task_title=title.Text,
                employee_name=empname.Text,
                task_duedate= DateTime.Now,
            };
            _context.Tasks.Add(x);
            _context.SaveChanges();
            load();
            clear();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _select.taske_id = int.Parse(id.Text);
            _select.task_descrip = descrip.Text;
            _select.task_status = state.Text;
            _select.task_title = title.Text;
            _select.employee_name = empname.Text;
            _context.SaveChanges();
            load();
            clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _context.Tasks.Remove(_select);
            _context.SaveChanges();
            load();
            clear();
        }
    }
}
