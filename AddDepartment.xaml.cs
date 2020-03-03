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
    /// Interaction logic for AddDepartment.xaml
    /// </summary>
    public partial class AddDepartment : Window
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string opHr = OpenHr.Text;
            string opMin = OpenMin.Text;
            string openAP = OpenAmPm.Text;

            string clHr = CloseHr.Text;
            string clMin = CloseMin.Text;
            string closeAP = CloseAmPm.Text;

            string openTime = opHr+":" + opMin+" "+ openAP;
            string closeTime = clHr +":" + clMin+" " + closeAP;

            AddDepartments ad = new AddDepartments(name, openTime, closeTime);

            //AttendanceManager manager = new AttendanceManager();
            App.manager.AddDepartment(ad);
            Departgrid.ItemsSource = null;
            Departgrid.ItemsSource = App.manager.adddepartment;

            
        }
    }
}
