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

//Shlomo Kalinsky
namespace PresidentEligibilityWPF_GUI_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void eligibility_click(object sender, RoutedEventArgs e)
        {
            int temp = 0;
            if (naturalBornCheckbox.IsChecked == true
                && (DateTime.Now.Year - Int32.Parse(birthTextBox.Text, (System.Globalization.NumberStyles)temp) >= 35)
                && Int32.Parse(residedTextBox.Text, (System.Globalization.NumberStyles)temp) >= 14 &&
                Int32.Parse(priorTermsTextBox.Text, (System.Globalization.NumberStyles)temp) < 2 &&
                Int32.Parse(priorTermsTextBox.Text, (System.Globalization.NumberStyles)temp) > -1
                && rebelledCheckbox.IsChecked == false)
            {
                MessageBox.Show("You are eligible to be president! :)");
            }
            else {
                MessageBox.Show("You are not eligible to be president :(");
            }
        }
    }
}
