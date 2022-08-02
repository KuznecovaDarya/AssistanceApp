using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для AddTraineePage.xaml
    /// </summary>
    public partial class AddTraineePage : Page
    {
        private Trainee _currentTrainee = new Trainee();
        private SupervisorAndTrainee _currentSAndT = new SupervisorAndTrainee();

        public AddTraineePage(int id)
        {
            InitializeComponent();

            id_Supervisor.Text = id + "";
            CbSupervisor.ItemsSource = HelpEntities.GetContext().Supervisor.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "") MessageBox.Show("Введите Логин стажера!");
            else if (TBPassword.Text == "") MessageBox.Show("Введите Пароль стажера!");
            else
            {
                int id_supervisor = Convert.ToInt32((CbSupervisor.SelectedValue + ""));
                try
                {
                    HelpEntities db = new HelpEntities();
                    Trainee trainee = db.Trainee.Where((u) => u.Login == TBLogin.Text).Single();
                    MessageBox.Show("Такой стажер уже существует!");
                }
                catch
                {
                    int id_trainee = 0;
                    DataContext = _currentTrainee;
                    _currentTrainee.Login = TBLogin.Text;
                    _currentTrainee.Password = TBPassword.Text;
                    try
                    {
                        HelpEntities.GetContext().Trainee.Add(_currentTrainee);
                        HelpEntities.GetContext().SaveChanges();
                        MessageBox.Show($"Стажер сохранен!");

                        var trainee = HelpEntities.GetContext().Trainee.ToList();
                        id_trainee = Convert.ToInt32(trainee[trainee.Count() - 1].Id_Trainee);


                        DataContext = _currentSAndT;
                        _currentSAndT.Id_Supervisor = id_supervisor;
                        _currentSAndT.Id_Trainee = id_trainee;
                        try
                        {
                            HelpEntities.GetContext().SupervisorAndTrainee.Add(_currentSAndT);
                            HelpEntities.GetContext().SaveChanges();
                        }
                        catch (DbEntityValidationException ex)
                        {
                            foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                            {
                                foreach (DbValidationError err in validationError.ValidationErrors)
                                {
                                    MessageBox.Show(err.ErrorMessage + "");
                                }
                            }
                        }
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                        {
                            foreach (DbValidationError err in validationError.ValidationErrors)
                            {
                                MessageBox.Show(err.ErrorMessage + "");
                            }
                        }
                    }

                }
            }
        }
    }
}