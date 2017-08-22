namespace SGD
{
    partial class Mantenimiento_Palabras_Claves
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
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.txt_nombre_pclave = new System.Windows.Forms.TextBox();
            this.txt_ID_pclave = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_palabras_claves = new System.Windows.Forms.Label();
            this.dgv_departamento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(462, 91);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(55, 23);
            this.btn_borrar.TabIndex = 45;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(381, 91);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 44;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(314, 91);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(61, 23);
            this.btn_crear.TabIndex = 43;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // txt_nombre_pclave
            // 
            this.txt_nombre_pclave.Location = new System.Drawing.Point(312, 65);
            this.txt_nombre_pclave.Name = "txt_nombre_pclave";
            this.txt_nombre_pclave.Size = new System.Drawing.Size(208, 20);
            this.txt_nombre_pclave.TabIndex = 42;
            // 
            // txt_ID_pclave
            // 
            this.txt_ID_pclave.Location = new System.Drawing.Point(312, 26);
            this.txt_ID_pclave.Name = "txt_ID_pclave";
            this.txt_ID_pclave.ReadOnly = true;
            this.txt_ID_pclave.Size = new System.Drawing.Size(46, 20);
            this.txt_ID_pclave.TabIndex = 41;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(309, 49);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(73, 13);
            this.lbl_nombre.TabIndex = 40;
            this.lbl_nombre.Text = "Palabra Clave";
            // 
            // lbl_palabras_claves
            // 
            this.lbl_palabras_claves.AutoSize = true;
            this.lbl_palabras_claves.Location = new System.Drawing.Point(309, 9);
            this.lbl_palabras_claves.Name = "lbl_palabras_claves";
            this.lbl_palabras_claves.Size = new System.Drawing.Size(97, 13);
            this.lbl_palabras_claves.TabIndex = 39;
            this.lbl_palabras_claves.Text = "ID Palabras Claves";
            // 
            // dgv_departamento
            // 
            this.dgv_departamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_departamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_departamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_departamento.Location = new System.Drawing.Point(12, 9);
            this.dgv_departamento.Name = "dgv_departamento";
            this.dgv_departamento.Size = new System.Drawing.Size(291, 393);
            this.dgv_departamento.TabIndex = 38;
            this.dgv_departamento.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_departamento_CellContentDoubleClick);
            // 
            // Mantenimiento_Palabras_Claves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 414);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.txt_nombre_pclave);
            this.Controls.Add(this.txt_ID_pclave);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_palabras_claves);
            this.Controls.Add(this.dgv_departamento);
            this.Name = "Mantenimiento_Palabras_Claves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento_Palabras_Claves";
            this.Load += new System.EventHandler(this.Mantenimiento_Palabras_Claves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.TextBox txt_nombre_pclave;
        private System.Windows.Forms.TextBox txt_ID_pclave;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_palabras_claves;
        private System.Windows.Forms.DataGridView dgv_departamento;
    }
}