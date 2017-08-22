using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;

namespace SGD
{
    public partial class Mantenimiento_Usuarios : Form
    {
        public Mantenimiento_Usuarios()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            // Crear conexion para insertar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [usuario] ([usuario] ,[contrasena] ,[email] ,[activo]) VALUES ('" + txt_usuario.Text + "', '" + txt_contrasena.Text + "', '" + txt_email.Text + "', '" + cmb_estatus.SelectedItem.ToString() + "')";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para insertar los datos de la tabla empleado
                conexion.Open();

                // Definir comando para la conexion
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);


                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show("Data guardada!");
                }
            }
            catch (Exception x)
            {

                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // Crear conexion para actualizar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            // Definir el comando sql para actualizar el dato seleccionado
            string sql = "UPDATE [usuario] SET [usuario] = " + "'" + txt_usuario.Text + "'" + " ,[contrasena] = " + "'" + txt_contrasena.Text + "'" + " ,[email] = " + "'" + txt_email.Text + "'" + " ,[activo] = " + "'" + cmb_estatus.Text + "'" + " WHERE id =" + txt_ID_usuario.Text +';';


            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para actualizar los datos de la tabla empleado
                conexion.Open();

                // Definir comando para la conexion
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);


                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show("Data actualizada!");
                    dgv_usuarios.Update();
                    dgv_usuarios.Refresh();

                }
            }
            catch (Exception x)
            {

                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }
        }

        private void btn_eliminar_usuario_Click(object sender, EventArgs e)
        {

            // Crear conexion para eliminar el dato seleccionado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            // Definir el comando sql para eliminar el dato seleccionado
            string sql = "DELETE from usuario WHERE id =" + txt_ID_usuario.Text +';';
            try
            {
                // Abrir conexion para eliminar el dato seleccionado
                conexion.Open();

                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);

                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    // Para mostrar mensaje en caso de acierto o error
                    MessageBox.Show("Data eliminada!");
                }
            }
            catch (Exception x)
            {

                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(x.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            // Limpiar los textbox
            txt_usuario.Clear();
            txt_contrasena.Clear();
            txt_email.Clear();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el datagridview contenga datos
            if (e.RowIndex >= 0)
            {
                // Definir la filas del datagridview
                DataGridViewRow row = this.dgv_usuarios.Rows[e.RowIndex];

                // Asociar los textboxs a las columnas del datagridview
                txt_ID_usuario.Text = row.Cells[0].Value.ToString();
                txt_usuario.Text = row.Cells[1].Value.ToString();
                txt_contrasena.Text = row.Cells[2].Value.ToString();
                txt_email.Text = row.Cells[3].Value.ToString();
                cmb_estatus.Text = row.Cells[4].Value.ToString();

            }
        }

        private void Mantenimiento_Usuarios_Load(object sender, EventArgs e)
        {
            // Crear conexion para cargar los datos de la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from usuario";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para cargar los datos de la tabla cargo
                conexion.Open();

                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "usuario");

                // Generar columnas y cargar datos en el datagridview
                dgv_usuarios.AutoGenerateColumns = true;
                dgv_usuarios.DataSource = ds;
                dgv_usuarios.DataMember = "usuario";
                dgv_usuarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgv_usuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
               

                // Cerrar conexion
                conexion.Close();
            }
            catch (Exception ex)
            {
                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                // Cerrar conexion
                conexion.Close();
            }
        }
    }
}
