using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FrmPrincipal
{
    public partial class FrmPPrincipal : Form
    {
        // Creación de la conexión
        SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
                                integrated security = true; database = AdventureWorks2014;");
        
        public FrmPPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Utilizado para dar cierre al formulario principal de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmPPrincipal_Load(object sender, EventArgs e)
        {
            // Creación de la consulta principal
            string sql = "SELECT Name FROM Production.Product WHERE FinishedGoodsFlag = 1";

            // Creación del comando
            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                // Se procede a abrir la conexión
                conn.Open();

                // Ejecutamos el comando mediante DataReader
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    lstbProductos.Items.Add(rdr[0]);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
            }
            finally
            {
                // Si se realiza o no lo anterior, se procede a cerrar la conexión
                conn.Close();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtNombreUsuario.Text == "" || txtCorreoUsuario.Text == "")
            {
                MessageBox.Show("Hay campos vacíos, Revise","ERROR", MessageBoxButtons.OK);
            }
            else
            {
                // Creación del comando
                SqlCommand cmd = new SqlCommand("sp_AgregarResenia", conn);

                // Definimos el comando como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    // Iniciamos conexión
                    conn.Open();

                    // Se definen los parámetros necesarios para el Stored Procedure
                    cmd.Parameters.Add(new SqlParameter("@ProductName", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@ProductName"].Value = lstbProductos.SelectedValue;

                    cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Usuario"].Value = txtNombreUsuario.Text;

                    cmd.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@Email"].Value = txtCorreoUsuario.Text;

                    cmd.Parameters.Add(new SqlParameter("@FechaR", SqlDbType.DateTime));
                    cmd.Parameters["@FechaR"].Value = System.DateTime.Now;

                    cmd.Parameters.Add(new SqlParameter("@FechaM", SqlDbType.DateTime));
                    cmd.Parameters["@FechaM"].Value = System.DateTime.Now;

                    cmd.Parameters.Add(new SqlParameter("@Comentario", SqlDbType.NVarChar, 3850));
                    if (txtComentarios.Text=="")
                    {
                        cmd.Parameters["@Comentario"].Value = "El usuario no tiene comentarios";
                    }
                    else
                    {
                        cmd.Parameters["@Comentario"].Value = txtComentarios.Text;
                    }

                    cmd.Parameters.Add(new SqlParameter("@Valoracion", SqlDbType.Int));
                    cmd.Parameters["@Valoracion"].Value = nupValoracion.Value;

                    // Se ejecuta el Query
                    cmd.ExecuteNonQuery();

                    // Se limpian los campos
                    txtNombreUsuario.Text = "";
                    txtCorreoUsuario.Text = "";
                    txtComentarios.Text = "";
                    nupValoracion.Value = 1;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                }
                finally
                {
                    // Cerrar conexión
                    conn.Close();
                }
            }
        }
    }
}
