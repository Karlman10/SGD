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
    public partial class Mantenimiento_Empleados : Form
    {
        public Mantenimiento_Empleados()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Empleados_Load(object sender, EventArgs e)
        {


            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds4 = new DataSet();
            string sql4 = "select id, nombre from departamento order by nombre asc";

            try
            {
                conexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql4, conexion);
                adapter.Fill(ds4, "departamento");

                cmb_departamento.DisplayMember = "nombre";
                cmb_departamento.ValueMember = "id";
                cmb_departamento.DataSource = ds4.Tables["departamento"];
            }

            catch (Exception ex)
            {
                // Para mostrar mensaje en caso de acierto o error
                MessageBox.Show(ex.Message.ToString());
            }

            {
                // Cerrar conexion
                conexion.Close();
            }


            // Crear conexion para cargar los datos de la tabla cargo
            string con1 = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion1 = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql1 = "select * from empleado";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para cargar los datos de la tabla cargo
                conexion.Open();

                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql1, conexion1);
                adapter.Fill(ds, "empleado");

                // Generar columnas y cargar datos en el datagridview
                dgv_Buscar_Usuario.AutoGenerateColumns = true;
                dgv_Buscar_Usuario.DataSource = ds;
                dgv_Buscar_Usuario.DataMember = "empleado";

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

        private void btn_crear_Click(object sender, EventArgs e)
        {
            // Crear conexion para insertar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [empleado] ([nombre] ,[apellido] ,[departamento] ,[sexo] ,[email] ,[activo]) VALUES ('" + txt_nombre.Text + "', '" + txt_apellido.Text + "', '" + cmb_departamento.Text + "', '" + cmb_sexo.Text + "', '" + txt_email.Text + "', '" + cmb_estatus.Text + "'  )";

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
            string sql = "UPDATE [empleado] SET [nombre] = " + "'" + txt_nombre.Text + "'" + " ,[apellido] = " + "'" + txt_apellido.Text + "'" + " ,[departamento] = " + "'" + cmb_departamento.Text + "'" + " ,[email] = " + "'" + txt_email.Text + "'" + ",[sexo] =" + "'" + cmb_sexo.Text + "'" + ",[activo] =" + "'" + cmb_estatus.Text + "'" + " WHERE id =" + txt_ID.Text + ';';


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
                string sql = "DELETE from empleado WHERE id =" + txt_ID.Text + ';';
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
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_email.Clear();
            
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el datagridview contenga datos
            if (e.RowIndex >= 0)
            {
                // Definir la filas del datagridview
                DataGridViewRow row = this.dgv_Buscar_Usuario.Rows[e.RowIndex];

                // Asociar los textboxs a las columnas del datagridview
                txt_ID.Text = row.Cells[0].Value.ToString();
                txt_nombre.Text = row.Cells[1].Value.ToString();
                txt_apellido.Text = row.Cells[2].Value.ToString();
                cmb_departamento.Text = row.Cells[3].Value.ToString();
                cmb_sexo.Text = row.Cells[4].Value.ToString();
                txt_email.Text = row.Cells[5].Value.ToString();
                cmb_estatus.Text = row.Cells[6].Value.ToString();

            }



        }
    }
}
