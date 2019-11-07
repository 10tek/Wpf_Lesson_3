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

namespace BaseElementsLesson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //searchBtn.Click += tab najat` 1 variant
            //searchBtn.Click += (sender, args) => { }; 2 variant

        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            browser.Navigate($"https://www.{searchTB.Text}");
        }
    }
}
