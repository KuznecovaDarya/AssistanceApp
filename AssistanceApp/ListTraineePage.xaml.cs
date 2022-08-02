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

namespace AssistanceApp
{
    /// <summary>
    /// Логика взаимодействия для ListTraineePage.xaml
    /// </summary>
    public partial class ListTraineePage : Page
    {
        public ListTraineePage(int id_Supervisor)
        {
            InitializeComponent();
            id_supervisor.Text = id_Supervisor+"";
        }
        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            SupervisorAndTrainee n = (SupervisorAndTrainee)DGTrainee.Items[DGTrainee.SelectedIndex];
           
            Manager.MainFrame.Navigate(new ResultTraineePage(Convert.ToInt32(n.Trainee.Id_Trainee)));
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                int id = Convert.ToInt32(id_supervisor.Text);
                HelpEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGTrainee.ItemsSource = HelpEntities.GetContext().SupervisorAndTrainee.Where((u)=>u.Id_Supervisor== id).ToList();
            }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(id_supervisor.Text);
            string search = TxtSearch.Text;

            var Trainee = HelpEntities.GetContext().SupervisorAndTrainee.Where((u) => u.Id_Supervisor == id).ToList();
            DGTrainee.ItemsSource = Trainee.Where(c => c.Trainee.Login.Contains(search));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddTraineePage(Convert.ToInt32(id_supervisor.Text)));
        }
    }
}
