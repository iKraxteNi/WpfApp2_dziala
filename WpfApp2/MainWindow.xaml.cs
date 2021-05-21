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

namespace WpfApp2
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

        private void Buttonw_Click(object sender, RoutedEventArgs e)
        {
            if (RBt.IsChecked == true )
            {
                MessageBox.Show(TB.Text);
            }
            else
            {
                MessageBox.Show("no to nie");
            }
                
        }

        private void ChexkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            Buttonw.IsEnabled = false;
        }

        private void ChexkBox1_Checked(object sender, RoutedEventArgs e)
        {
            Buttonw.IsEnabled = true;
        }
    }
}
