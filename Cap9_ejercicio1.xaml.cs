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

namespace Cap8_Cap9
{
    /// <summary>
    /// Interaction logic for Cap9_ejercicio1.xaml
    /// </summary>
    public partial class Cap9_ejercicio1 : Window
    {
        public Cap9_ejercicio1()
        {
            InitializeComponent();
        }

        private void GuardarProductos_Click(object sender, RoutedEventArgs e)
        {
            Productos productos = new Productos();
            productos.NombreProducto = NombreTextBox.Text.ToString();
            productos.CantidadProducto = int.Parse(TextBoxCantidad.Text.ToString());
            productos.ExistenciaProducto = int.Parse(TextBoxExistencia.Text.ToString());
            productos.DescripcionProducto = TexboxtDescripcion.Text.ToString();
            MessageBox.Show("Guardo Correctamente Bro!");

        }
        public struct Productos
        {
            public string NombreProducto;
            public int CantidadProducto;
            public int ExistenciaProducto;
            public string DescripcionProducto;
        }
    }
}
