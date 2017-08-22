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
    public partial class Buscar_Documento : Form
    {
        public Buscar_Documento()
        {
            InitializeComponent();
        }



        string filtro;

        void carga_datos(string filtro)

        {

            // Crear conexion para cargar los datos de la tabla empleado
            string con = ConfigurationManager.ConnectionStrings["conex"].ToString();
            SQLiteConnection conexion = new SQLiteConnection(con);
            DataSet ds = new DataSet();
            string sql = "select id, autor, departamento, titulo, categoria, tag from documento" + filtro;

            try
            {
                // Abrir conexion para insertar los datos en el datagridview
                conexion.Open();

                // Definir y cargar datos vía el adapter
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conexion);
                adapter.Fill(ds, "documento");

                // Generar columnas y cargar datos en el datagridview
                dgv_Documento.AutoGenerateColumns = true;
                dgv_Documento.DataSource = ds;
                dgv_Documento.DataMember = "documento";

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
                
            // Función para cargar filtro (tipo LIKE) seleccionado vía el radio buttom
            void carga_filtro2()
            {
                string texto = txt_filtro.Text.ToString();
                string num_id = " where " + filtro + "'%" + texto + "%'" + ";";
                carga_datos(num_id);
            }

        
            private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el datagridview contenga datos
            if (e.RowIndex >= 0)
            {
                // Definir la filas del datagridview
                DataGridViewRow row = this.dgv_Documento.Rows[e.RowIndex];

                // Asociar los textboxs a las columnas del datagridview
                MP.pasarid = row.Cells[0].Value.ToString();
                MP.pasarautor = row.Cells[1].Value.ToString();
                MP.pasardepartamento = row.Cells[2].Value.ToString();
                MP.pasartitulo = row.Cells[3].Value.ToString();
                MP.pasarcategoria = row.Cells[4].Value.ToString();
                MP.pasartag = row.Cells[5].Value.ToString();

                
                Mostrar_Documento MD = new Mostrar_Documento();
                MD.Show();


            }
        }

        
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            if (rad_Autor.Checked)
            {
                filtro = "autor like";
                carga_filtro2();
                txt_filtro.Clear();

            }

            else if (rad_Departamento.Checked)
            {
                filtro = "departamento like ";
                carga_filtro2();
                txt_filtro.Clear();
            }

            else if (rad_Categoria.Checked)
            {
                filtro = "categoria like ";
                carga_filtro2();
                txt_filtro.Clear();
            }

            else if (rad_tag.Checked)
            {
                filtro = "tag like ";
                carga_filtro2();
                txt_filtro.Clear();
            }

            else

                carga_datos("");
        }

        private void Buscar_Documento_Load(object sender, EventArgs e)
        {

        }
    }
}
