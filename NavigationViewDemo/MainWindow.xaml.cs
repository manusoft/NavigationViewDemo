using Microsoft.UI.Xaml;

namespace NavigationViewDemo;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();

        AppWindow.SetIcon("");
        Content = null;
        Title = "Navigation Demo";
    }
}
