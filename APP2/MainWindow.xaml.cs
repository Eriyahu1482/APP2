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

namespace APP2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            black.Visibility = Visibility.Hidden;
            red.Visibility = Visibility.Visible;
        }

        private void red_Click(object sender, RoutedEventArgs e)
        {
            black.Visibility = Visibility.Visible;
            red.Visibility = Visibility.Hidden;
        }
    }
}
