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
    public class VegetableViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }

        public VegetableViewModel()
        {
            Products = new ObservableCollection<Product>
        {
            new() { Name = "Капуста белая", Description = "Капуста", Cost = 50000 },
            new() { Name = "Картофель мытый", Description = "Картофель", Cost = 70000 },
            new() { Name = "Морковь упакованная", Description = "Морковь", Cost = 10000 }
        };
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
