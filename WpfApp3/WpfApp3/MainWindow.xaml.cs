using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        taskEntities3 _con = new taskEntities3();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var l= _con.members.FirstOrDefault(a=> a.user_name==name.Text && a.user_password == password.Text&&/*a.user_role==manag.Content.ToString()&&*/a.user_role== "employee");
            var v = _con.members.FirstOrDefault(a => a.user_name == name.Text && a.user_password == password.Text && /*a.user_role == emp.Content.ToString()&&*/a.user_role=="manager");
            if (v != null )
            { MessageBox.Show("welcom admin");
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            else if (l!=null)
            {
                MessageBox.Show("welcom user");
                Window2 window2 = new Window2();
                window2.Show();
                this.Close();
            }
            else { MessageBox.Show("invalid login"); }

            
        }
    }
}
