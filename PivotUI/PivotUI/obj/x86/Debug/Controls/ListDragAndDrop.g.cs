﻿#pragma checksum "C:\Users\Labeeb Ali\Documents\GitHub\UI_Solution_Labeeb\PivotUI\PivotUI\Controls\ListDragAndDrop.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B8E0BEF70C20332E72DC205581651F07"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PivotUI.Controls
{
    partial class ListDragAndDrop : 
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
            case 49: // Controls\ListDragAndDrop.xaml line 434
                {
                    this.List1 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List1).DragItemsStarting += this.List1_DragItemsStarting;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List1).DragOver += this.List2_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List1).Drop += this.List1_Drop;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List1).DragEnter += this.List1_DragEnter;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List1).DropCompleted += this.List1_DropCompleted;
                }
                break;
            case 50: // Controls\ListDragAndDrop.xaml line 465
                {
                    this.List2 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List2).Drop += this.List2_Drop;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List2).DragOver += this.List2_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.List2).SelectionChanged += this.List2_SelectionChanged;
                }
                break;
            case 51: // Controls\ListDragAndDrop.xaml line 485
                {
                    this.Item1 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                }
                break;
            case 52: // Controls\ListDragAndDrop.xaml line 504
                {
                    this.Item2 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                }
                break;
            case 53: // Controls\ListDragAndDrop.xaml line 507
                {
                    this.BtnTwo = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BtnTwo).Checked += this.BtnOne_Checked;
                }
                break;
            case 54: // Controls\ListDragAndDrop.xaml line 517
                {
                    this.ButtonTwo = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 55: // Controls\ListDragAndDrop.xaml line 513
                {
                    this.ActTwo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 56: // Controls\ListDragAndDrop.xaml line 510
                {
                    this.ImagTwo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 57: // Controls\ListDragAndDrop.xaml line 511
                {
                    this.RadTwo = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 58: // Controls\ListDragAndDrop.xaml line 490
                {
                    this.BtnOne = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.BtnOne).Checked += this.BtnOne_Checked;
                }
                break;
            case 59: // Controls\ListDragAndDrop.xaml line 499
                {
                    this.ButtonOne = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 60: // Controls\ListDragAndDrop.xaml line 496
                {
                    this.ActOne = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 61: // Controls\ListDragAndDrop.xaml line 493
                {
                    this.ImagOne = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 62: // Controls\ListDragAndDrop.xaml line 494
                {
                    this.RadOne = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

