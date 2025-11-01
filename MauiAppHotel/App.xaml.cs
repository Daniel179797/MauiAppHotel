namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override Window CreateWindow(IActivationState? activationState);
        {
            var window = base.CreateWindow(activationState);

        Window.width = 400;
        Window.height = 600;

        return window;
        }

    }
}
