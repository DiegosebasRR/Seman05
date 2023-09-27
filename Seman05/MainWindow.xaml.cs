using System;
using System.Collections.Generic;
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

namespace Seman05
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=LAB1504-32\\SQLEXPRESS;Initial Catalog=Neptuno3;User ID=admin;Password=admin";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("InsertarCliente", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", txtIdCliente.Text);
                    cmd.Parameters.AddWithValue("@NombreCompañia", txtNombreCompañia.Text);
                    cmd.Parameters.AddWithValue("@NombreContacto", txtNombreContacto.Text);
                    cmd.Parameters.AddWithValue("@CargoContacto", txtCargoContacto.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text);
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                    cmd.Parameters.AddWithValue("@CodPostal", txtCodPostal.Text);
                    cmd.Parameters.AddWithValue("@Pais", txtPais.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Fax", txtFax.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente ingresado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la cliente: " + ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Listar listarWindow = new Listar();
            listarWindow.Show();
        }
    }
}
