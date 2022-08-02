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
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.GetZIndex(PBPassword) == 0)
            {
                PBPassword.Password = TBPassword.Text;
                Panel.SetZIndex(TBPassword, 0);
                Panel.SetZIndex(PBPassword, 1);
            }

            string Login = TBLogin.Text;
            string Password = PBPassword.Password;

            for (int i = Login.Length; i < 50; i++)
            {
                Login += " ";
            }
            for (int i = Password.Length; i < 15; i++)
            {
                Password += " ";
            }

            if (CheckBox.IsChecked == false)
            {
                HelpEntities db = new HelpEntities();
                try
                {
                    Trainee trainee = db.Trainee.Where((u) => u.Login == Login && u.Password == Password).Single();

                    int id = Convert.ToInt32(trainee.Id_Trainee);
                    TraineeMenuWindow main = new TraineeMenuWindow(id);
                    main.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
            else
            {
                HelpEntities db = new HelpEntities();
                try
                {
                    Supervisor supervisor = db.Supervisor.Where((u) => u.Login == Login && u.Password == Password).Single();

                    int id = Convert.ToInt32(supervisor.Id_Supervisor);
                    ControlWindow main = new ControlWindow(5, id);
                    main.Show();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }

        private void Eye_Click(object sender, RoutedEventArgs e)
        {
            if (Panel.GetZIndex(PBPassword) == 1)
            {
                TBPassword.Text = PBPassword.Password;
                Panel.SetZIndex(TBPassword, 1);
                Panel.SetZIndex(PBPassword, 0);
            }
            else if (Panel.GetZIndex(PBPassword) == 0)
            {
                PBPassword.Password = TBPassword.Text;
                Panel.SetZIndex(TBPassword, 0);
                Panel.SetZIndex(PBPassword, 1);
            }
        }
    }
}
