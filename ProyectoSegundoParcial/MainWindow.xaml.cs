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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variable que define si se está mostrando algo en el grdParametrosProducto
        bool show = false;
        
        // Strings para guardar los parámetros de los UAC
        string producto;
        string codigo;
        string precio;
        string descuento;
        string proveedor;

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Agregar_Click(object sender, RoutedEventArgs e)
        {
            // Show & Hide Validations
            show = true;
            grdParametrosProducto.Children.Clear();
            btn_Cancelar.Visibility = Visibility.Visible;
            btn_Guardar.Visibility = Visibility.Visible;
            cbProductos.IsEnabled = false;

            switch (cbProductos.SelectedIndex)
            {
                case 0: // Smoothies
                    grdParametrosProducto.Children.Add(new Smoothie());
                    break;

                case 1: // Blizzard
                    grdParametrosProducto.Children.Add(new Blizzard());
                    break;

                case 2: // Conos
                    grdParametrosProducto.Children.Add(new Conos());
                    break;

                case 3: // Pasteles
                    grdParametrosProducto.Children.Add(new Pasteles());
                    break;

                case 4: // Café frío
                    grdParametrosProducto.Children.Add(new CafeFrio());
                    break;

                case 5: // Sodas
                    grdParametrosProducto.Children.Add(new Sodas());
                    break;
                    
                default: // Default
                    break;
            }
        }

        private void Button_Cancelar(object sender, RoutedEventArgs e)
        {
            if(show)
            {
                grdParametrosProducto.Children.Clear();
                btn_Cancelar.Visibility = Visibility.Hidden;
                btn_Guardar.Visibility = Visibility.Hidden;
                cbProductos.IsEnabled = true;

                show = false;
            }
            show = false;
        }
        
        private void Button_Guardar(object sender, RoutedEventArgs e)
        {
            switch (cbProductos.SelectedIndex)
            {
                case 0: // Smoothies
                    codigo = ((Smoothie)grdParametrosProducto.Children[0]).codigo;
                    producto = ((Smoothie)grdParametrosProducto.Children[0]).producto;
                    descuento = ((Smoothie)grdParametrosProducto.Children[0]).descuento;
                    precio = ((Smoothie)grdParametrosProducto.Children[0]).precio;
                    proveedor = ((Smoothie)grdParametrosProducto.Children[0]).proveedor;
                    break;

                case 1: // Blizzard
                    codigo = ((Blizzard)grdParametrosProducto.Children[0]).codigo;
                    producto = ((Blizzard)grdParametrosProducto.Children[0]).producto;
                    descuento = ((Blizzard)grdParametrosProducto.Children[0]).descuento;
                    precio = ((Blizzard)grdParametrosProducto.Children[0]).precio;
                    proveedor = ((Blizzard)grdParametrosProducto.Children[0]).proveedor;
                    break;

                case 2: // Conos
                    codigo = ((Conos)grdParametrosProducto.Children[0]).codigo;
                    producto = ((Conos)grdParametrosProducto.Children[0]).producto;
                    descuento = ((Conos)grdParametrosProducto.Children[0]).descuento;
                    precio = ((Conos)grdParametrosProducto.Children[0]).precio;
                    proveedor = ((Conos)grdParametrosProducto.Children[0]).proveedor;
                    break;

                case 3: // Pasteles
                    codigo = ((Pasteles)grdParametrosProducto.Children[0]).codigo;
                    producto = ((Pasteles)grdParametrosProducto.Children[0]).producto;
                    descuento = ((Pasteles)grdParametrosProducto.Children[0]).descuento;
                    precio = ((Pasteles)grdParametrosProducto.Children[0]).precio;
                    proveedor = ((Pasteles)grdParametrosProducto.Children[0]).proveedor;
                    break;

                case 4: // Café frío
                    codigo = ((CafeFrio)grdParametrosProducto.Children[0]).codigo;
                    producto = ((CafeFrio)grdParametrosProducto.Children[0]).producto;
                    descuento = ((CafeFrio)grdParametrosProducto.Children[0]).descuento;
                    precio = ((CafeFrio)grdParametrosProducto.Children[0]).precio;
                    proveedor = ((CafeFrio)grdParametrosProducto.Children[0]).proveedor;
                    break;

                case 5: // Sodas
                    codigo = ((Sodas)grdParametrosProducto.Children[0]).codigo;
                    producto = ((Sodas)grdParametrosProducto.Children[0]).producto;
                    descuento = ((Sodas)grdParametrosProducto.Children[0]).descuento;
                    precio = ((Sodas)grdParametrosProducto.Children[0]).precio;
                    proveedor = ((Sodas)grdParametrosProducto.Children[0]).proveedor;
                    break;

                default: // Default
                    break;
            }

            // Validation of fields
            if ( Validacion() )
            {
                show = false; 
            }
            else
            {
                show = true;
            }

            // If everything is correct, it "saves"
            if (!show)
            {
                grdParametrosProducto.Children.Clear();
                btn_Cancelar.Visibility = Visibility.Hidden;
                btn_Guardar.Visibility = Visibility.Hidden;
                cbProductos.IsEnabled = true;

                show = false;
            }
            // If there is an empty field, an error shows up
            else
            {
                grdParametrosProducto.Children.Add(new Validacion());
            }
        }

        public bool Validacion()
        {
            if (String.Equals(producto, "") || String.Equals(precio, "") || String.Equals(codigo, "") || String.Equals(proveedor, "") || String.Equals(descuento, ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}