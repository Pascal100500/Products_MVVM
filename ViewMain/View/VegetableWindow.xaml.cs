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
    /// Логика взаимодействия для VegetableWindow.xaml
    /// </summary>
    public partial class VegetableWindow : Window
    {
        private readonly ProductViewModel _viewModel;

        public VegetableWindow()
        {
            InitializeComponent();

            _viewModel = new ProductViewModel();

            _viewModel.Products.Add(new Product { 
                Name = "Капуста белая",
                Description = "Капуста", 
                Cost = 50_000
            }
            );
            _viewModel.Products.Add(new Product { 
                Name = "Картофель мытый",
                Description = "Картофель",
                Cost = 70_000 
            }
            );
            _viewModel.Products.Add(new Product { 
                Name = "Морковь в упаковке",
                Description = "Морковь", 
                Cost = 10_000
            }
            );

            DataContext = _viewModel;

            // Подписка на событие от UserControl!!!!
            productControl.BackRequested += ProductControl_BackRequested;

            productControl.SwitchRequested += (_, __) =>
            {
                new ElectronicsWindow().Show();
                this.Close();
            };
        }

        private void ProductControl_BackRequested(object? sender, System.EventArgs e)
        {
            this.Close(); 
        }
    }
}
