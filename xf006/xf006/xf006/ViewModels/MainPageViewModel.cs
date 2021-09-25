using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace xf006.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // 宣告要進行 命令 綁定的來源物件
        public ICommand HelloCommand { get; set; }
        // 宣告要進行 資料 綁定的來源物件 Name
        public string Name { get; set; }
        // 宣告要進行 資料 綁定的來源物件 HelloName
        public string HelloName { get; set; }
        public MainPageViewModel()
        {
            // 定義這個 命令 被觸發後，將要執行的命令
            HelloCommand = new Command(x => // 使用 Lambda 運算式的匿名委派方法
            {
                Console.WriteLine($"Name={Name}");
                HelloName = Name;
            });
        }
    }
}
