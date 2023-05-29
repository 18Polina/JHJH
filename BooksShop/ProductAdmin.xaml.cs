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
using BooksShop.DataSet1TableAdapters;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BooksShop
{
    /// <summary>
    /// Логика взаимодействия для ProductAdmin.xaml
    /// </summary>
    public partial class ProductAdmin : Page
    {
        DataSet1 dataSet;
        ProductTableAdapter product;
        TypeProductTableAdapter productType;
        ManufactureTableAdapter manufacture;
        View_ProductTableAdapter productView;

        public ProductAdmin()
        {
            InitializeComponent();
            dataSet = new DataSet1();
            product = new ProductTableAdapter();
            productType = new TypeProductTableAdapter();
            manufacture = new ManufactureTableAdapter();
            productView = new View_ProductTableAdapter();

            product.Fill(dataSet.Product);
            productType.Fill(dataSet.TypeProduct);
            manufacture.Fill(dataSet.Manufacture);
            productView.Fill(dataSet.View_Product);


            CBManufProduct.ItemsSource = dataSet.Manufacture.DefaultView;
            CBManufProduct.DisplayMemberPath = "Country";
            CBManufProduct.SelectedValuePath = "ID_Manufacture";


            CBTypeProduct.ItemsSource = dataSet.TypeProduct.DefaultView;
            CBTypeProduct.DisplayMemberPath = "Type";
            CBTypeProduct.SelectedValuePath = "ID_TypeProduct";

            DataGrid.ItemsSource = dataSet.View_Product.DefaultView;
            DataGrid.SelectedValuePath = "ID_Product";
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            //int manuf = (int)CBManufProduct.SelectedValue;
            bool name = Regex.Match(NameProduct.Text, "^[А-Я][а-яА-Я]*$").Success;
            if(NameProduct.Text.Equals("") || name)
            {
                product.Insert(NameProduct.Text, (int)CBTypeProduct.SelectedValue, (int)CBManufProduct.SelectedValue);
                productView.Fill(dataSet.View_Product);
                NameProduct.Text = "";
            }
            else
            {
                MessageBox.Show("Название товара введено неверно");
            }
           
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            bool name = Regex.Match(NameProduct.Text, "^[А-Я][а-яА-Я]*$").Success;
            if (NameProduct.Text.Equals("") || name)
            {
                product.UpdateQuery(NameProduct.Text, (int)CBTypeProduct.SelectedValue, (int)CBManufProduct.SelectedValue, (int)DataGrid.SelectedItem);
                productView.Fill(dataSet.View_Product);
                
            }
            else
            {
                MessageBox.Show("Название товара введено неверно");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if(DataGrid.SelectedItem != null)
            {
                product.DeleteQuery((int)DataGrid.SelectedValue);
                productView.Fill(dataSet.View_Product);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Exits.Content = new Administrator();
        }


    }
}
