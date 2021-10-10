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
using static Cap8_Cap9.Ejercicio3_Cap9.Propietario;

namespace Cap8_Cap9
{
    /// <summary>
    /// Interaction logic for Ejercicio3_Cap9.xaml
    /// </summary>
    public partial class Ejercicio3_Cap9 : Window
    {
        public Ejercicio3_Cap9()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
           Propietario datos = new Propietario();
            Mascota mascota = new Mascota();
            datos.nombre = PropietarioTextBox.Text.ToString();
            datos.apellido = ApellidoTextBox.Text.ToString();
            datos.direccion = DireccionTextBox.Text.ToString();
            mascota.NombreMascota = NombreMascotaTextBox.Text.ToString();
            mascota.edadMascota = int.Parse(EdadTexbox.Text.ToString());
            mascota.Descripcion = DescripcionTextBox.Text.ToString();
            MessageBox.Show("Datos Guardado Correctamente");
           
        }
        public struct Propietario
        {
            public string nombre;
            public string apellido;
            public string direccion;

            public Propietario(string nombre, string apellido, string direccion)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.direccion = direccion;
            }
            public struct Mascota
            {
                public string NombreMascota;
                public  int edadMascota;
                public  string Descripcion;

                public Mascota(string NombreMascota, int edadMascota, string Descripcion)
                {
                    this.NombreMascota = NombreMascota;
                    this.edadMascota = edadMascota;
                    this.Descripcion = Descripcion;
                }
            }
        }
    }
}
