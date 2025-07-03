using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using ViewMain.Model;

namespace ViewMain.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }

        private Product? _selectedProduct;
        public Product? SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
                CommandManager.InvalidateRequerySuggested();  
                                                              
                if (_selectedProduct != null)
                {
                    Name = _selectedProduct.Name;
                    Description = _selectedProduct.Description;
                    Cost = _selectedProduct.Cost;
                                       
                }
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        private decimal _cost;
        public decimal Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();

            AddProductCommand = new(AddProduct, CanAddProduct);
            EditProductCommand = new(EditProduct);
            DeleteProductCommand = new(DeleteProduct);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        
        public RelayCommand AddProductCommand { get; set; }
        public RelayCommand EditProductCommand { get; set; }
        public RelayCommand DeleteProductCommand { get; set; }

          private bool CanAddProduct(object? parameter)
        {
            return !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Description)
                && Cost > 0;
        }

        
        private void ClearFields()
        {
            Name = string.Empty;
            Description = string.Empty;
            Cost = 0;
        }

        private void AddProduct(object? parameter)
        {
            var product = new Product
            {
                Name = this.Name,
                Description = this.Description,
                Cost = this.Cost
            };

            Products.Add(product);
            ClearFields();
                       
        }

        private void EditProduct(object? parameter)
        {
            if (SelectedProduct != null)
            {
                SelectedProduct.Name = Name;
                SelectedProduct.Description = Description;
                SelectedProduct.Cost = Cost;

                OnPropertyChanged(nameof(Products));
                CommandManager.InvalidateRequerySuggested();
            }
        }

        private void DeleteProduct(object? parameter)
        {
            if (SelectedProduct != null)
            {
                Products.Remove(SelectedProduct);
                SelectedProduct = null;

                ClearFields();
               
            }
        }
    }
      
}
