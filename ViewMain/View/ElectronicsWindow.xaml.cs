using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewMain.Model;
using ViewMain.ViewModel;

namespace ViewMain.View
{
    /// <summary>
    /// Логика взаимодействия для ElectronicsWindow.xaml
    /// </summary>
    public partial class ElectronicsWindow : Window
    {
        private readonly ProductViewModel _viewModel;
        public ElectronicsWindow()
        {
            InitializeComponent();

            _viewModel = new ProductViewModel();

            _viewModel.Products.Add(new Product {
                Name = "iPhone 10S",
                Description = "Телефон",
                Cost = 100000
            }
            );
            _viewModel.Products.Add(new Product {
                Name = "Lenovo M11",
                Description = "Ноутбук",
                Cost = 120000
            }
            );
            _viewModel.Products.Add(new Product
            {
                Name = "Xiaomi NT",
                Description = "Планшет",
                Cost = 75000
            }
            );
            DataContext = _viewModel;

            // Подписка на событие от UserControl!!!!
            productControl.BackRequested += ProductControl_BackRequested;

            productControl.SwitchRequested += (_, __) =>
            {
                new VegetableWindow().Show();
                this.Close();
            };
        }

        private void ProductControl_BackRequested(object? sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
