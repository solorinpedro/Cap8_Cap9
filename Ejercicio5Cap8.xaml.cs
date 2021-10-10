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
    /// Interaction logic for Ejercicio5Cap8.xaml
    /// </summary>
    public partial class Ejercicio5Cap8 : Window
    {
        public Ejercicio5Cap8()
        {
            InitializeComponent();
        }

        private void OrdenarCadenas_Click(object sender, RoutedEventArgs e)
        {
            int resultado;
            String cadena1 = Cadena1TextBox.Text.ToString();
            String cadena2 = Cadena2TextBox.Text.ToString();
            resultado = String.Compare(cadena1, cadena2);

            resultado = OrdenarListBox.Items.Add(resultado);
        }
    }
}
