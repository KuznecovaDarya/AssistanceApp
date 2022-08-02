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
    /// Логика взаимодействия для Course2Page.xaml
    /// </summary>
    public partial class Course2Page : Page
    {
        public Course2Page(int id_trainee)
        {
            InitializeComponent();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HelpEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGTopic.ItemsSource = HelpEntities.GetContext().Topic.Where((u) => u.Id_Course == 2).ToList();
            }
        }

        private void BtnRead_Click(object sender, RoutedEventArgs e)
        {
            Topic n = (Topic)DGTopic.Items[DGTopic.SelectedIndex];
            string topic = n.Name.ToString();
            topic = topic.Trim(' ');
            RTBCourse.ScrollToHome();
            RTBCourse.Document.Blocks.Clear();

            string path = $@"C:\Users\User\Desktop\AssistanceApp\AssistanceApp\Resources\{topic}.docx";

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
    }
}
