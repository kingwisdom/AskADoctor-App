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

namespace EmployeeFaceCapure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //AttendanceManager manager = new AttendanceManager();
            InitializeComponent();
        }
        //public AttendanceManager manager = new AttendanceManager();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddDepartment ad = new AddDepartment();
            ad.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow ae = new AddEmployeeWindow();
            ae.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }

    
}
