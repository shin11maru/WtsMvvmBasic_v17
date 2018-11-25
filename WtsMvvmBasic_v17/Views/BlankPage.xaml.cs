using System;

using Windows.UI.Xaml.Controls;

using WtsMvvmBasic_v17.ViewModels;

namespace WtsMvvmBasic_v17.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; } = new BlankViewModel();

        public BlankPage()
        {
            InitializeComponent();
        }
    }
}
