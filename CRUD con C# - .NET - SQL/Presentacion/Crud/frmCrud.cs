using App.Data;
using App.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace App.Presentacion.Crud
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }

        int idCliente;

        private void frmCrud_Load(object sender, EventArgs e)
        {
            MostrarCLientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarClientes();
        }

        private void InsertarClientes()
        {
            Dclientes funcion = new Dclientes();
            Lcliente parametros = new Lcliente();
            parametros.Codigo= int.Parse(txtCodigo.Text);
            parametros.Nombre = txtNombre.Text;
            parametros.Edad = int.Parse(txtEdad.Text);
            funcion.InsertarCliente(parametros);
            MostrarCLientes();
        }
        private void MostrarCLientes()
        {
            Dclientes funcion = new Dclientes();
            DataTable dt = new DataTable();
            funcion.MostrarClientes(ref dt);
            dataListado.DataSource = dt;
        }

        private void dataListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataListado.Rows.Count > 0)
            {
                idCliente = Convert.ToInt32(dataListado.SelectedCells[0].Value);
                txtCodigo.Text = dataListado.SelectedCells[1].Value.ToString();
                txtNombre.Text = dataListado.SelectedCells[2].Value.ToString();
                txtEdad.Text = dataListado.SelectedCells[3].Value.ToString();
            } 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void Actualizar()
        {
            Dclientes funcion = new Dclientes();
            Lcliente parametros = new Lcliente();
            parametros.IdCliente = idCliente;
            parametros.Nombre = txtNombre.Text;
            parametros.Edad = Convert.ToInt32(txtEdad.Text);
            funcion.EditarCliente(parametros);
            MostrarCLientes();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            Dclientes funcion = new Dclientes();
            Lcliente parametros = new Lcliente();
            parametros.IdCliente = idCliente;
            funcion.EliminarCliente(parametros);
            MostrarCLientes();

        }
    }
}
