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
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace BooksShop
{
    /// <summary>
    /// Логика взаимодействия для ProductManager.xaml
    /// </summary>
    public partial class ProductManager : Page
    {
        DataSet1 dataSet1;
        ProductTableAdapter tableAdapter;
        TypeProductTableAdapter typeProductAdapter;
        View_ProductTableAdapter viewproduct;

        public ProductManager()
        {
            InitializeComponent();
            dataSet1 = new DataSet1();
            tableAdapter = new ProductTableAdapter();
            typeProductAdapter = new TypeProductTableAdapter();
            viewproduct = new View_ProductTableAdapter();

            tableAdapter.Fill(dataSet1.Product);
            typeProductAdapter.Fill(dataSet1.TypeProduct);
            viewproduct.Fill(dataSet1.View_Product);

            Types.ItemsSource = dataSet1.TypeProduct.DefaultView;
            Types.DisplayMemberPath = "Type";
            Types.SelectedValuePath = "ID_Type";

            ListView.ItemsSource = dataSet1.View_Product.DefaultView;
            ListView.SelectedValuePath = "ID_Product";
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            bool typeproduct = Regex.Match(Types.Text, "^[А-Я][а-яА-Я]*$").Success;

            DataRowView dataRowView = (DataRowView)ListView.SelectedItem;
            if(dataRowView != null)
            {
                Types.Text = dataRowView.Row.Field<string>("Тип_товара");
            }

            if(ListView.SelectedItem != null)
            {
                tableAdapter.DeleteQuery((int)ListView.SelectedValue);
                viewproduct.Fill(dataSet1.View_Product);
            }


           


        }
    }
}
