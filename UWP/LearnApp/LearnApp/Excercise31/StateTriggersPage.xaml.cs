using System;
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

namespace LearnApp.Excercise31
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    class SameTrigger : StateTriggerBase
    {
        private string a;
        public string From
        {
            get { return this.a; }

            set
            {
                this.a = value;

                if (this.a.Equals(To))
                {
                    SetActive(true);
                }
                else
                {
                    SetActive(false);
                }
            }
        }

        public string To { get; set; }
    }

    public sealed partial class StateTriggersPage : Page
    {
        public StateTriggersPage()
        {
            this.InitializeComponent();
        }
    }
}
