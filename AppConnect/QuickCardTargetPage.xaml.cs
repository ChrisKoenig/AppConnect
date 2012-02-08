using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using AppConnect.ViewModel;
using Microsoft.Phone.Controls;

namespace AppConnect
{
    public partial class QuickCardTargetPage : PhoneApplicationPage
    {
        public QuickCardTargetPage()
        {
            InitializeComponent();
            // Create the ViewModel object.
            this.DataContext = new QuickCardTargetPageViewModel();

            // Create event handler for the page Loaded event.
            this.Loaded += (sender, e) =>
            {
                // Load the quick card parameters from the App Connect deep link URI.
                ViewModel.LoadUriParameters(this.NavigationContext.QueryString);
            };
        }

        // A property for the ViewModel.
        private QuickCardTargetPageViewModel ViewModel
        {
            get { return (QuickCardTargetPageViewModel)DataContext; }
        }
    }
}