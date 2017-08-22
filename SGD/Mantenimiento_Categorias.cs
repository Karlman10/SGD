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
    public partial class Mantenimiento_Categorias : Form
    {
        public Mantenimiento_Categorias()
        {
            InitializeComponent();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            // Crear conexion para insertar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [categoria] ([nombre]) VALUES ('" + txt_nombre_categoria.Text + "')";

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

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Crear conexion para actualizar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            // Definir el comando sql para actualizar el dato seleccionado
            string sql = "UPDATE [categoria] SET [nombre] = " + "'" + txt_nombre_categoria.Text + "'" + " WHERE id =" + txt_ID_categoria.Text +';';


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

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            // Verificar que el textbox no sea null
            if (txt_ID_categoria.Text != null)
            {

                // Crear conexion para eliminar los datos de la tabla cargo
                string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
                SQLiteConnection conexion = new SQLiteConnection(con);

                // Definir el comando sql para eliminar el dato seleccionado
                string sql = "DELETE from categoria WHERE id =" + txt_ID_categoria.Text + ';';



                // (Try-Catch) Manejador de errores
                try
                {
                    // Abrir conexion para insertar los datos de la tabla cargo
                    conexion.Open();

                    // Definir comando para la conexion
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
        }

        private void Mantenimiento_Categorias_Load(object sender, EventArgs e)
        {
            // Crear conexion para cargar los datos de la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from categoria";

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para cargar los datos de la tabla cargo
                conexion.Open();

                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "categoria");

                // Generar columnas y cargar datos en el datagridview
                dgv_categoria.AutoGenerateColumns = true;
                dgv_categoria.DataSource = ds;
                dgv_categoria.DataMember = "categoria";

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

        private void dgv_departamento_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el datagridview contenga datos
            if (e.RowIndex >= 0)
            {
                // Definir la filas del datagridview
                DataGridViewRow row = this.dgv_categoria.Rows[e.RowIndex];

                // Asociar los textboxs a las columnas del datagridview
                txt_ID_categoria.Text = row.Cells[0].Value.ToString();
                txt_nombre_categoria.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
