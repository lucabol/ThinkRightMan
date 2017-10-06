using System;
using System.Collections.Generic;
using System.IO;
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

namespace ThinkRightMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] _messages = File.ReadAllLines("Messages.txt");
        static int _lenght = _messages.Length;
        static int _count = 0;

        public MainWindow()
        {
            InitializeComponent();
            ShowMessage();
        }

        private void ShowMessage()
        {
            this.Message.Text = _messages[_count];
            _count = (_count + 1) % _lenght;
        }
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            ShowMessage();
        }

        private void Skip_Click(object sender, RoutedEventArgs e)
        {
            _count = 0;
            ShowMessage();
        }       
    }
}
