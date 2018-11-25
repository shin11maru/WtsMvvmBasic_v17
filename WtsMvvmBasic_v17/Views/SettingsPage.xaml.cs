using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WtsMvvmBasic_v17.ViewModels;

namespace WtsMvvmBasic_v17.Views
{
    // TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere
    public sealed partial class SettingsPage : Page
    {
        public SettingsViewModel ViewModel { get; } = new SettingsViewModel();

        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Initialize();
        }
    }
}
