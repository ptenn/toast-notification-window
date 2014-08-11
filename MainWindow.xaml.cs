using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ToastNotificationWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(MainWindow));


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowInfoButton_Click(object sender, RoutedEventArgs e)
        {
            log.Info("ShowInfoButton Clicked");
            NotificationWindow toastNotificationWindow = new NotificationWindow();
            toastNotificationWindow.Owner = this;
            toastNotificationWindow.Show();
        }

        private void ShowErrorButton_Click(object sender, RoutedEventArgs e)
        {
            log.Info("ShowErrorButton Clicked");
            NotificationWindow toastNotificationWindow = new NotificationWindow();
            toastNotificationWindow.Owner = this;
            toastNotificationWindow.Show();
        }
    }
}
