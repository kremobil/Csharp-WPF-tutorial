using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Navigation;

namespace WpfApplications_tutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //---------- Adding a text block from code side ----------
            // TextBlock textBlockTwo = new TextBlock();
            // textBlockTwo.Text = "Text block from c#";
            // textBlockTwo.Inlines.Add("This is added using inlines");
            // textBlockTwo.Inlines.Add(new Run(" Run text that I added in code side")
            // {
            //     Foreground = Brushes.Chartreuse,
            //     TextDecorations = TextDecorations.Underline
            // });
            // this.Content = textBlockTwo;

            TextBlockOne.Text = "Text from C# side";
            TextBlockOne.Foreground = Brushes.Blue;
            myButton.FontSize = 48;
            myButton.Content = "Hello Wiktor";
        }

        private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
        
    }
}