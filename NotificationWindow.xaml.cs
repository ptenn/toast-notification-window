﻿using System;
using System.Windows;
using System.Windows.Threading;

namespace ToastNotificationWindow
{
    public partial class NotificationWindow
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(NotificationWindow));

        public NotificationWindow()
        {
            log.Info("Creating NotificationWindow Instance");
            InitializeComponent();

            Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(() =>
            {
                if (Owner == null)
                {
                    var workingArea = SystemParameters.WorkArea;

                    var transform = PresentationSource.FromVisual(this).CompositionTarget.TransformFromDevice;
                    var corner = transform.Transform(new Point(workingArea.Right, workingArea.Bottom));

                    this.Left = corner.X - this.ActualWidth;
                    this.Top = corner.Y - this.ActualHeight;
                }
                else
                {                    
                    this.Left = Owner.Left + Owner.BorderThickness.Left + 7;
                    this.Top = Owner.Top + Owner.ActualHeight - this.ActualHeight - 7;
                }
            }));
        }

        private void DismissButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}