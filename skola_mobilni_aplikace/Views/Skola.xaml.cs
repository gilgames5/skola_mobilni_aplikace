using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using static Android.Content.ClipData;
using static Java.Util.Jar.Attributes;
//using skola_mobilni_aplikace.Models;

namespace skola_mobilni_aplikace.Views
{
    public partial class Skola : ContentPage
    {
        //public ObservableCollection<string> CombinedList { get; } = new ObservableCollection<string>();
        
        public Skola()
        {
            InitializeComponent();
            
            CombineData();
            VsichniListView.ItemsSource = Models.SkolaData.Skola;
            //VsichniListView.ItemsSource = CombinedList;
        }

        private void CombineData()
        {
            foreach (var item in Models.PodporaData.Podpora)
            {
                Models.SkolaData.Skola.Add(item);
            }

            foreach (var item in Models.StudentData.Students)
            {
                Models.SkolaData.Skola.Add(item);
            }

            foreach (var item in Models.UciteleData.Ucitele)
            {
                Models.SkolaData.Skola.Add(item);
            }

            foreach (var item in Models.UdrzbariData.Udrzbari)
            {
                Models.SkolaData.Skola.Add(item);
            }
        }
    }
}
