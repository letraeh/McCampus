using System.Windows;
using System.Windows.Controls;

namespace McCampus;

public partial class PgIdle : Page
{
    public PgIdle()
    {
        InitializeComponent();
    }

    private void ButtonStart_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            // Navigate to another page
            NavigationService?.Navigate(new Uri("PgLoginOrOrder.xaml", UriKind.Relative));
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
}