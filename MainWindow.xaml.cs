using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace AutoClickerGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("./AutoCLicker.dll")]
        static extern void ClickTimes(int times, int delay);
        [DllImport("./AutoCLicker.dll")]
        static extern void initAutoClicker();
        [DllImport("./AutoCLicker.dll")]
        static extern void Mode();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            initAutoClicker();
        }

        private void Mode_Click(object sender, RoutedEventArgs e)
        {
            Mode();
        }



        private void ClickTimes_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int.TryParse(((TextBox)FindName("Delay")).Text, out int delay);
                int.TryParse(((TextBox)sender).Text, out int clickTimes);
                ClickTimes(clickTimes, delay);
            }
            catch (Exception easd)
            {
            }
        }

        private void Delay_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int.TryParse(((TextBox)FindName("Click_Times")).Text, out int clickTimes);
                int.TryParse(((TextBox)sender).Text, out int delay);
                ClickTimes(clickTimes, delay);
            }
            catch (Exception easd)
            {
            }
        }
    }
}
