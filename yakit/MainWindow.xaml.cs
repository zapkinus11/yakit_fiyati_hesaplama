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

namespace yakit
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void HesaplaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double km = double.Parse(kilometreTextBox.Text);
                double yakitTuketimi = double.Parse(yakitTuketimiTextBox.Text);
                double yakitFiyati = double.Parse(yakitFiyatiTextBox.Text);

                // yakıt hesaplama
                double yakitMaliyeti = (km / 100) * yakitTuketimi * yakitFiyati;

                sonucLabel.Content = "Toplam Kullanılan Yakıt Maliyeti: " + yakitMaliyeti.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal değer giriniz!!!", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
