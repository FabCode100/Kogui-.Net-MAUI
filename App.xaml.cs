using Microsoft.Maui.Controls;

namespace KoguiApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // MainPage está na raiz do projeto
        MainPage = new NavigationPage(new MainPage());
    }
}
