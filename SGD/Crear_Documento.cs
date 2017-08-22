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
    public partial class Crear_Documento : Form
    {
        public Crear_Documento()
        {
            InitializeComponent();
        }

        private void Crear_Documento_Load(object sender, EventArgs e)
        {

            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select id, nombre from categoria order by nombre asc";

            try
            {
                conexion.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Crear conexion para insertar los datos a la tabla cargo
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            string sql = " INSERT INTO [documento] ([autor], [departamento], [titulo], [texto], [categoria], [tag] ) VALUES ( '" + cmb_autor.Text + "' , '" + cmb_departamento.Text + "' , '" + txt_titulo.Text + "' , '" + rec_texto.RtfText + "', '" + cmb_categoria.Text + "', '" + cmb_tags.Text + "') ";

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
    }
}
