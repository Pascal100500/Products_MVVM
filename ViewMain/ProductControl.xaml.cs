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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ViewMain
{
    /// <summary>
    /// Логика взаимодействия для ProductControl.xaml
    /// </summary>
    public partial class ProductControl : UserControl
    {
        public event EventHandler? BackRequested;
        public event EventHandler? SwitchRequested;
        public ProductControl()
        {
            InitializeComponent();
        }

        public string SwitchButtonText
        {
            get { return (string)GetValue(SwitchButtonTextProperty); }
            set { SetValue(SwitchButtonTextProperty, value); }
        }

        public static readonly DependencyProperty SwitchButtonTextProperty =
            DependencyProperty.Register("SwitchButtonText", typeof(string), typeof(ProductControl), new PropertyMetadata("Перейти в след. категорию"));
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackRequested?.Invoke(this, EventArgs.Empty);
        }

        private void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            SwitchRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
