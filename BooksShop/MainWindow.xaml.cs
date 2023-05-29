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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        DataSet1 dataSet;
        EmployeeTableAdapter employee;

        public MainWindow()
        {
            InitializeComponent();
            dataSet = new DataSet1();
            employee = new EmployeeTableAdapter();

            employee.Fill(dataSet.Employee);

            DataGrid.ItemsSource = dataSet.Employee.DefaultView;
            DataGrid.SelectionMode = DataGridSelectionMode.Single;
            DataGrid.SelectedValue = "ID_Employee";
            DataGrid.CanUserAddRows = false;
            DataGrid.CanUserDeleteRows = false;
            DataGrid.IsReadOnly = true;
        }
        public static string Surname;
        public static string Name;
        public static string MiddleName;

        private void Autorization_Click(object sender, RoutedEventArgs e)
        {

            int count = dataSet.Employee.Rows.Count;
            string login, password;
            int roles;

            for (int i = 0; i < count; i++)
            {
                DataRowView dataRowView = (DataRowView)DataGrid.Items[index: i];

                login = dataRowView.Row.Field<string>("Login");
                password = dataRowView.Row.Field<string>("Password");
                roles = dataRowView.Row.Field<int>("Role_ID");
                Surname = dataRowView.Row.Field<string>("Surname");
                Name = dataRowView.Row.Field<string>("Name");
                MiddleName = dataRowView.Row.Field<string>("MiddleName");

                if (TXTLogin.Text == login && TXTPassword.Text == password)
                {
                    if (roles == 1)
                    {
                        Auto.Content = new Administrator();
                    }
                    if (roles == 3)
                    {
                        Auto.Content = new User();
                    }


                    if (roles == 2)
                    {
                        Auto.Content = new Manager();
                    }
                }

            }

        }
    }
}

