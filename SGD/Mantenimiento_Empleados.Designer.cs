namespace SGD
{
    partial class Mantenimiento_Empleados
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
            this.cmb_sexo = new System.Windows.Forms.ComboBox();
            this.lbl_estatus = new System.Windows.Forms.Label();
            this.lbl_cedula = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_departamento = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.dgv_Buscar_Usuario = new System.Windows.Forms.DataGridView();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buscar_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminar_usuario
            // 
            this.btn_eliminar_usuario.Location = new System.Drawing.Point(893, 249);
            this.btn_eliminar_usuario.Name = "btn_eliminar_usuario";
            this.btn_eliminar_usuario.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_usuario.TabIndex = 61;
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
            this.cmb_estatus.Location = new System.Drawing.Point(849, 216);
            this.cmb_estatus.Name = "cmb_estatus";
            this.cmb_estatus.Size = new System.Drawing.Size(61, 21);
            this.cmb_estatus.TabIndex = 59;
            // 
            // cmb_sexo
            // 
            this.cmb_sexo.FormattingEnabled = true;
            this.cmb_sexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmb_sexo.Location = new System.Drawing.Point(849, 188);
            this.cmb_sexo.Name = "cmb_sexo";
            this.cmb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cmb_sexo.TabIndex = 58;
            // 
            // lbl_estatus
            // 
            this.lbl_estatus.AutoSize = true;
            this.lbl_estatus.Location = new System.Drawing.Point(732, 219);
            this.lbl_estatus.Name = "lbl_estatus";
            this.lbl_estatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_estatus.TabIndex = 57;
            this.lbl_estatus.Text = "Activo";
            // 
            // lbl_cedula
            // 
            this.lbl_cedula.AutoSize = true;
            this.lbl_cedula.Location = new System.Drawing.Point(732, 163);
            this.lbl_cedula.Name = "lbl_cedula";
            this.lbl_cedula.Size = new System.Drawing.Size(97, 13);
            this.lbl_cedula.TabIndex = 56;
            this.lbl_cedula.Text = "Correo Electrónico:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(849, 160);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(230, 20);
            this.txt_email.TabIndex = 55;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(974, 249);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(90, 23);
            this.btn_borrar.TabIndex = 52;
            this.btn_borrar.Text = "Limpiar Campos";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(812, 249);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 51;
            this.btn_guardar.Text = "Actualizar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(732, 249);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 50;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(849, 108);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(230, 20);
            this.txt_apellido.TabIndex = 42;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(849, 80);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(230, 20);
            this.txt_nombre.TabIndex = 41;
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(732, 191);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 38;
            this.lbl_sexo.Text = "Sexo";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(732, 111);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 37;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(732, 83);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 36;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Datos Generales";
            // 
            // lbl_departamento
            // 
            this.lbl_departamento.AutoSize = true;
            this.lbl_departamento.Location = new System.Drawing.Point(732, 137);
            this.lbl_departamento.Name = "lbl_departamento";
            this.lbl_departamento.Size = new System.Drawing.Size(77, 13);
            this.lbl_departamento.TabIndex = 62;
            this.lbl_departamento.Text = "Departamento:";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmb_departamento.Location = new System.Drawing.Point(849, 133);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(230, 21);
            this.cmb_departamento.TabIndex = 66;
            // 
            // dgv_Buscar_Usuario
            // 
            this.dgv_Buscar_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Buscar_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Buscar_Usuario.Location = new System.Drawing.Point(13, 13);
            this.dgv_Buscar_Usuario.Name = "dgv_Buscar_Usuario";
            this.dgv_Buscar_Usuario.Size = new System.Drawing.Size(710, 366);
            this.dgv_Buscar_Usuario.TabIndex = 67;
            this.dgv_Buscar_Usuario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(734, 53);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(16, 13);
            this.lbl_Id.TabIndex = 68;
            this.lbl_Id.Text = "Id";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(849, 54);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(46, 20);
            this.txt_ID.TabIndex = 69;
            // 
            // Mantenimiento_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 391);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.dgv_Buscar_Usuario);
            this.Controls.Add(this.cmb_departamento);
            this.Controls.Add(this.lbl_departamento);
            this.Controls.Add(this.btn_eliminar_usuario);
            this.Controls.Add(this.cmb_estatus);
            this.Controls.Add(this.cmb_sexo);
            this.Controls.Add(this.lbl_estatus);
            this.Controls.Add(this.lbl_cedula);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_sexo);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label2);
            this.Name = "Mantenimiento_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento_Empleados";
            this.Load += new System.EventHandler(this.Mantenimiento_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buscar_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar_usuario;
        private System.Windows.Forms.ComboBox cmb_estatus;
        private System.Windows.Forms.ComboBox cmb_sexo;
        private System.Windows.Forms.Label lbl_estatus;
        private System.Windows.Forms.Label lbl_cedula;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_departamento;
        private System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.DataGridView dgv_Buscar_Usuario;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_ID;
    }
}