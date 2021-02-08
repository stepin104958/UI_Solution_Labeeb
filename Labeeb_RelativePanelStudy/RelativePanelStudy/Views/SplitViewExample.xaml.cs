﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RelativePanelStudy.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SplitViewExample : Page
    {
        public SplitViewExample()
        {
            this.InitializeComponent();
        }

        private void BackToRelativeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Main));
        }

        private void FlipViewBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FlipView));

        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;
        }
    }
}
