using System.Windows;

namespace KohYoungTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // separate data logic from view by setting data context
            DataContext = new MainVM();
        }

       
    }
}
