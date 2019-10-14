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
    /// Lógica de interacción para Sodas.xaml
    /// </summary>
    public partial class Sodas : UserControl
    {
        public Sodas()
        {
            InitializeComponent();
        }
        public string precio
        {
            get
            {
                return txtprecio.Text;
            }
            set
            {
                txtprecio.Text = value;
            }
        }
        public string codigo
        {
            get
            {
                return txtcodigo.Text;
            }
            set
            {
                txtcodigo.Text = value;
            }
        }
        public string producto
        {
            get
            {
                return txtproducto.Text;
            }
            set
            {
                txtproducto.Text = value;
            }
        }
        public string descuento
        {
            get
            {
                return txtdescuento.Text;
            }
            set
            {
                txtdescuento.Text = value;
            }
        }
        public string proveedor
        {
            get
            {
                return txtproveedor.Text;
            }
            set
            {
                txtproveedor.Text = value;
            }
        }
    }
}
