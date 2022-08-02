using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
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
    /// Логика взаимодействия для CertificationPage.xaml
    /// </summary>
    public partial class CertificationPage : Page
    {
        private Results _currentResults = new Results();
        private Certification _currentCertification = new Certification();

        public CertificationPage(int id_trainee)
        {
            InitializeComponent();
            id.Text = id_trainee+"";
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HelpEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGCourse.ItemsSource = HelpEntities.GetContext().Course.ToList();
            }
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            Tb1.Text = "";
            Tb2.Text = "";
            Tb3.Text = "";
            Tb4.Text = "";
            Tb5.Text = "";
            Tb6.Text = "";
            Tb7.Text = "";
            Tb8.Text = "";
            Tb9.Text = "";
            Tb10.Text = "";

            Course n = (Course)DGCourse.Items[DGCourse.SelectedIndex];
            string сourse = n.Name.ToString();
            id_course.Text = n.Id_Course.ToString();

            сourse = сourse.Trim(' ');
            RTBCourse.ScrollToHome();
            RTBCourse.Document.Blocks.Clear();

            string path = $@"C:\Users\User\Desktop\AssistanceApp\AssistanceApp\Resources\{сourse}.docx";

            Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
            object File = @path;
            object nullobject = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
            wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
            Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
            docs.ActiveWindow.Selection.WholeStory();
            docs.ActiveWindow.Selection.Copy();
            RTBCourse.Paste();
            docs.Close(ref nullobject, ref nullobject, ref nullobject);
            wordObject.Quit();
        }

        private void BtnCertification_Click(object sender, RoutedEventArgs e)
        {
            int id_trainee = Convert.ToInt32(id.Text);
            var result = HelpEntities.GetContext().Certification.Where((u) => u.Id_Trainee == id_trainee).ToList();
            if (result.Count() == 2)
            {
                //Process.Start(new ProcessStartInfo("https://uc1.1c.ru/course/distantsionnyj-kurs-prodavtsa-1s/") { UseShellExecute = true });
                Manager.MainFrame.Navigate(new WebPage());
            }
            else MessageBox.Show("Пройдите оба тестирования выше 80% для доступа к платной сертификации на сайте!");
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (id_course.Text == "1")
            {
                int count = 0;
                if (Tb1.Text == "3") count++;
                if (Tb2.Text == "2") count++;
                if (Tb3.Text == "13") count++;
                if (Tb4.Text == "2") count++;
                if (Tb5.Text == "2") count++;
                if (Tb6.Text == "2") count++;
                if (Tb7.Text == "2") count++;
                if (Tb8.Text == "3") count++;
                if (Tb9.Text == "12") count++;
                if (Tb10.Text == "1") count++;

                DataContext = _currentResults;
                _currentResults.Id_Course = Convert.ToInt32(id_course.Text);
                _currentResults.Id_Trainee = Convert.ToInt32(id.Text);
                _currentResults.Percents = Convert.ToDouble($"{count / 10}" + $",{count % 10}");
                _currentResults.Date = DateTime.Now;


                try
                {
                    HelpEntities.GetContext().Results.Add(_currentResults);
                    HelpEntities.GetContext().SaveChanges();
                    MessageBox.Show($"Результат {count * 10}% сохранен!");
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

                if (count >= 8)
                {
                    int id_trainee = Convert.ToInt32(id.Text);
                    try
                    {
                        HelpEntities db = new HelpEntities();

                        Certification certification = db.Certification.Where((u) => u.Id_Trainee == 1 && u.Id_Course == 1 && u.Status == "Допущен   ").Single();
                    }
                    catch
                    {
                        DataContext = _currentCertification;
                        _currentCertification.Id_Trainee = Convert.ToInt32(id.Text);
                        _currentCertification.Id_Course = 1;
                        _currentCertification.Status = "Допущен   ";

                        try
                        {
                            HelpEntities.GetContext().Certification.Add(_currentCertification);
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
                }
            }
            else if (id_course.Text == "2")
            {
                int count = 0;
                if (Tb1.Text == "34") count++;
                if (Tb2.Text == "2") count++;
                if (Tb3.Text == "1") count++;
                if (Tb4.Text == "1") count++;
                if (Tb5.Text == "1") count++;
                if (Tb6.Text == "1") count++;
                if (Tb7.Text == "1") count++;
                if (Tb8.Text == "2") count++;
                if (Tb9.Text == "1") count++;
                if (Tb10.Text == "2") count++;

                DataContext = _currentResults;
                _currentResults.Id_Course = 2;
                _currentResults.Id_Trainee = Convert.ToInt32(id.Text);
                _currentResults.Percents = Convert.ToDouble("0" + $",{count % 10}");
                _currentResults.Date = DateTime.Now;


                try
                {
                    HelpEntities.GetContext().Results.Add(_currentResults);
                    HelpEntities.GetContext().SaveChanges();
                    MessageBox.Show($"Результат {count * 10}% сохранен!");
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

                if (count >= 8)
                {
                    int id_trainee = Convert.ToInt32(id.Text);
                    try
                    {
                        HelpEntities db = new HelpEntities();

                        Certification certification = db.Certification.Where((u) => u.Id_Trainee == id_trainee && u.Id_Course == 2 && u.Status == "Допущен   ").Single();
                    }
                    catch
                    {
                        DataContext = _currentCertification;
                        _currentCertification.Id_Trainee = id_trainee;
                        _currentCertification.Id_Course = 2;
                        _currentCertification.Status = "Допущен   ";

                        try
                        {
                            HelpEntities.GetContext().Certification.Add(_currentCertification);
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
                }
            }
        }
    }
}
