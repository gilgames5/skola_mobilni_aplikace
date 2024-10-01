using Microsoft.Maui.Controls;

namespace skola_mobilni_aplikace.Views
{
    public partial class studenti : ContentPage
    {
        public studenti()
        {
            InitializeComponent();
            StudentsListView.ItemsSource = Models.StudentData.Students; // Bind to the static list
        }

        private async void OnAddButtonClicked(object sender, EventArgs e)
        {
            // Prompt for student name
            string studentName = await DisplayPromptAsync("New Student", "Enter the name of the student:");

            if (!string.IsNullOrWhiteSpace(studentName))
            {
                Models.StudentData.Students.Add(studentName); // Add to the static list
            }
        }
    }
}
