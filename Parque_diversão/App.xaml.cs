using Microsoft.Extensions.DependencyInjection;

namespace Parque_diversão
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Valordosingressos());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window();

            window.Width = 400;
            window.Height = 600;

            return new Window(new AppShell());
        }
    }
}