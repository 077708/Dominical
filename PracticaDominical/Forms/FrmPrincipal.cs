using Domain.Enums;
using Domain.Producto;
using Repository.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDominical.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dtaDatos.DataSource = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.FindAll();
            cmbMarca.Items.AddRange(Enum.GetValues(typeof(Marca)).Cast<Object>().ToArray());
            cmbMarcasss.Items.AddRange(Enum.GetValues(typeof(Marca)).Cast<Object>().ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pro p = new Pro()
            {
                Codigo = 1233,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Marca = (Marca)cmbMarca.SelectedItem,
                Precio = decimal.Parse(txt.Text),
            };

            UnidadDeTrabajo.unidadDeTrabajo.productoRepository.Add(p);
            dtaDatos.DataSource = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.FindAll();
        }

        private void dtaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtaDatos.DataSource = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.FindAll();
        }

        private void btnGetByName_Click(object sender, EventArgs e)
        {
            List<Pro> lsi = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.GetByName(txtGetName.Text);
            dtaDatos.ClearSelection();
            dtaDatos.DataSource = lsi;

        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            List<Pro> lsi = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.GetByPrice(decimal.Parse(textBox1.Text));
            dtaDatos.ClearSelection();
            dtaDatos.DataSource = lsi;
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            List<Pro> lsi = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.GetByMarcas((Marca)cmbMarcasss.SelectedItem);
            dtaDatos.ClearSelection();
            dtaDatos.DataSource = lsi;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            Pro lsi = UnidadDeTrabajo.unidadDeTrabajo.productoRepository.GetByCodigo(int.Parse(txtCodigot.Text));
            dtaDatos.ClearSelection();
            dtaDatos.DataSource = lsi;
        }
    }
}
