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
using System.Windows.Shapes;

namespace AssistanceApp
{
    /// <summary>
    /// Логика взаимодействия для ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        public ControlWindow(int i, int id)
        {
            InitializeComponent();
            if (i == 1)
            {
                MainFrame.Navigate(new Course1Page(id));
            }
            else if (i == 2)
            {
                MainFrame.Navigate(new Course2Page(id));
            }
            else if (i == 3)
            {
                MainFrame.Navigate(new PaidCoursePage(id));
            }
            else if (i == 4)
            {
                MainFrame.Navigate(new CertificationPage(id));
            }
            else if (i == 5)
            {
                MainFrame.Navigate(new ListTraineePage(id));
                BtnMenu.Visibility = Visibility.Hidden;
            }
            Manager.MainFrame = MainFrame;
            Id.Text = id + "";
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            TraineeMenuWindow main = new TraineeMenuWindow(Convert.ToInt32(Id.Text));
            main.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow main = new AuthorizationWindow();
            main.Show();
            this.Close();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}
