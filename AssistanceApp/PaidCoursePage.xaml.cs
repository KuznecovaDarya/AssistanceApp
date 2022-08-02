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
    /// Логика взаимодействия для PaidCoursePage.xaml
    /// </summary>
    public partial class PaidCoursePage : Page
    {
        public PaidCoursePage(int id_trainee)
        {
            InitializeComponent();
            CBFiltr.ItemsSource = HelpEntities.GetContext().PaidCourseType.ToList();
        }

        private void BtnFiltr_Click(object sender, RoutedEventArgs e)
        {
            int type = Convert.ToInt32(CBFiltr.SelectedValue);

            var Course = HelpEntities.GetContext().Paid_Courses.ToList();
            if (CBFiltr.Text != "" && type != 1)
            {
                DGCourse.ItemsSource = Course.Where(c => c.Id_PaidCourseType == type).ToList();
            }
            else
            {
                DGCourse.ItemsSource = Course.ToList();
            }
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HelpEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGCourse.ItemsSource = HelpEntities.GetContext().Paid_Courses.ToList();
            }
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            string search = TxtSearch.Text;

            var Course = HelpEntities.GetContext().Paid_Courses.ToList();
            DGCourse.ItemsSource = Course.Where(c => c.Name.Contains(search));
        }

    }
}
