using System.Windows;
using WpfTest2012.HelperClasses;
using WpfTest2012.Pages;

namespace WpfTest2012
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FrameNav.frameNavigation = FrmMain;
            FrmMain.Navigate(new PageLogin());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrameNav.frameNavigation.CanGoBack)
                FrameNav.frameNavigation.GoBack();
        }

    }
}
