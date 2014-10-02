using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace birthday_school
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ConfigWindow cfgWin = new ConfigWindow();

            Screen s2 = Screen.AllScreens[0];
            
            Rectangle r2 = s2.WorkingArea;
            cfgWin.Top = r2.Top;
            cfgWin.Left = r2.Left;
            cfgWin.Show();
        }
    }

    
}
