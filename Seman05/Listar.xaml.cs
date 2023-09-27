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

namespace Seman05
{
    /// <summary>
    /// Lógica de interacción para Listar.xaml
    /// </summary>
    public partial class Listar : Window
    {
        public static string connectionString = "Data Source=LAB1504-32\\SQLEXPRESS;Initial Catalog=Neptuno3;User ID=admin;Password=admin";
        public Listar()
        {
            InitializeComponent();
            DateTime fechaInicio = new DateTime(1994, 08, 04); // Cambia esta fecha según tus necesidades
            DateTime fechaFin = new DateTime(1994, 09, 01); // Cambia esta fecha según tus necesidades

            Clientes clientes = ListarClientes(fechaInicio, fechaFin);

            // Asigna la lista de detalles de pedido a tu DataGrid
            McDataGrid.ItemsSource = pedidos.Detalles;
        }
    }
}