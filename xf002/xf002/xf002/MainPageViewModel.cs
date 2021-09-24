using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace xf002
{
    class MainPageViewModel
    {
        // 宣告要進行 資料 綁定的來源物件
        public string Name { get; set; }
        // 宣告要進行 資料 綁定的來源物件
        public string HelloName { get; set; }
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
            // 理論上，底下敘述執行完成後，綁定 HelloName 的 UI 將會進行更新
            // 但是，為什麼沒有生效呢？
            HelloName = Name;
        }
    }
}
