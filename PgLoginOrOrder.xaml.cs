using System.Windows;
using System.Windows.Controls;

namespace McCampus;

public partial class PgLoginOrOrder : Page
{
    public PgLoginOrOrder()
    {
        InitializeComponent();
    }

    private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            // Navigate to another page
            NavigationService?.Navigate(new Uri("PgLogin.xaml", UriKind.Relative));
        }
        catch (System.NullReferenceException exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }

    private void ButtonOrder_OnClick(object sender, RoutedEventArgs e)
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