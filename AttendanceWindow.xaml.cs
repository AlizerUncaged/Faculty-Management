using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Threading;

namespace Group3Proj
{
    /// <summary>
    /// Interaction logic for AttendanceWindow.xaml
    /// </summary>
    public partial class AttendanceWindow : Window
    {
        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        public AttendanceWindow()
        {
            InitializeComponent();
        }

        int amount = 550;

        private void ScanButton_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog() is false)
                return;

            imgQR.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            nametxt.Text = decoder.Decode(new QRCodeBitmapImage(new Bitmap(openFileDialog.FileName)));
            SqlCommand sm =
                new SqlCommand(
                    "insert into attendance values('" + nametxt.Text + "','" + timetxt.Text + "','" + datetxt.Text +
                    "','" + amount + "')", DbConnection.Connection);
            sm.ExecuteNonQuery();
            MessageBox.Show("Your Register is Successfully Please Save Your QR Code");
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Loadedtimedate(object sender, RoutedEventArgs e)
        {
            datetxt.Text = DateTime.Now.ToLongTimeString();
            timetxt.Text = DateTime.Now.ToLongDateString();
        }
    }
}