using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word;

namespace AssistanceApp
{
    /// <summary>
    /// Логика взаимодействия для ResultTraineePage.xaml
    /// </summary>
    public partial class ResultTraineePage : Page
    {
        public ResultTraineePage(int id_trainee)
        {
            InitializeComponent();
            id.Text = id_trainee + "";
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                int id_trainee = Convert.ToInt32(id.Text);
                HelpEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGTest.ItemsSource = HelpEntities.GetContext().Results.Where((u) => u.Id_Trainee == id_trainee).ToList();
                DGCertification.ItemsSource = HelpEntities.GetContext().Certification.Where((u) => u.Id_Trainee == id_trainee).ToList();
            }
        }

        private void BtnGrade_Click(object sender, RoutedEventArgs e)
        {
            if (TBPath.Text == "")
            {
                System.Windows.MessageBox.Show("Введите путь для сохранения документа!");
            }
            else
            {
                try
                {
                    var application = new Word.Application();
                    Word.Document document = application.Documents.Add();
                    Word.Paragraph paragraph = document.Paragraphs.Add();
                    Word.Range range = paragraph.Range;
                    string path = "C:/Users/User/Desktop/AssistanceApp/AssistanceApp/Resources/ispytatelny_srok.doc";

                    Microsoft.Office.Interop.Word.Application wordObject = new Microsoft.Office.Interop.Word.Application();
                    object File = @path;
                    object nullobject = System.Reflection.Missing.Value;
                    Microsoft.Office.Interop.Word.Application wordobject = new Microsoft.Office.Interop.Word.Application();
                    wordobject.DisplayAlerts = Microsoft.Office.Interop.Word.WdAlertLevel.wdAlertsNone;
                    Microsoft.Office.Interop.Word._Document docs = wordObject.Documents.Open(ref File, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject, ref nullobject);
                    docs.ActiveWindow.Selection.WholeStory();
                    docs.ActiveWindow.Selection.Copy();
                    range.Paste();
                    docs.Close(ref nullobject, ref nullobject, ref nullobject);
                    wordObject.Quit();


                    int id_trainee = Convert.ToInt32(id.Text);
                    HelpEntities db = new HelpEntities();
                    Trainee trainee = db.Trainee.Where((u) => u.Id_Trainee == id_trainee).Single();
                    string Name = trainee.Login;
                    Name = Name.Trim();
                    application.Visible = true;//отображение приложения

                    string SavePath = TBPath.Text;
                    document.SaveAs2($@"{SavePath}\{Name} - Результат испытательного срока.docx");
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message.ToString());
                }            
            }
        }

        private SolidColorBrush solidColor = new SolidColorBrush(Colors.LightSkyBlue);
        private SolidColorBrush solidColor2 = new SolidColorBrush(Colors.Navy);
        private void DGTest_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Results results = (Results)e.Row.DataContext;
            if (results.Percents >= 0.8)
            {
                e.Row.Background = solidColor;
                e.Row.Foreground = solidColor2;
            }
        }

        private void TBPath_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                //string[] files = Directory.GetFiles(folderBrowser.SelectedPath);
                TBPath.Text = folderBrowser.SelectedPath;
            }
        } 
    }
}
