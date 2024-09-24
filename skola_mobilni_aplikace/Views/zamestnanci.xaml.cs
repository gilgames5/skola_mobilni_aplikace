namespace skola_mobilni_aplikace.Views;

public partial class zamestnanci : ContentPage
{
	public zamestnanci()
	{
		InitializeComponent();
	}
	async Task OnUdrzbariAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(udrzbari));
    }

    private async Task OnUciteleAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ucitele));
    }

    private async Task OnPodporaAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(podpora));
    }

    private async Task OnStudentiAsync(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(studenti));
    }
}