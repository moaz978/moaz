using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        Task _select =new Task();
        taskEntities3 _con = new taskEntities3();
        public Window2()
        {
            InitializeComponent();
            load();
            
            
           
           
        }
        private void load()
        {

            list1.ItemsSource= _con.Tasks.ToList();
            
        }
        private void load2()
        {
            
            state.Text = comp.Text;
            if (_select.taske_id == int.Parse(id.Text) && state.Text == "compeleted")
            {
                //var i= _con.Tasks.Where(p=> p.taske_id==int.Parse(id.Text)).Contains(_select.task_descrip,_select.task_title,_select.employee_name,_select.task_duedate);
                list2.ItemsSource = _con.Tasks.ToList();
                //list2.ItemsSource = 

            }
            

        }
        
        
      
        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list1.SelectedItem is Task task)
            {
                _select = task;

                id.Text=_select.taske_id.ToString();
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _select.task_status = comp.Text;
            _con.SaveChanges();
            
            load2();

        }

        private void list2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           


        }

       
    }
}
