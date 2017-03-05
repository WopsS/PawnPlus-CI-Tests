using System.Diagnostics;
using System.Reflection;
using System.Windows;
using ICSharpCode.AvalonEdit;

namespace PawnPlus.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            Assembly test = Assembly.GetExecutingAssembly();
            FileVersionInfo version = FileVersionInfo.GetVersionInfo(test.Location);
            MessageBox.Show($"FileVersion: {version.FileVersion} | ProductVersion: {version.ProductVersion} | Version: {test.GetName().Version.ToString()}");

            TextEditor a = new TextEditor();
        }
    }
}
