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
using ViewMain.ViewModel;

namespace ViewMain.View
{
    /// <summary>
    /// Логика взаимодействия для ElectronicsWindow.xaml
    /// </summary>
    public partial class ElectronicsWindow : Window
    {
        public ElectronicsWindow()
        {
            InitializeComponent();
            DataContext = new ElectronicsViewModel();
        }
    }
}
