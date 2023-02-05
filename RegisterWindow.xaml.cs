using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using MessagingToolkit.QRCode.Codec;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace Group3Proj
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        QRCodeEncoder encoder = new QRCodeEncoder();
        Bitmap bitmap;
        SaveFileDialog saveFile = new SaveFileDialog();

        public RegisterWindow()
        {
            InitializeComponent();
        }

        public void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand sm =
                new SqlCommand(
                    "insert into registerFinal values('" + nametxt.Text + "','" + idtxt.Text + "','" +
                    positiontxt.Text + "','" + addresstxt.Text + "')", DbConnection.Connection);
            sm.ExecuteNonQuery();
            
            MessageBox.Show("Your Register is Successfully Please Save Your QR Code");
            encoder.QRCodeScale = 8;
            bitmap = encoder.Encode(nametxt.Text);
            imgQR.Source = ConverterImage.ToBitmapImage(bitmap);
        }


        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            saveFile.Filter = "PNG|*.png";
            saveFile.FileName = nametxt.Text;
            if (saveFile.ShowDialog() == true)
            {
                if (bitmap != null)
                {
                    bitmap.Save(string.Concat(saveFile.FileName), ImageFormat.Png);
                }
            }
        }
    }
}