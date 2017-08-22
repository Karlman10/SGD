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
using System.IO;

namespace SGD
{
    public partial class Mostrar_Adjuntos : Form
    {
        public Mostrar_Adjuntos()
        {
            InitializeComponent();
        }

        string documento = "";

        private void Mostrar_Adjuntos_Load(object sender, EventArgs e)
        {
            txt_ID_documento.Text = MP.pasarid;

            // Crear conexion para cargar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select * from relacion_adjunto where id_documento =" + txt_ID_documento.Text;

            try
            {
                // Abrir conexion para insertar los datos en el datagridview
                conexion.Open();

                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "relacion_adjunto");

                // Generar columnas y cargar datos en el datagridview
                dgv_mostrar_adjunto.AutoGenerateColumns = true;
                dgv_mostrar_adjunto.DataSource = ds;
                dgv_mostrar_adjunto.DataMember = "relacion_adjunto";

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

        private void btn_insertar_adjunto_Click(object sender, EventArgs e)
        {

            // Verificar que el textbox no este vacio
            if (documento != "")
            {

                // Crear conexion para insertar los datos de la tabla empleado
                string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
                SQLiteConnection conexion = new SQLiteConnection(con);

                // Crear arreglo tipo byte para almacenar la foto
                byte[] doc = null;
                FileStream fs = new FileStream(documento, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                doc = br.ReadBytes((int)fs.Length);

                // (Try-Catch) Manejador de errores
                try
                {
                    // Abrir conexion para actualizar los datos de la tabla
                    conexion.Open();

                    // Crear conexion para actualizar la foto en la tabla empleado
                    //string sql = "UPDATE [relacion_adjunto] SET  = @archivo where id_empleado= " + MP.pasarid;
                    string sql = " INSERT INTO [relacion_adjunto] ([id_documento] ,[descripcion] ,[archivo] ) VALUES ('" + txt_ID_documento.Text + "', '" + txt_descripcion.Text + "',  @archivo )";


                    SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@archivo", doc));

                    // Verificar que el comando se ejecutó exitosamente
                    int res = cmd.ExecuteNonQuery();
                    if (res >= 1)
                    {
                        // Para mostrar mensaje en caso de acierto o error
                        MessageBox.Show("Data insertada!");
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

            else
            {
                return;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seleccionador de archivo con filtro de extensiones 
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                documento = openfile.FileName.ToString();

            }
        }

        private void dgv_mostrar_adjunto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el datagridview contenga datos
            if (e.RowIndex >= 0)
            {
                // Definir la filas del datagridview
                DataGridViewRow row = this.dgv_mostrar_adjunto.Rows[e.RowIndex];

                // Asociar los textboxs a las columnas del datagridview
                txt_id_adjunto.Text = row.Cells[0].Value.ToString();
                txt_descripcion.Text = row.Cells[2].Value.ToString();
            }

            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            // Crear conexion para insertar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            string sql = "DELETE from relacion_adjunto WHERE id_documento =" + txt_ID_documento.Text +  " and id_adjunto =" + txt_id_adjunto.Text + ';';

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para actualizar los datos de la tabla
                conexion.Open();

                // Crear conexion para eliminar la foto en la tabla
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

        private void button2_Click(object sender, EventArgs e)
        {

            // Crear conexion para insertar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            string sql = "UPDATE [relacion_adjunto] SET [descripcion] = " + "'" + txt_descripcion.Text + "'" + " , [archivo] = @archivo" + " where id_documento= " + txt_ID_documento.Text + " and id_adjunto =" + txt_id_adjunto.Text ;
            //string sql = " INSERT INTO [relacion_adjunto] ([id_documento] ,[descripcion] ,[archivo] ) VALUES ('" + txt_ID_documento.Text + "', '" + txt_descripcion.Text + "',  @archivo )";

            byte[] doc = null;
            FileStream fs = new FileStream(documento, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            doc = br.ReadBytes((int)fs.Length);
            
            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para actualizar los datos de la tabla
                conexion.Open();

                // Crear conexion para actualizar la foto en la tabla empleado
                

                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@archivo", doc));


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
    }
}

