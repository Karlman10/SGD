namespace SGD
{
    partial class Mostrar_Adjuntos
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
            this.btn_insertar_adjunto = new System.Windows.Forms.Button();
            this.txt_ID_documento = new System.Windows.Forms.TextBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_mostrar_adjunto = new System.Windows.Forms.DataGridView();
            this.txt_id_adjunto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_adjunto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_insertar_adjunto
            // 
            this.btn_insertar_adjunto.Location = new System.Drawing.Point(15, 87);
            this.btn_insertar_adjunto.Name = "btn_insertar_adjunto";
            this.btn_insertar_adjunto.Size = new System.Drawing.Size(99, 23);
            this.btn_insertar_adjunto.TabIndex = 0;
            this.btn_insertar_adjunto.Text = "Guardar";
            this.btn_insertar_adjunto.UseVisualStyleBackColor = true;
            this.btn_insertar_adjunto.Click += new System.EventHandler(this.btn_insertar_adjunto_Click);
            // 
            // txt_ID_documento
            // 
            this.txt_ID_documento.Location = new System.Drawing.Point(127, 10);
            this.txt_ID_documento.Name = "txt_ID_documento";
            this.txt_ID_documento.ReadOnly = true;
            this.txt_ID_documento.Size = new System.Drawing.Size(46, 20);
            this.txt_ID_documento.TabIndex = 75;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(12, 9);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(74, 13);
            this.lbl_Id.TabIndex = 74;
            this.lbl_Id.Text = "Id Documento";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(127, 56);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(230, 20);
            this.txt_descripcion.TabIndex = 72;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(10, 59);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(66, 13);
            this.lbl_descripcion.TabIndex = 70;
            this.lbl_descripcion.Text = "Descripcion:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 76;
            this.button1.Text = "Seleccionar adjunto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_mostrar_adjunto
            // 
            this.dgv_mostrar_adjunto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_mostrar_adjunto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_mostrar_adjunto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_mostrar_adjunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrar_adjunto.Location = new System.Drawing.Point(13, 116);
            this.dgv_mostrar_adjunto.Name = "dgv_mostrar_adjunto";
            this.dgv_mostrar_adjunto.Size = new System.Drawing.Size(814, 375);
            this.dgv_mostrar_adjunto.TabIndex = 77;
            this.dgv_mostrar_adjunto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrar_adjunto_CellContentDoubleClick);
            // 
            // txt_id_adjunto
            // 
            this.txt_id_adjunto.Location = new System.Drawing.Point(127, 33);
            this.txt_id_adjunto.Name = "txt_id_adjunto";
            this.txt_id_adjunto.ReadOnly = true;
            this.txt_id_adjunto.Size = new System.Drawing.Size(46, 20);
            this.txt_id_adjunto.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Id Adjunto";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(249, 87);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(99, 23);
            this.btn_eliminar.TabIndex = 80;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 81;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mostrar_Adjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_id_adjunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_mostrar_adjunto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ID_documento);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.btn_insertar_adjunto);
            this.Name = "Mostrar_Adjuntos";
            this.Text = "Mostrar_Adjuntos";
            this.Load += new System.EventHandler(this.Mostrar_Adjuntos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrar_adjunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insertar_adjunto;
        private System.Windows.Forms.TextBox txt_ID_documento;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_mostrar_adjunto;
        private System.Windows.Forms.TextBox txt_id_adjunto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button button2;
    }
}