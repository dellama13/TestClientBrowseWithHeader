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
using CefSharp;
using TestClientBrowseWithHeader.Properties;
using CefSharp.Core;
using CefSharp.Handler;

namespace TestClientBrowseWithHeader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
            BrowserBox.Address = "https://google.com";

            
        }

        private void NavButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            BrowserBox.Address = AddrBox.Text;
        }

        private void HeaderButton_Click(object sender, RoutedEventArgs e)
        {

            var Bob = BrowserBox.BrowserSettings;



        }
       





    }
}
