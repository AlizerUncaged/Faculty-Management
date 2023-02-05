using System.Windows;
using System.Data.SqlClient;

namespace Group3Proj
{
    /// <summary>
    /// Interaction logic for Payslip.xaml
    /// </summary>
    public partial class Payslip : Window
    {
        public Payslip()
        {
            InitializeComponent();
        }

        int amount = 550;

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand sm = new SqlCommand(
                "insert into payslip values('" + pnametxt.Text + "','" + positiontxt.Text + "','" + amount + "','" +
                hrworktxt + "','" + ratetxt.Text + "','" + philnotxt + "','" + ssstxt.Text + "','" + amounttxt + "')",
                DbConnection.Connection);
            sm.ExecuteNonQuery();
            MessageBox.Show("Your Register is Successfully Please Save Your QR Code");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            PayrollWindow objPayrollWindow = new PayrollWindow();
            this.Visibility = Visibility.Hidden;
            objPayrollWindow.Show();
        }
    }
}