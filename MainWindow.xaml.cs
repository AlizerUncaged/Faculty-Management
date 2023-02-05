using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Group3Proj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1(object sender, RoutedEventArgs e)
        {
            RegisterWindow objregisterWindow = new RegisterWindow();
            this.Visibility = Visibility.Hidden;
            objregisterWindow.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void Button2(object sender, RoutedEventArgs e)
        {
            AttendanceWindow objAttendanceWindow = new AttendanceWindow();
            this.Visibility = Visibility.Hidden;
            objAttendanceWindow.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void Button3(object sender, RoutedEventArgs e)
        {
            PayrollWindow objPayrollWindow = new PayrollWindow();
            this.Visibility = Visibility.Hidden;
            objPayrollWindow.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void Button4(object sender, RoutedEventArgs e)
        {
            AttendanceRecordWindow objAttendanceRecordWindow = new AttendanceRecordWindow();
            this.Visibility = Visibility.Hidden;
            objAttendanceRecordWindow.ShowDialog();
            this.Visibility = Visibility.Visible;
        }

        private void MainWindowClosing(object sender, CancelEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}