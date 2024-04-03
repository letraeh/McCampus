using System.Windows;

namespace McCampus;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Loaded += MainWindow_Loaded;
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
        Navigate(new Uri("PgIdle.xaml", UriKind.Relative));
    }

    private void Navigate(Uri uri)
    {
        MainFrame.NavigationService.Navigate(uri);
    }
}