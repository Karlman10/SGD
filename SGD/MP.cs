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
    public partial class MP : Form
    {
        public MP()
        {
            InitializeComponent();
        }

        public static string pasarid;
        public static string pasarautor;
        public static string pasartitulo;
        public static string pasarcategoria;
        public static string pasartag;
        public static string pasardepartamento;


        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Empleados ME = new Mantenimiento_Empleados();
            ME.Show();
        }

        private void crearDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_Documento CD = new Crear_Documento();
            CD.Show();
        }

        private void admDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Departamentos MD = new Mantenimiento_Departamentos();
            MD.Show();
        }

        private void buscarDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                    Buscar_Documento BD = new Buscar_Documento();
                    BD.Show();
            
        }

        private void buscarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Usuarios MU = new Mantenimiento_Usuarios();
            MU.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Categorias MC = new Mantenimiento_Categorias();
            MC.Show();
        }

        private void palabrasClavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Palabras_Claves MPC = new Mantenimiento_Palabras_Claves();
            MPC.Show();
        }

        private void MP_Load(object sender, EventArgs e)
        {

        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
