using Microsoft.Maui.Controls;

namespace skola_mobilni_aplikace.Views
{
    public partial class podpora : ContentPage
    {
        public podpora()
        {
            InitializeComponent();
            PodporaListView.ItemsSource = Models.PodporaData.Podpora; // Bind to the static list
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Prompt for student name
            string Name = await DisplayPromptAsync("New Podpora", "Enter the name of the Podpora:");

            if (!string.IsNullOrWhiteSpace(Name))
            {
                Models.PodporaData.Podpora.Add(Name); // Add to the static list
            }
        }
    }
}
