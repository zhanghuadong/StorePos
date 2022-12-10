using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StorePos.UI.Pages
{
    /// <summary>
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void pageBtn1_Click(object sender, RoutedEventArgs e)
        {
            // Page2 page2 = new Page2();
            // this.NavigationService.Navigate(page2);
            MainWindowMgr mainWindowMgr = new MainWindowMgr();
            mainWindowMgr.Show();

            ((Window)this.Parent).Close();
            
        }
    }
}
