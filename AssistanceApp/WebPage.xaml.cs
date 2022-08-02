using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace AssistanceApp
{
    /// <summary>
    /// Логика взаимодействия для WebPage.xaml
    /// </summary>
    public partial class WebPage : Page
    {
        public WebPage()
        {
            InitializeComponent();
        }

        private void webBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            dynamic activeX = webBrowser.GetType().InvokeMember("ActiveXInstance",
                                    BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                                    null, webBrowser, new object[] { });
            activeX.Silent = true;
        }
    }
}
