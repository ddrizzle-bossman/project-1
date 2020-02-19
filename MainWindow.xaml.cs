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

namespace _193937Project1
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

        private void CheckBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
   
        private void chkCPU_Unchecked(object sender, RoutedEventArgs e)
        {
            cpuDetails.Visibility = Visibility.Collapsed;
            cpuImage.Visibility = Visibility.Collapsed;
        }

        private void chkMTB_Unchecked(object sender, RoutedEventArgs e)
        {
            mtbDetails.Visibility = Visibility.Collapsed;
            mtbImage.Visibility = Visibility.Collapsed;
        }

        private void chkMTB_Checked(object sender, RoutedEventArgs e)
        {
            mtbDetails.Visibility = Visibility.Visible;
            mtbImage.Visibility = Visibility.Visible;
        }

        private void chkCPU_Checked(object sender, RoutedEventArgs e)
        {
            cpuDetails.Visibility = Visibility.Visible;
            cpuImage.Visibility = Visibility.Visible;
        }

        private void chkCPUC_Checked(object sender, RoutedEventArgs e)
        {
            cpucDetails.Visibility = Visibility.Visible;
            cpucImage.Visibility = Visibility.Visible;
        }

        private void chkCPUC_Unchecked(object sender, RoutedEventArgs e)
        {
            cpucDetails.Visibility = Visibility.Collapsed;
            cpucImage.Visibility = Visibility.Collapsed;
        }
    }
}
