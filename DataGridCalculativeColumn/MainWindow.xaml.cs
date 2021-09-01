using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGridCalculativeColumn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NorthwindEntities db = null;
        ObservableCollection<Product> productCollection;
        public MainWindow()
        {
            InitializeComponent();
            db = new NorthwindEntities();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            productCollection = new ObservableCollection<Product>(db.Products.OrderByDescending(p => p.ProductID));
            datagrid1.DataContext = productCollection;
        }
    }
}
