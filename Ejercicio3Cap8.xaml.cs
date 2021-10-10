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
    /// Interaction logic for Ejercicio3Cap8.xaml
    /// </summary>
    public partial class Ejercicio3Cap8 : Window
    {
        public Ejercicio3Cap8()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {
            TextBoxtHora.Text = DateTime.Now.ToString();

        }
    }
}
