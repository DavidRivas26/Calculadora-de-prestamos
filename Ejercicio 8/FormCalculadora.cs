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

        }

        public void CargarCbxMeses() 
        {

            CbxMeses OpcionDefecto = new CbxMeses
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            int f = 0;

            for (int i = 12; i <= 120; i += 6)
            {

                f++;

                CbxMeses Opciones = new CbxMeses
                {
                    Texto = i + "Meses",
                    Valor = f
                };

            }
        }

    }
}