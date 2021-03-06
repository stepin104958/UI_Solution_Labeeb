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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PivotUI.Controls
{
    public sealed partial class Module_HeadsetMix : UserControl
    {
        public Module_HeadsetMix()
        {
            this.InitializeComponent();
        }

        private void SelectMix_Toggled(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch)
            {
                var toggle = (ToggleSwitch)sender;
                if (toggle.IsOn)
                {
                    List1.Text = "Active";
                    List1.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
                    List1.Visibility = Visibility.Visible;
                }
                else
                {
                    List1.Text = "Inactive";
                    List1.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
                    List1.Visibility = Visibility.Visible;
                }
            }
        }

        private void MicLevels_Toggled(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch)
            {
                var toggle = (ToggleSwitch)sender;
                if (toggle.IsOn)
                {
                    List2.Text = "Active";
                    List2.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
                    List2.Visibility = Visibility.Visible;
                }
                else
                {
                    List2.Text = "Inactive";
                    List2.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
                    List2.Visibility = Visibility.Visible;
                }
            }
        }

        private void Headset_Toggled(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch)
            {
                var toggle = (ToggleSwitch)sender;
                if (toggle.IsOn)
                {
                    List3.Text = "Active";
                    List3.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
                    List3.Visibility = Visibility.Visible;
                }
                else
                {
                    List3.Text = "Inactive";
                    List3.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
                    List3.Visibility = Visibility.Visible;
                }
            }
        }

        private void SideTone_Toggled(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch)
            {
                var toggle = (ToggleSwitch)sender;
                if (toggle.IsOn)
                {
                    List4.Text = "Active";
                    List4.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
                    List4.Visibility = Visibility.Visible;
                }
                else
                {
                    List4.Text = "Inactive";
                    List4.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
                    List4.Visibility = Visibility.Visible;
                }
            }
        }

        private void NoiseGate_Toggled(object sender, RoutedEventArgs e)
        {
            if (sender is ToggleSwitch)
            {
                var toggle = (ToggleSwitch)sender;
                if (toggle.IsOn)
                {
                    List5.Text = "Active";
                    List5.Foreground = new SolidColorBrush(Windows.UI.Colors.OrangeRed);
                    List5.Visibility = Visibility.Visible;
                }
                else
                {
                    List5.Text = "Inactive";
                    List5.Foreground = new SolidColorBrush(Windows.UI.Colors.Gray);
                    List5.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
