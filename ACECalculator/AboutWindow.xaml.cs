﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ACECalculator
{
    /// <summary>
    /// Interaction logic for AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            Assembly Assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo FileVersion = FileVersionInfo.GetVersionInfo(Assembly.Location); // get this program's location
            Version.Content = $"Version {FileVersion.FileVersion}";
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            AbtWindow.Close();
        }

        private void Version_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Version.Content = "sad";
        }
    }
}
