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
    /// Логика взаимодействия для TraineeMenuWindow.xaml
    /// </summary>
    public partial class TraineeMenuWindow : Window
    {
        public TraineeMenuWindow(int id)
        {
            InitializeComponent();
            id_trainee.Text = id+"";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow main = new AuthorizationWindow();
            main.Show();
            this.Close();
        }

        private void BtnCourse1_Click(object sender, RoutedEventArgs e)
        {
            ControlWindow main = new ControlWindow(1, Convert.ToInt32(id_trainee.Text));
            main.Show();
            this.Close();
        }

        private void BtnCourse2_Click(object sender, RoutedEventArgs e)
        {
            ControlWindow main = new ControlWindow(2, Convert.ToInt32(id_trainee.Text));
            main.Show();
            this.Close();
        }

        private void BtnPaidCourse_Click(object sender, RoutedEventArgs e)
        {
            ControlWindow main = new ControlWindow(3, Convert.ToInt32(id_trainee.Text));
            main.Show();
            this.Close();
        }

        private void BtnCertification_Click(object sender, RoutedEventArgs e)
        {
            ControlWindow main = new ControlWindow(4, Convert.ToInt32(id_trainee.Text));
            main.Show();
            this.Close();
        }
    }
}
