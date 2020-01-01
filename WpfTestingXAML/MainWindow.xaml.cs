using System.Windows;
using System.Windows.Data;

namespace WpfTestingXAML
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

        private void OnLoad(object sender, RoutedEventArgs e)
        { 
            MessageBox.Show("Something");
        }
    }
}
