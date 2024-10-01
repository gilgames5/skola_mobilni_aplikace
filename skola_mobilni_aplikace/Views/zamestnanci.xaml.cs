namespace skola_mobilni_aplikace.Views;

public partial class zamestnanci : ContentPage
{
    public zamestnanci()
    {
        InitializeComponent();
    }

    async void OnUdrzbari(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(udrzbari));
    }

    async void OnUcitele(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ucitele));
    }

    async void OnPodpora(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(podpora));
    }

    async void OnStudenti(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(studenti));
    }
}
