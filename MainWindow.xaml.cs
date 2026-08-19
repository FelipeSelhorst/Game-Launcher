using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string nickname = Properties.Settings.Default.Nickname;

            if (string.IsNullOrWhiteSpace(nickname))
            {
                nickname = "User";
            }

            NameInput.Text = nickname;
            TitleTextBlock.Text = $"Hello, {nickname}!";

            LoadProfilePicture();
        }

        private void ProfilePopUp(object sender, RoutedEventArgs e)
        {
            ProfilePopup.IsOpen = true;
        }

        private void ChangeProfilePicture(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new()
            {
                Title = "Choose a profile picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (dialog.ShowDialog() == true)
            {
                string directory = GetPFPDirectory();
                string destination = System.IO.Path.Combine(
                    directory, "profile_picture.png");
                    //Test: ("profile_picture" + System.IO.Path.GetExtension(dialog.FileName));

                File.Copy(dialog.FileName, destination, true);

                Properties.Settings.Default.ProfilePicturePath = destination;
                Properties.Settings.Default.Save();

                LoadProfilePicture();
            }
        }

        private string GetPFPDirectory()
        {
            string directory = System.IO.Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Slowpoke Launcher",
                "Profile"
                );

            Directory.CreateDirectory(directory);

            return directory;
        }

        private void LoadProfilePicture()
        {
            string path = Properties.Settings.Default.ProfilePicturePath;

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                BitmapImage image = new BitmapImage();

                image.BeginInit();
                image.UriSource = new Uri(path);
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                image.EndInit();
                image.Freeze();

                ProfileImage.Source = image;

                ProfileButton.Background = new ImageBrush
                {
                    ImageSource = image,
                    Stretch = Stretch.UniformToFill
                };
            }
        }

        private void SaveProfile(object sender, RoutedEventArgs e)
        {
            string nickname = NameInput.Text;

            if (string.IsNullOrWhiteSpace(nickname))
            {
                nickname = "User";
            }

            Properties.Settings.Default.Nickname = nickname;
            Properties.Settings.Default.Save();

            TitleTextBlock.Text = $"Hello, {nickname}!";

            ProfilePopup.IsOpen = false;
        }
    }
}