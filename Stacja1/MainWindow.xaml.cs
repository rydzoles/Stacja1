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

namespace Stacja1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListOfProductAndPrices lst = new ListOfProductAndPrices();
            lst.NameAndPrice();
           
        }
        int count = 1;
        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            //   count++;
            while (sender.Equals(true))
            {
                textBox.Text += count.ToString();
            }
           
        }
        
    }
}
