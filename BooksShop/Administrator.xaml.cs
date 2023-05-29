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
using BooksShop.DataSet1TableAdapters;

namespace BooksShop
{
    /// <summary>
    /// Логика взаимодействия для Administrator.xaml
    /// </summary>
    public partial class Administrator : Page
    {
        DataSet1 dataSet;
        EmployeeTableAdapter employeeTableAdapter;

        
        public Administrator()
        {
            InitializeComponent();
            dataSet = new DataSet1();
            employeeTableAdapter = new EmployeeTableAdapter();

            employeeTableAdapter.Fill(dataSet.Employee);

            DataGrid.ItemsSource = dataSet.Employee.DefaultView;
            DataGrid.SelectionMode = DataGridSelectionMode.Single;
            DataGrid.SelectedValuePath = "ID_Employee";
            DataGrid.CanUserAddRows = false;
            DataGrid.CanUserDeleteRows = false;
            DataGrid.IsReadOnly = true;

            Surname.Text = MainWindow.Surname;
            Name.Text = MainWindow.Name;
            Middle.Text = MainWindow.MiddleName;
        }
        

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Exits.Content = new MainWindow();
        }

        private void Product_Click(object sender, RoutedEventArgs e)
        {
            Exits.Content = new ProductAdmin();
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            Exits.Content = new OrderAdmin();
        }
    }
}
