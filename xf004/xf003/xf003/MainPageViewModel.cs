using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace xf003
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        // 宣告要進行 資料 綁定的來源物件
        // 使用 .NET 含有支援欄位的屬性 設計要綁定的屬性
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        // 宣告要進行 資料 綁定的來源物件
        // 使用 .NET 含有支援欄位的屬性 設計要綁定的屬性
        private string helloName;
        public string HelloName
        {
            get { return helloName; }
            set
            {
                if (helloName != value)
                {
                    helloName = value;
                    OnPropertyChanged();
                }
            }
        }
        // 宣告要進行 命令 綁定的來源物件
        public ICommand HelloCommand { get; set; }
        public MainPageViewModel()
        {
            // 定義這個 命令 被觸發後，將要執行的命令
            HelloCommand = new Command(OnHelloCommand); // 使用 具名 委派方法
        }

        private void OnHelloCommand(object obj)
        {
            Console.WriteLine($"Name={Name}");
            HelloName = Name;
        }

        #region 實作關於 INotifyPropertyChanged 的方法
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "") =>
            // 若 PropertyChanged 有被綁定，則將會執行這個事件，
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
