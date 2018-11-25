using System;

using WtsMvvmBasic_v17.Helpers;

namespace WtsMvvmBasic_v17.ViewModels
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
        }

        // Observableクラスで定義されているSetメソッドを使うことで、
        // プロパティの値が更新されたら、INotifyPropertyChangedでの更新通知イベントが呼び出されます。
        private string name;
        public string Name
        {
            get { return name; }
            //set { this.Set(ref this.name, value); }

            // RelayCommand作成時に、第二引数でコマンド実行できるかどうかのチェック処理を渡す
            // NameプロパティのSetterで、ClearCommandのOnCanExecuteChangedを呼出す
            // Nameプロパティが変わる = Clearボタンの実行可否が変わる可能性があるため

            // こうすると、ClearCommandをボタンのCommandプロパティにバインドしておくだけで、
            // CanExecuteがfalseの時には、ボタンが勝手にDisable状態へと変化します。
            set { this.Set(ref this.name, value); this.ClearCommand.OnCanExecuteChanged(); }

        }

        // 以下、RelayCommandクラスを用いたコマンドの実装
        private RelayCommand clearCommand;

        public RelayCommand ClearCommand
        {
            //get { return clearCommand = clearCommand ?? new RelayCommand(Clear); }

            get { return clearCommand = clearCommand ?? new RelayCommand(Clear, () => !string.IsNullOrWhiteSpace(this.Name)); }
        }
        private void Clear()
        {
            this.Name = string.Empty;
        }

    }
}
