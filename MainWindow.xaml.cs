using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MoveSelection(HomeButton, false);
        }

        private void LaunchFirefox_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Program Files\Mozilla Firefox\firefox.exe");

        private void HomeButton_Click(object sender, RoutedEventArgs e) =>
            MoveSelection(HomeButton);

        private void LibraryButton_Click(object sender, RoutedEventArgs e) =>
            MoveSelection(LibraryButton);

        private void LaunchSteam_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Program Files (x86)\Steam\steam.exe");

        private void LaunchDiscord_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Users\selho\AppData\Local\Discord\app-1.0.9251\Discord.exe");

        private void Configs_Click(object sender, RoutedEventArgs e) =>
            OpenApp(@"C:\Program Files\WindowsApps\Microsoft.WindowsNotepad_11.2605.34.0_x64__8wekyb3d8bbwe\Notepad\Notepad.exe");

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

        private void CloseAppButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MoveSelection(FrameworkElement button, bool animate = true)
        {
            Point buttonPosition = button.TranslatePoint(
                new Point(
                    button.ActualWidth / 2,
                    button.ActualHeight / 2
                ),
                Sidebar
            );

            double newPosition =
                buttonPosition.Y - (SelectionIndicator.ActualHeight / 2);

            if (!animate)
            {
                SelectionTransform.BeginAnimation(
                    TranslateTransform.YProperty,
                    null
                );

                SelectionTransform.Y = newPosition;
                return;
            }

            var animation = new DoubleAnimation
            {
                To = newPosition,
                Duration = TimeSpan.FromMilliseconds(200),
                EasingFunction = new QuadraticEase
                {
                    EasingMode = EasingMode.EaseOut
                }
            };

            SelectionTransform.BeginAnimation(
                TranslateTransform.YProperty,
                animation
            );
        }
    }
}