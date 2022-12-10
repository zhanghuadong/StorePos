using DotNet.Http.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StorePos.UI;
 
namespace StorePos
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //MessageBox.Show("当前选中了:" + "listbox.SelectedItem", "标题", MessageBoxButton.OK, MessageBoxImage.Information);

            IHttpProvider httpProvider = new HttpProvider();

            // 1. 模拟一个Get请求方式
            HttpResponseParameter responseParameter1 = httpProvider.Excute(new HttpRequestParameter
            {
                Url = "http://www.baidu.com",
                IsPost = false,
                Encoding = Encoding.UTF8
                //Cookie = new HttpCookieType() 如果需要Cookie
            });
            System.Console.WriteLine(responseParameter1.Body);

          /*  // 2. 模拟一个Post请求方式（例：登录)
            IDictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("userName", "登录用户名");
            postData.Add("userPwd", "用户名密码");
            HttpResponseParameter responseParameter2 = httpProvider.Excute(new HttpRequestParameter
            {
                Url = "你的登录url",
                IsPost = true,
                Encoding = Encoding.UTF8,
                Parameters = postData
            });
            System.Console.WriteLine(responseParameter2.Body);*/

            System.Console.ReadLine();

        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Close();
        }
    }
}
