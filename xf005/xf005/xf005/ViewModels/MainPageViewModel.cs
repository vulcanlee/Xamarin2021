using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace xf005.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            // 定義這個 命令 被觸發後，將要執行的命令
            HelloCommand = new Command(OnHelloCommand); // 使用 具名 委派方法
        }
        // 宣告要進行 資料 綁定的來源物件
        // 使用 .NET 含有支援欄位的屬性 設計要綁定的屬性
        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        // 宣告要進行 資料 綁定的來源物件
        // 使用 .NET 含有支援欄位的屬性 設計要綁定的屬性
        private string helloName;
        public string HelloName
        {
            get { return helloName; }
            set { SetProperty(ref helloName, value); }
        }
        // 宣告要進行 命令 綁定的來源物件
        public ICommand HelloCommand { get; set; }

        private void OnHelloCommand(object obj)
        {
            Console.WriteLine($"Name={Name}");
            HelloName = Name;
        }
    }
}
