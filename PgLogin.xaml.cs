using System.Windows;
using System.Windows.Controls;

namespace McCampus;

public partial class PgLogin : Page
{
    public PgLogin()
    {
        InitializeComponent();
    }

    private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            // Navigate to another page
            NavigationService?.Navigate(new Uri("PgOrder.xaml", UriKind.Relative));
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void ButtonContinue_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            // Navigate to another page
            NavigationService?.Navigate(new Uri("PgOrder.xaml", UriKind.Relative));
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
}