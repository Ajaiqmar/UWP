#pragma checksum "D:\UWP\UWP\LearnApp\LearnApp\Excercise18\StupedousStyleChallengePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E2D174D678DC9FFFD90244D742DE136"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LearnApp.Excercise18
{
    partial class StupedousStyleChallengePage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
            case 2: // Excercise18\StupedousStyleChallengePage.xaml line 76
                {
                    this.NavigationFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 3: // Excercise18\StupedousStyleChallengePage.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.GetDonutPage;
                    ((global::Windows.UI.Xaml.Controls.Button)element3).PointerEntered += this.Button_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Button)element3).PointerExited += this.Button_PointerExited;
                }
                break;
            case 4: // Excercise18\StupedousStyleChallengePage.xaml line 50
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.GetCoffeePage;
                    ((global::Windows.UI.Xaml.Controls.Button)element4).PointerExited += this.Button_PointerExited;
                    ((global::Windows.UI.Xaml.Controls.Button)element4).PointerEntered += this.Button_PointerEntered;
                }
                break;
            case 5: // Excercise18\StupedousStyleChallengePage.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.Button element5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element5).Click += this.GetSchedulePage;
                    ((global::Windows.UI.Xaml.Controls.Button)element5).PointerEntered += this.Button_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Button)element5).PointerExited += this.Button_PointerExited;
                }
                break;
            case 6: // Excercise18\StupedousStyleChallengePage.xaml line 62
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.GetCompletePage;
                    ((global::Windows.UI.Xaml.Controls.Button)element6).PointerEntered += this.Button_PointerEntered;
                    ((global::Windows.UI.Xaml.Controls.Button)element6).PointerExited += this.Button_PointerExited;
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

