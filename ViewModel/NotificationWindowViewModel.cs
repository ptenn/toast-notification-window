using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;



namespace ToastNotificationWindow.ViewModel
{
    public class NotificationWindowViewModel : ObservableViewModel
    {

        /// <summary>
        /// Private field for the Notification Title.
        /// </summary>
        private String _notificationTitle = "";

        /// <summary>
        /// Property for the Notification Title.
        /// </summary>
        public string NotificationTitle
        {
            get { return _notificationTitle; }
            set
            {
                _notificationTitle = value;
                RaisePropertyChangedEvent("NotificationTitle");
            }
        }

        /// <summary>
        /// Private field for the Notification Title.
        /// </summary>
        private String _notificationMessage = "";

        /// <summary>
        /// Property for the Notification Title.
        /// </summary>
        public string NotificationMessage
        {
            get { return _notificationMessage; }
            set
            {
                _notificationMessage = value;
                RaisePropertyChangedEvent("NotificationMessage");
            }
        }

        /// <summary>
        /// Private field for the Notification Background.
        /// </summary>
        private Brush _backgroundColor;

        /// <summary>
        /// Property for the Notification Background.
        /// </summary>
        public Brush BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                RaisePropertyChangedEvent("BackgroundColor");
            }
        }

        /// <summary>
        /// Convenience method to set the Background Color from a Hex Color code.
        /// </summary>
        /// <param name="hexColor">The Hex Color for Background</param>
        public void SetBackgroundColorFromHex(String hexColor)
        {
            BackgroundColor = (SolidColorBrush)(new BrushConverter().ConvertFrom(hexColor));
        }

        /// <summary>
        /// Private field for the Notification Title.
        /// </summary>
        private Brush _textColor;

        /// <summary>
        /// Property for the Notification Title.
        /// </summary>
        public Brush TextColor
        {
            get { return _textColor; }
            set
            {
                _textColor = value;
                RaisePropertyChangedEvent("TextColor");
            }
        }

        /// <summary>
        /// Convenience method to set the Text Color from a Hex Color code.
        /// </summary>
        /// <param name="hexColor">The Hex Color for Text</param>
        public void SetTextColorFromHex(String hexColor)
        {
            TextColor = (SolidColorBrush)(new BrushConverter().ConvertFrom(hexColor));
        } 
    }
}
