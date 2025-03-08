using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class Vehiculos : KryptonForm
    {
        public Vehiculos()
        {
            InitializeComponent();
        }

        public void MtdMostrarVehiculos()
        {
            CD_Vehiculo cd_Vehiculos = new CD_Vehiculo();
            DataTable dtMostrarVehiculos = cd_Vehiculos.MtMostrarVehiculos();
            dgvVehiculos.DataSource = dtMostrarVehiculos;
            dgvVehiculos.Refresh();
            hgroupRegistros.ValuesSecondary.Heading = "Registros: " + dgvVehiculos.Rows.Count.ToString();
        }

        private void Vehiculos_Load(object sender, EventArgs e)
        {
            MtdMostrarVehiculos();
            CD_Vehiculo cD_Vehiculo = new CD_Vehiculo();


            int ultimoID = cD_Vehiculo.ObtenerUltimoID();
            int nuevoID = ultimoID + 1;
            txtIdVehiculo.Text = nuevoID.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CD_Vehiculo cD_Vehiculo = new CD_Vehiculo();
            int ultimoID = cD_Vehiculo.ObtenerUltimoID();
            int nuevoID = ultimoID + 1;
            txtIdVehiculo.Text = nuevoID.ToString();
            txtMarca.Clear();
            txtAnio.Clear();
            txtModelo.Clear();
            txtPrecio.Clear();
            cboxEstado.SelectedIndex = -1;
            txtIdVehiculo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CD_Vehiculo cD_Vehiculo = new CD_Vehiculo();
            try
            {
                cD_Vehiculo.MtdAgregarVehiculos(txtMarca.Text, txtModelo.Text, int.Parse(txtAnio.Text), decimal.Parse(txtPrecio.Text), cboxEstado.Text);

                MessageBox.Show("El Vehiculo se agregó con éxito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                CD_Vehiculo cD_Vehiculo = new CD_Vehiculo();


                int vCantidadRegistros = cD_Vehiculo.MtdActualizarVehiculos(int.Parse(txtIdVehiculo.Text), txtMarca.Text, txtModelo.Text, int.Parse(txtAnio.Text), decimal.Parse(txtPrecio.Text), cboxEstado.Text);

                if (vCantidadRegistros > 0)
                {
                    MessageBox.Show("Registro Actualizado!!", "Correcto!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MtdMostrarVehiculos();
                }
                else
                {
                    MessageBox.Show("No se actualizaron registros. Verifica los datos.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVehiculo.Text = dgvVehiculos.SelectedCells[0].Value.ToString();
            txtMarca.Text = dgvVehiculos.SelectedCells[1].Value.ToString();
            txtAnio.Text = dgvVehiculos.SelectedCells[3].Value.ToString();
            txtPrecio.Text = dgvVehiculos.SelectedCells[4].Value.ToString();
            txtModelo.Text = dgvVehiculos.SelectedCells[2].Value.ToString();
            cboxEstado.Text = dgvVehiculos.SelectedCells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CD_Vehiculo cD_Vehiculo = new CD_Vehiculo();
                cD_Vehiculo.MtdEliminarVehiculo(int.Parse(txtIdVehiculo.Text));

                MessageBox.Show("Registro Eliminado!!", "Correcto!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarVehiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
