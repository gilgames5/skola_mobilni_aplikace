using skola_mobilni_aplikace.Views; // Make sure to include the namespace for your views

namespace skola_mobilni_aplikace
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(udrzbari), typeof(udrzbari));
            Routing.RegisterRoute(nameof(ucitele), typeof(ucitele));
            Routing.RegisterRoute(nameof(podpora), typeof(podpora));
            Routing.RegisterRoute(nameof(studenti), typeof(studenti));
        }
    }
}
