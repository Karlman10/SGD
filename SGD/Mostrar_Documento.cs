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
    public partial class Mostrar_Documento : Form
    {
        public Mostrar_Documento()
        {
            InitializeComponent();
        }

        private void Buscar_Documento_Load(object sender, EventArgs e)
        {
            

            txt_titulo.Text = MP.pasartitulo;
            txt_categoria_actual.Text = MP.pasarcategoria;
            txt_autor_actual.Text = MP.pasarautor;
      
            txt_departamento_actual.Text = MP.pasardepartamento;
            cmb_tags.SelectedItem = MP.pasartag.ToString();
                        
            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " SELECT texto from documento where id = " + MP.pasarid + ';';

            // (Try-Catch) Manejador de errores
            try
            {
                // Abrir conexion para insertar los datos de la tabla cargo
                conexion.Open();

                // Definir comando para la conexion
                SQLiteCommand cmd = new SQLiteCommand(sql, conexion);

                // Verificar que el comando se ejecutó exitosamente
                int res = cmd.ExecuteNonQuery();
                //MessageBox.Show(res.ToString());
                if (res >= -2)

                {
                    // Para mostrar mensaje en caso de acierto o error
                    rec_texto.RtfText = cmd.ExecuteScalar().ToString();
                        
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
          

            string con5 = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion5 = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql5 = "select id, nombre from categoria order by nombre asc";

            try
            {
                conexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql5, conexion5);
                adapter.Fill(ds, "categoria");

                cmb_categoria.DisplayMember = "nombre";
                cmb_categoria.ValueMember = "id";
                cmb_categoria.DataSource = ds.Tables["categoria"];
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



            string con2 = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion2 = new SQLiteConnection(con2);
            DataSet ds2 = new DataSet();
            string sql2 = "select id, nombre from pclave order by nombre asc";

            try
            {
                conexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql2, conexion2);
                adapter.Fill(ds2, "pclave");

                cmb_tags.DisplayMember = "nombre";
                cmb_tags.ValueMember = "id";
                cmb_tags.DataSource = ds2.Tables["pclave"];
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


            string con3 = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion3 = new SQLiteConnection(con3);
            DataSet ds3 = new DataSet();
            string sql3 = "select id, (nombre || ' ' ||  apellido) as name from empleado";

            try
            {
                conexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql3, conexion3);
                adapter.Fill(ds3, "empleado");

                cmb_autor.DisplayMember = "name";
                cmb_autor.ValueMember = "id";
                cmb_autor.DataSource = ds3.Tables["empleado"];
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




            string con4 = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion4 = new SQLiteConnection(con2);
            DataSet ds4 = new DataSet();
            string sql4 = "select id, nombre from departamento order by nombre asc";

            try
            {
                conexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql4, conexion4);
                adapter.Fill(ds4, "documento");

                cmb_departamento.DisplayMember = "nombre";
                cmb_departamento.ValueMember = "id";
                cmb_departamento.DataSource = ds4.Tables["documento"];
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

            
        }

        private void fileSaveItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [documento] ([titulo], [texto], [categoria], [tag] ) VALUES ( '" + txt_titulo.Text + "' , '" + rec_texto.RtfText + "', '" + cmb_categoria.SelectedItem.ToString() + "', '" + cmb_tags.SelectedItem.ToString() + "') ";

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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            //string sql = " INSERT INTO [documento] ([titulo], [texto], [categoria], [tag] ) VALUES ( '" + txt_titulo.Text + "' , '" + rec_texto.RtfText + "', '" + cmb_categoria.SelectedItem.ToString() + "', '" + cmb_tags.SelectedItem.ToString() + "') ";

            string sql = "UPDATE [documento] SET [titulo] = " + "'" + txt_titulo.Text + "'" + ",[autor] = " + "'" + txt_autor_actual.Text + "'" + ",[departamento] = " + "'" + txt_departamento_actual.Text + "'" + ",[texto] = " + "'" + rec_texto.RtfText + "'" + " ,[categoria] = " + "'" + txt_categoria_actual.Text + "'" + " ,[tag] = " + "'" + cmb_tags.Text + "'" + " WHERE id =" + MP.pasarid + ';';
            
            
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

        private void lbl_categoria_Click(object sender, EventArgs e)
        {

        }

        private void cmb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            txt_autor_actual.Text = cmb_autor.Text;
            txt_categoria_actual.Text = cmb_categoria.Text;
            txt_departamento_actual.Text = cmb_departamento.Text;

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);

            string sql = "DELETE from documento" + " WHERE id =" + MP.pasarid + ';';


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

        private void btn_documentos_asociados_Click(object sender, EventArgs e)
        {
            Mostrar_Adjuntos MAD = new Mostrar_Adjuntos();
            MAD.Show();
        }
    }
}
