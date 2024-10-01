using Microsoft.Maui.Controls;

namespace skola_mobilni_aplikace.Views
{
    public partial class udrzbari : ContentPage
    {
        public udrzbari()
        {
            InitializeComponent();
            UdrzbariListView.ItemsSource = Models.UdrzbariData.Udrzbari; // Bind to the static list
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Prompt for student name
            string Name = await DisplayPromptAsync("New Udrzbari", "Enter the name of the Udrzbari:");

            if (!string.IsNullOrWhiteSpace(Name))
            {
                Models.UdrzbariData.Udrzbari.Add(Name); // Add to the static list
            }
        }
    }
}
