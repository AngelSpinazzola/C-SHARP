using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using App.Logica;
using System.Windows.Forms;

namespace App.Data
{
    public class Dclientes
    {
        public void InsertarCliente(Lcliente parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarClientes", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", parametros.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Edad", parametros.Edad);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente registrado");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void EditarCliente(Lcliente parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("editarClientes", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", parametros.IdCliente);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Edad", parametros.Edad);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");



            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Conexion.cerrar();
            }
        }
        public void MostrarClientes(ref DataTable dt)
        {
            try
            {
                Conexion.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarClientes", Conexion.conectar);
                da.Fill(dt);
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public void EliminarCliente(Lcliente parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("EliminarClientes", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", parametros.IdCliente);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado");


            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
