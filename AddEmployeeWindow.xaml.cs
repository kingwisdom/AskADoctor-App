using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EmployeeFaceCapure
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
       // AttendanceManager manager;

        public AddEmployeeWindow()
        {
            InitializeComponent();

            int n = App.manager.adddepartment.Count;

            string[] vs = new string[n];
            for (int i = 0; i < n; i++)
            {
                string data = App.manager.adddepartment[i].Name;
                vs[i] = data;
            }
            txtDepartment.ItemsSource = vs;
        }//DataSource = vs;

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string sex = comboSex.Text;
            string email = txtEmail.Text;
            string date = DPdate.Text;
            int salary = int.Parse(txtSalary.Text);
            string department = txtDepartment.Text;

            AddEmployeeClass adc = new AddEmployeeClass(name, sex, email, date, salary, department);
             
            App.manager.AddEmployee(adc);
            dgView.ItemsSource = null;
            dgView.ItemsSource =App.manager.addemployee;

        }

        

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Capture c = new Capture();
            //c.QueryFrame().Convert<Bgr, byte>();

        }
    }
}
