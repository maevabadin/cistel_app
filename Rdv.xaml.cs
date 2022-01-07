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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace cistel_elec_ge
{
    /// <summary>
    /// Logique d'interaction pour Rdv.xaml
    /// </summary>
    public partial class Rdv : Page
    {
        public Rdv()
        {
            InitializeComponent();
          //  FillDataGrid();
           // FillComboBox();
        }

      /*  private void FillDataGrid()
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Data Source=.\\SQLEXPRESS;Database=CISTEL;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT FORMAT (date, 'dd/MM/yyyy ') as date, time, note, lastname, firstname, client_number FROM sXyez_appointments AS appointments INNER JOIN sXyez_clients AS clients ON appointments.id_sXyez_clients = clients.id";
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("datagrid");
            sda.Fill(dt);
            datagrid.ItemsSource = dt.DefaultView;
            sqlConnection1.Close();
        }


        public void FillComboBox()
        {
                String connectionString = "Data Source=.\\SQLEXPRESS;Database=CISTEL;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT id, lastname, firstname FROM sXyez_clients", con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                user.ItemsSource = dt.DefaultView;
                user.DisplayMemberPath = "lastname";
                user.SelectedValuePath = "id";
                cmd.Dispose();
                con.Close();
           
        }
      */
    }
}
