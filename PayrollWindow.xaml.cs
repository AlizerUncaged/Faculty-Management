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

namespace Group3Proj
{
    /// <summary>
    /// Interaction logic for PayrollWindow.xaml
    /// </summary>
    public partial class PayrollWindow : Window
    {
        public PayrollWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Payslip objPayslip = new Payslip();
            this.Visibility = Visibility.Hidden;
            objPayslip.Show();
        }
    }
}
