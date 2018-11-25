using System;

using Windows.UI.Xaml.Controls;

using WtsMvvmBasic_v17.ViewModels;

namespace WtsMvvmBasic_v17.Views
{
    public sealed partial class ShellPage : Page
    {
        public ShellViewModel ViewModel { get; } = new ShellViewModel();

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);
        }
    }
}
