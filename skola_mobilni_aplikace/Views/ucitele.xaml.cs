using Microsoft.Maui.Controls;

namespace skola_mobilni_aplikace.Views
{
    public partial class ucitele : ContentPage
    {
        public ucitele()
        {
            InitializeComponent();
            UciteleListView.ItemsSource = Models.UciteleData.Ucitele; // Bind to the static list
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Prompt for student name
            string Name = await DisplayPromptAsync("New Ucitel", "Enter the name of the ucitel:");

            if (!string.IsNullOrWhiteSpace(Name))
            {
                Models.UciteleData.Ucitele.Add(Name); // Add to the static list
            }
        }
    }
}
