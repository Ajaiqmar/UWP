#pragma checksum "D:\UWP\UWP\LearnApp\LearnApp\Excercise14\MoreXAMLControlParts.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B8EFE059FF65E1D82FE50DEDB2905A5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnApp.Excercise14
{
    partial class MoreXAMLControlParts : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MoreXAMLControlParts_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMoreXAMLControlParts_Bindings
        {
            private global::LearnApp.Excercise14.MoreXAMLControlParts dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressBar obj4;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4ValueDisabled = false;

            private MoreXAMLControlParts_obj1_BindingsTracking bindingsTracking;

            public MoreXAMLControlParts_obj1_Bindings()
            {
                this.bindingsTracking = new MoreXAMLControlParts_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 96 && columnNumber == 91)
                {
                    isobj4ValueDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Excercise14\MoreXAMLControlParts.xaml line 96
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
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

            // IMoreXAMLControlParts_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LearnApp.Excercise14.MoreXAMLControlParts)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LearnApp.Excercise14.MoreXAMLControlParts obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MySlider(obj.MySlider, phase);
                    }
                }
            }
            private void Update_MySlider(global::Windows.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MySlider(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MySlider_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_MySlider_Value(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Excercise14\MoreXAMLControlParts.xaml line 96
                    if (!isobj4ValueDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj4, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MoreXAMLControlParts_obj1_BindingsTracking
            {
                private global::System.WeakReference<MoreXAMLControlParts_obj1_Bindings> weakRefToBindingObj; 

                public MoreXAMLControlParts_obj1_BindingsTracking(MoreXAMLControlParts_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MoreXAMLControlParts_obj1_Bindings>(obj);
                }

                public MoreXAMLControlParts_obj1_Bindings TryGetBindingObject()
                {
                    MoreXAMLControlParts_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_MySlider(null);
                }

                public void DependencyPropertyChanged_MySlider_Value(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MoreXAMLControlParts_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.Slider obj = sender as global::Windows.UI.Xaml.Controls.Slider;
                        if (obj != null)
                        {
                            bindings.Update_MySlider_Value(obj.Value, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Slider cache_MySlider = null;
                private long tokenDPC_MySlider_Value = 0;
                public void UpdateChildListeners_MySlider(global::Windows.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_MySlider)
                    {
                        if (cache_MySlider != null)
                        {
                            cache_MySlider.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, tokenDPC_MySlider_Value);
                            cache_MySlider = null;
                        }
                        if (obj != null)
                        {
                            cache_MySlider = obj;
                            tokenDPC_MySlider_Value = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, DependencyPropertyChanged_MySlider_Value);
                        }
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
            case 2: // Excercise14\MoreXAMLControlParts.xaml line 106
                {
                    this.MyPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                    ((global::Windows.UI.Xaml.Controls.PasswordBox)this.MyPassword).PasswordChanged += this.OnPasswordChange;
                }
                break;
            case 3: // Excercise14\MoreXAMLControlParts.xaml line 107
                {
                    this.PasswordBoxResult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Excercise14\MoreXAMLControlParts.xaml line 96
                {
                    this.MyProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 5: // Excercise14\MoreXAMLControlParts.xaml line 91
                {
                    this.MySlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 6: // Excercise14\MoreXAMLControlParts.xaml line 85
                {
                    this.MyAutoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.MyAutoSuggestBox).TextChanged += this.MyAutoSuggestBox_TextChanged;
                }
                break;
            case 7: // Excercise14\MoreXAMLControlParts.xaml line 54
                {
                    this.MyFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 8: // Excercise14\MoreXAMLControlParts.xaml line 57
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Button_Click;
                }
                break;
            case 9: // Excercise14\MoreXAMLControlParts.xaml line 46
                {
                    this.MyCalendarView = (global::Windows.UI.Xaml.Controls.CalendarView)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarView)this.MyCalendarView).SelectedDatesChanged += this.MyCalendarView_SelectedDatesChanged;
                }
                break;
            case 10: // Excercise14\MoreXAMLControlParts.xaml line 47
                {
                    this.MyCalendarViewResult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            case 1: // Excercise14\MoreXAMLControlParts.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MoreXAMLControlParts_obj1_Bindings bindings = new MoreXAMLControlParts_obj1_Bindings();
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

