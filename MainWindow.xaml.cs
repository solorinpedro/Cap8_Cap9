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

namespace Cap8_Cap9
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

        private void Ejercicio3Cap8_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3Cap8 ejercicio = new Ejercicio3Cap8();
            ejercicio.Show();
        }

        private void Ejercicio5Cap8_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio5Cap8 ejercicio = new Ejercicio5Cap8();
            ejercicio.Show();
        }

        private void Ejercicio1Cap9_Click(object sender, RoutedEventArgs e)
        {
            Cap9_ejercicio1 ejercicio = new Cap9_ejercicio1();
            ejercicio.Show();
        }

        private void Ejercicio3cap9_Click(object sender, RoutedEventArgs e)
        {
            Ejercicio3_Cap9 ejercicio = new Ejercicio3_Cap9();
            ejercicio.Show();
        }
    }
}
