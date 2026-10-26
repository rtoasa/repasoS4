using Microsoft.Extensions.DependencyInjection;

namespace repasoS4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.vRepaso()));
        }
    }
}