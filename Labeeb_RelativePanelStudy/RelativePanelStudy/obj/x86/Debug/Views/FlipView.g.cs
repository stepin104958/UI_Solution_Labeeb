﻿#pragma checksum "C:\Users\99002617\Documents\GitHub\UWPTraining\New\RelativePanelStudy\RelativePanelStudy\Views\FlipView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8237032228FEA76065B9CBE36A744F18"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RelativePanelStudy.Views
{
    partial class FlipView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class FlipView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IFlipView_Bindings
        {
            private global::RelativePanelStudy.Views.FlipView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.FlipView obj37;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj37ItemsSourceDisabled = false;

            public FlipView_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 421 && columnNumber == 23)
                {
                    isobj37ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 37: // Views\FlipView.xaml line 413
                        this.obj37 = (global::Windows.UI.Xaml.Controls.FlipView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IFlipView_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::RelativePanelStudy.Views.FlipView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::RelativePanelStudy.Views.FlipView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_sampleList(obj.sampleList, phase);
                    }
                }
            }
            private void Update_sampleList(global::System.Collections.ObjectModel.ObservableCollection<global::RelativePanelStudy.Model.SampleItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\FlipView.xaml line 413
                    if (!isobj37ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj37, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 30: // Views\FlipView.xaml line 287
                {
                    this.WindowStates = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 31: // Views\FlipView.xaml line 288
                {
                    this.WideScreen = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 32: // Views\FlipView.xaml line 314
                {
                    this.NarrowScreen = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 33: // Views\FlipView.xaml line 341
                {
                    this.WidestScreen = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 34: // Views\FlipView.xaml line 373
                {
                    this.BackToRelativeBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.BackToRelativeBtn).Click += this.BackToRelativeBtn_Click;
                }
                break;
            case 35: // Views\FlipView.xaml line 388
                {
                    this.SplitViewBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SplitViewBtn).Click += this.SplitViewBtn_Click;
                }
                break;
            case 36: // Views\FlipView.xaml line 401
                {
                    this.AddBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddBtn).Click += this.AddBtn_Click;
                }
                break;
            case 37: // Views\FlipView.xaml line 413
                {
                    this.Gallery = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                }
                break;
            case 38: // Views\FlipView.xaml line 447
                {
                    this.GalleryIndicator = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 39: // Views\FlipView.xaml line 458
                {
                    this.PhotoIndicator = (global::Windows.UI.Xaml.Controls.ListBox)(target);
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
            switch(connectionId)
            {
            case 1: // Views\FlipView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    FlipView_obj1_Bindings bindings = new FlipView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

