using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_8.RecursosInterfaz;
using Logica;

namespace Ejercicio_8
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            CargarCbxPrestamo();
            CargarCbxMeses();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Validacion();
        }

        public void CargarCbxPrestamo() { 

        CbxPrestamo OpcionDefecto = new CbxPrestamo
        {
            Texto = "Seleccione una opcion",
            Valor = null
        };

        CbxPrestamo OpcionPersonal = new CbxPrestamo
        {
            Texto = "Personal",
            Valor = 1
        };

        CbxPrestamo OpcionAutomovil = new CbxPrestamo
        {
            Texto = "Automovil",
            Valor = 2
        };

        CbxPrestamo OpcionHipotecario = new CbxPrestamo
        {
            Texto = "Hipotecario",
            Valor = 3
        };

            cbxPrestamo.Items.Add(OpcionDefecto);
            cbxPrestamo.Items.Add(OpcionPersonal);
            cbxPrestamo.Items.Add(OpcionAutomovil);
            cbxPrestamo.Items.Add(OpcionHipotecario);
            cbxPrestamo.SelectedItem = OpcionDefecto;

        }

        public void CargarCbxMeses() 
        {

            CbxMeses OpcionDefecto = new CbxMeses
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            int meses = 0;

            cbxMeses.Items.Add(OpcionDefecto);
            cbxMeses.SelectedItem = OpcionDefecto;

            for (int i = 12; i <= 120; i += 6)
            {

                meses++;

                CbxMeses Opciones = new CbxMeses
                {
                    Texto = i + " Meses",
                    Valor = meses
                };

                cbxMeses.Items.Add(Opciones);

            }

        }

        public void Validacion()
        {

            try
            {

                CbxPrestamo PrestamoSeleccionado = cbxPrestamo.SelectedItem as CbxPrestamo;
                CbxMeses MesSeleccionado = cbxMeses.SelectedItem as CbxMeses;

                if (PrestamoSeleccionado.Valor == null)
                {
                    MessageBox.Show("Debe seleccionar el tipo de prestamo", "Error");
                }

                else if (MesSeleccionado.Valor == null)
                {
                    MessageBox.Show("Debe seleccionar la cantidad de meses", "Error");
                }

                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Debe ingresar un monto", "Error");
                }

                else
                {

                    Calcular calcular = new Calcular();

                    double monto = Convert.ToDouble(txtMonto.Text);
                    int meses = (int)MesSeleccionado.Valor; 
                    int prestamo = (int)PrestamoSeleccionado.Valor;
                    txtResultado.Text = Convert.ToString(calcular.Operacion(prestamo, meses, monto));

                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Solo se aceptan numeros", "Error");
            }

        }


    }
}