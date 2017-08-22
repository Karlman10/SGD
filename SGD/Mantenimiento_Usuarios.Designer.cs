namespace SGD
{
    partial class Mantenimiento_Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_eliminar_usuario = new System.Windows.Forms.Button();
            this.cmb_estatus = new System.Windows.Forms.ComboBox();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.txt_ID_usuario = new System.Windows.Forms.TextBox();
            this.lbl_departamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(612, 240);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_usuario.TabIndex = 80;
            this.btn_eliminar_usuario.Text = "Eliminar";
            this.btn_eliminar_usuario.UseVisualStyleBackColor = true;
            this.btn_eliminar_usuario.Click += new System.EventHandler(this.btn_eliminar_usuario_Click);
            // 
            // cmb_estatus
            // 
            this.cmb_estatus.FormattingEnabled = true;
            this.cmb_estatus.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmb_estatus.Location = new System.Drawing.Point(569, 195);
            this.cmb_estatus.Name = "cmb_estatus";
            this.cmb_estatus.Size = new System.Drawing.Size(61, 21);
            this.cmb_estatus.TabIndex = 79;
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Location = new System.Drawing.Point(452, 198);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_estatus.TabIndex = 77;
            this.lbl_estatus.Text = "Activo";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Location = new System.Drawing.Point(452, 172);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(97, 13);
            this.lbl_cedula.TabIndex = 76;
            this.lbl_cedula.Text = "Correo Electrónico:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(569, 169);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(230, 20);
            this.txt_email.TabIndex = 75;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(693, 240);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 23);
            this.btn_borrar.TabIndex = 74;
            this.btn_borrar.Text = "Limpiar Campos";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(531, 240);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 73;
            this.btn_guardar.Text = "Actualizar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(451, 240);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 72;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(569, 115);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(230, 20);
            this.txt_usuario.TabIndex = 70;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(452, 146);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(64, 13);
            this.lbl_apellido.TabIndex = 68;
            this.lbl_apellido.Text = "Contraseña:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(452, 118);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(46, 13);
            this.lbl_nombre.TabIndex = 67;
            this.lbl_nombre.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Datos Generales";
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(569, 143);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(230, 20);
            this.txt_contrasena.TabIndex = 71;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(12, 12);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.Size = new System.Drawing.Size(396, 315);
            this.dgv_usuarios.TabIndex = 81;
            this.dgv_usuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // txt_ID_usuario
            // 
            this.txt_ID_usuario.Location = new System.Drawing.Point(569, 85);
            this.txt_ID_usuario.Name = "txt_ID_usuario";
            this.txt_ID_usuario.ReadOnly = true;
            this.txt_ID_usuario.Size = new System.Drawing.Size(46, 20);
            this.txt_ID_usuario.TabIndex = 83;
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(452, 92);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(18, 13);
            this.lbl_departamento.TabIndex = 82;
            this.lbl_departamento.Text = "ID";
            // 
            // Mantenimiento_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 346);
            this.Controls.Add(this.txt_ID_usuario);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_eliminar_usuario);
            this.Controls.Add(this.cmb_estatus);
            this.Controls.Add(this.lbl_estatus);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label2);
            this.Name = "Mantenimiento_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento_Usuarios";
            this.Load += new System.EventHandler(this.Mantenimiento_Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_eliminar_usuario;
        private System.Windows.Forms.ComboBox cmb_estatus;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.TextBox txt_ID_usuario;
        private System.Windows.Forms.Label lbl_departamento;
    }
}