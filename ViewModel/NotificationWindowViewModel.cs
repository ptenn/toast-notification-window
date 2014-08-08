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
        /// Private field for the Notification Title.
        /// </summary>
        private Brush _notificationBackground;

        /// <summary>
        /// Property for the Notification Title.
        /// </summary>
        public Brush NotificationBackground
        {
            get { return _notificationBackground; }
            set
            {
                _notificationBackground = value;
                RaisePropertyChangedEvent("NotificationBackground");
            }
        }
 
 
    }
}
