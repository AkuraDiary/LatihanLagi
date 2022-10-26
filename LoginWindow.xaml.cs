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
using System.Windows.Controls.Primitives;

namespace LatihanLagi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();

            // Uncomment if you want to show only the Azure Login side.
            //SplitGrid.Visibility = Visibility.Collapsed;
            //LocalLoginGrid.Visibility = Visibility.Collapsed;
            //if (AzureLoginGrid.Visibility == Visibility.Visible)
            //{
            //    AzureUserNameTextBox.Focus();
            //}



            // Uncomment if you want to show only the Local Login side.
            //AzureLoginGrid.Visibility = Visibility.Collapsed;
            //SplitGrid.Visibility = Visibility.Collapsed;
            //if (LocalLoginGrid.Visibility == Visibility.Visible)
            //{
            //    LocalUserNameTextBox.Focus();
            //}

        }

        private void CheckBoxChanged(object sender, RoutedEventArgs e)
        {
            if (WindowsCredentialsCheckBox.IsChecked == true)
            {
                LocalUserNameTextBox.Text = Environment.UserName;
                LocalPasswordBox.Password = "SHOW_SOME_PASSWORD";
            }
            else
            {
                LocalUserNameTextBox.Text = string.Empty;
                LocalPasswordBox.Password = string.Empty;
            }
        }

        private void BtnActionMinimize_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnActionSystemInformation_OnClick(object sender, RoutedEventArgs e)
        {
            var systemInformationWindow = new SystemInformationWindow();
            systemInformationWindow.Show();
        }

        private void btnActionClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Thumb_OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            Left = Left + e.HorizontalChange;
            Top = Top + e.VerticalChange;
        }
    }
}
