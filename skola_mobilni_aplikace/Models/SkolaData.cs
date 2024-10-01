using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skola_mobilni_aplikace.Models
{
    public static class SkolaData
    {
        public static ObservableCollection<string> Skola { get; } = new ObservableCollection<string>();
    }
}