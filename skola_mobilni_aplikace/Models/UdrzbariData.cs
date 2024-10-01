using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skola_mobilni_aplikace.Models
{
    public static class UdrzbariData
    {
        public static ObservableCollection<string> Udrzbari { get; } = new ObservableCollection<string>();
    }
}