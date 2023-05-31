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

namespace BooksShop
{
    /// <summary>
    /// Логика взаимодействия для OrderAdmin.xaml
    /// </summary>
    public partial class OrderAdmin : Page
    {
        DataSet1 dataSet;
        OrderTableAdapter order;
        CustomerTableAdapter customer;
        View_OrderTableAdapter orderView;
        View_OrderProductTableAdapter orderProduct;
        ProductTableAdapter tableAdapter;
        public OrderAdmin()
        {
            InitializeComponent();
            dataSet = new DataSet1();
            order = new OrderTableAdapter();
            customer = new CustomerTableAdapter();
            orderView = new View_OrderTableAdapter();
            tableAdapter = new ProductTableAdapter();
            orderProduct = new View_OrderProductTableAdapter();

            order.Fill(dataSet.Order);
            customer.Fill(dataSet.Customer);
            orderView.Fill(dataSet.View_Order);
            tableAdapter.Fill(dataSet.Product);
            orderProduct.Fill(dataSet.View_OrderProduct);

            CBSurname.ItemsSource = dataSet.Customer.DefaultView;
            CBSurname.DisplayMemberPath = "Surname";
            CBSurname.SelectedValuePath = "ID_Customer";

            DataGrid.ItemsSource = dataSet.View_OrderProduct.DefaultView;
            DataGrid.SelectedValuePath = "ID_OrderProduct";
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if(CBDateOrder.SelectedDate <DateTime.Now)
            {
                string date = DateTime.Now.ToString("dd.MM.yyyy");

                order.UpdateQuery(CBDateOrder.Text, (int)CBSurname.SelectedValue, (int)DataGrid.SelectedItem);
                orderView.Fill(dataSet.View_Order);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataRowView dataRowView = (DataRowView)DataGrid.SelectedItem;
            if(dataRowView != null)
            {
                CBDateOrder.Text = dataRowView.Row.Field<string>("Номер_товара");
                CBSurname.Text = dataRowView.Row.Field<string>("Номер_заказа");
                CBQuantity.Text = dataRowView.Row.Field<string>("Количество");
            }
        }
    }
}
