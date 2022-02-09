using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Application;

namespace ScreenText
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NotifyIcon _notifyIcon;

        private string _logs = string.Empty;

        public App()
        {
            _notifyIcon = new NotifyIcon();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _notifyIcon.Visible = true;
            _notifyIcon.Icon = new Icon("Resources/icon.ico");

            _notifyIcon.Text = "Click 'Print Screen' to make Screen shot";
            
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _notifyIcon.Dispose();

            base.OnExit(e);
        }

        private void KeyIsDown(object sender, KeyEventArgs eventArgs)
        {
            _logs = _logs + eventArgs.KeyCode;
        }
    }
}
