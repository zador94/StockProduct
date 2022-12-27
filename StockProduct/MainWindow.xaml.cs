using System;
using System.Collections;
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

namespace StockProduct
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddForm(object sender, RoutedEventArgs e)
        {
            LabelProduct = new Label()
            {
                Content = "Product",
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Foreground = Brushes.Blue,
                Margin = new Thickness(0, 10, 0, 0),
            };

            NameProduct = new TextBox()
            {
                Name = "Product",
                VerticalAlignment = VerticalAlignment.Center,
                Height = 25,
                Width = 150,
                Margin = new Thickness(0, 10, 0, 0)
            };

            LabelPrice = new Label()
            {
                Content = "Price",
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Foreground = Brushes.Blue,
                Margin = new Thickness(0, 10, 0, 0),
            };
            
            NamePrice = new TextBox()
            {
                Name = "Price",
                VerticalAlignment = VerticalAlignment.Center,
                Height = 25,
                Width = 150,
                Margin = new Thickness(0, 10, 0, 0)
            };
            
            LabelQuantity = new Label()
            {
                Content = "Quantity",
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Foreground = Brushes.Blue,
                Margin = new Thickness(0, 10, 0, 0),
            };
            
            NameQuantity = new TextBox()
            {
                Name = "Quantity",
                VerticalAlignment = VerticalAlignment.Center,
                Height = 25,
                Width = 150,
                Margin = new Thickness(0, 10, 0, 0)
            };
            
            PanelProduct.Children.Add(LabelProduct);
            PanelProduct.Children.Add(NameProduct);
            PanelPrice.Children.Add(LabelPrice);
            PanelPrice.Children.Add(NamePrice);
            PanelQuantity.Children.Add(LabelQuantity);
            PanelQuantity.Children.Add(NameQuantity);
        }

        
        public void AddToBase(object sender, RoutedEventArgs e)
        {
            AddProductStock addProductStock = new AddProductStock();
            /*foreach (var item in ListBox.Items)
            {
                addProductStock.addProduct(NameProduct.Text, NamePrice.Text, NameQuantity.Text);
            }*/
            
            
        }
        
    }
}