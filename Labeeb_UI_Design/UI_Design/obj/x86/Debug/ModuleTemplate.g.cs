﻿#pragma checksum "C:\Users\99002617\Documents\GitHub\UWPTraining\UI_Design\UI_Design\ModuleTemplate.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3895F2EDE9908D340CAD1A0852654532"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI_Design
{
    partial class ModuleTemplate : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // ModuleTemplate.xaml line 14
                {
                    this.WindowSize = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3: // ModuleTemplate.xaml line 15
                {
                    this.Widest = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // ModuleTemplate.xaml line 47
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // ModuleTemplate.xaml line 80
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // ModuleTemplate.xaml line 116
                {
                    this.Lines = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // ModuleTemplate.xaml line 117
                {
                    this.Module_Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Module_Text).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 8: // ModuleTemplate.xaml line 118
                {
                    this.DetailText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.DetailText).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 9: // ModuleTemplate.xaml line 119
                {
                    this.Image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // ModuleTemplate.xaml line 120
                {
                    this.Xbox_Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Xbox_Text).SelectionChanged += this.TextBlock_SelectionChanged;
                }
                break;
            case 11: // ModuleTemplate.xaml line 121
                {
                    this.Xbox_Button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Xbox_Button).Click += this.Button_Click;
                }
                break;
            case 12: // ModuleTemplate.xaml line 122
                {
                    this.Profile_Text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // ModuleTemplate.xaml line 123
                {
                    this.border = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 14: // ModuleTemplate.xaml line 124
                {
                    this.border_text = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

