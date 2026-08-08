using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Main_Window
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

        private void LaunchFirefox_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Program Files\Mozilla Firefox\firefox.exe");

        private void LaunchSteam_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Program Files (x86)\Steam\steam.exe");

        private void LaunchDiscord_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Users\selho\AppData\Local\Discord\app-1.0.9251\Discord.exe");

        private void Configs_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Users\selho\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup");

        private void OpenApp(string path)
        {
            try
            {
                ProcessStartInfo startInfo = new()
                {
                    FileName = path,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open application: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}