using System;

using Windows.UI.Xaml.Controls;

using WtsMvvmBasic_v17.ViewModels;

namespace WtsMvvmBasic_v17.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
