using System.Data.SqlClient;
using System.Windows;

namespace Group3Proj
{
    /// <summary>
    /// Interaction logic for AttendanceRecordWindow.xaml
    /// </summary>
    public partial class AttendanceRecordWindow : Window
    {
        public AttendanceRecordWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            // MainWindow objMainWindow = new MainWindow();
            // this.Visibility = Visibility.Hidden;
            // objMainWindow.Show();
            this.Close();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Group3Proj.dbAttendanceDataSet dbAttendanceDataSet =
                ((Group3Proj.dbAttendanceDataSet)(this.FindResource("dbAttendanceDataSet")));
            Group3Proj.dbAttendanceDataSetTableAdapters.attendanceTableAdapter
                dbAttendanceDataSetattendanceTableAdapter =
                    new Group3Proj.dbAttendanceDataSetTableAdapters.attendanceTableAdapter();
            dbAttendanceDataSetattendanceTableAdapter.Fill(dbAttendanceDataSet.attendance);
            System.Windows.Data.CollectionViewSource attendanceViewSource =
                ((System.Windows.Data.CollectionViewSource)(this.FindResource("attendanceViewSource")));
            attendanceViewSource.View.MoveCurrentToFirst();
        }
    }
}