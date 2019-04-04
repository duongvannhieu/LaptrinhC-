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

namespace nhieu
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            int gt = 1;
            for (int i = 2; i <= n; i++)
            {
                gt = gt * i;
            }
            txtKQ.Text = gt.ToString();
        }

        private void TextBoX_TextChanged(object sender, TextChangedEventArgs e)
        {
            int n = Int32.Parse(txtSoN.Text);
            double s = 1;
            for(int i = 2; i <= n; i++)
            {
                s += (double)Math.Sqrt(i);
            }
            txtKQ.Text = gt.ToString();
        }
    }
}
