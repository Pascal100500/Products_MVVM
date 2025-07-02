using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewMain.Model;

namespace ViewMain.ViewModel
{
    public class ElectronicsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }

        public ElectronicsViewModel()
        {
            Products = new ObservableCollection<Product>
        {
            new() { Name = "iPhone 10S", Description = "Телефон", Cost = 100000 },
            new() { Name = "Lenovo M11", Description = "Ноутбук", Cost = 120000 },
            new() { Name = "Xiaomi NT", Description = "Планшет", Cost = 75000 }
        };
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
