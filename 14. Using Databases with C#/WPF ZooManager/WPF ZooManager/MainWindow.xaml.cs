using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            
            
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Data Source=Philip_Luke\\PANJUTORIALSSQL;Initial Catalog=CSharpMasterClass;Persist Security Info=True;User ID=sa;Password=H+:gr~MOORGs;Pooling=False"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            
        }

        private void ShowZoos()
        {
            string query = "SELECT * FROM Zoo";
            // The Sql Adapter can be imagined like an Interface to make tables usable by C# objects
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            using (sqlDataAdapter)
            {
                DataTable zooTable = new DataTable();
                sqlDataAdapter.Fill(zooTable);

                // Which info of the table in DataTable should be shown in our ListBox?
                listZoos.DisplayMemberPath = "Location";
                // Which value should be delivered, when an Item from our ListBox is selected?
                listZoos.SelectedValuePath = "Id";
                // The reference to the data the listbox should populate
                listZoos.ItemsSource = zooTable.DefaultView;

            }
        }


    }
}
