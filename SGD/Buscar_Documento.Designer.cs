namespace SGD
{
    partial class Buscar_Documento
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
            this.dgv_Documento = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            this.rad_tag = new System.Windows.Forms.RadioButton();
            this.rad_Categoria = new System.Windows.Forms.RadioButton();
            this.rad_Departamento = new System.Windows.Forms.RadioButton();
            this.rad_Autor = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Documento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Documento
            // 
            this.dgv_Documento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Documento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Documento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Documento.Location = new System.Drawing.Point(13, 52);
            this.dgv_Documento.Name = "dgv_Documento";
            this.dgv_Documento.Size = new System.Drawing.Size(641, 370);
            this.dgv_Documento.TabIndex = 0;
            this.dgv_Documento.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(591, 5);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(48, 31);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(362, 11);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(203, 20);
            this.txt_filtro.TabIndex = 11;
            // 
            // rad_tag
            // 
            this.rad_tag.AutoSize = true;
            this.rad_tag.Location = new System.Drawing.Point(285, 12);
            this.rad_tag.Name = "rad_tag";
            this.rad_tag.Size = new System.Drawing.Size(47, 17);
            this.rad_tag.TabIndex = 10;
            this.rad_tag.TabStop = true;
            this.rad_tag.Text = "TAG";
            this.rad_tag.UseVisualStyleBackColor = true;
            // 
            // rad_Categoria
            // 
            this.rad_Categoria.AutoSize = true;
            this.rad_Categoria.Location = new System.Drawing.Point(194, 12);
            this.rad_Categoria.Name = "rad_Categoria";
            this.rad_Categoria.Size = new System.Drawing.Size(72, 17);
            this.rad_Categoria.TabIndex = 9;
            this.rad_Categoria.TabStop = true;
            this.rad_Categoria.Text = "Categoría";
            this.rad_Categoria.UseVisualStyleBackColor = true;
            // 
            // rad_Departamento
            // 
            this.rad_Departamento.AutoSize = true;
            this.rad_Departamento.Location = new System.Drawing.Point(81, 12);
            this.rad_Departamento.Name = "rad_Departamento";
            this.rad_Departamento.Size = new System.Drawing.Size(92, 17);
            this.rad_Departamento.TabIndex = 8;
            this.rad_Departamento.TabStop = true;
            this.rad_Departamento.Text = "Departamento";
            this.rad_Departamento.UseVisualStyleBackColor = true;
            // 
            // rad_Autor
            // 
            this.rad_Autor.AutoSize = true;
            this.rad_Autor.Location = new System.Drawing.Point(12, 12);
            this.rad_Autor.Name = "rad_Autor";
            this.rad_Autor.Size = new System.Drawing.Size(50, 17);
            this.rad_Autor.TabIndex = 7;
            this.rad_Autor.TabStop = true;
            this.rad_Autor.Text = "Autor";
            this.rad_Autor.UseVisualStyleBackColor = true;
            // 
            // Buscar_Documento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 434);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.rad_tag);
            this.Controls.Add(this.rad_Categoria);
            this.Controls.Add(this.rad_Departamento);
            this.Controls.Add(this.rad_Autor);
            this.Controls.Add(this.dgv_Documento);
            this.Name = "Buscar_Documento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar_Documento";
            this.Load += new System.EventHandler(this.Buscar_Documento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Documento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Documento;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_filtro;
        private System.Windows.Forms.RadioButton rad_tag;
        private System.Windows.Forms.RadioButton rad_Categoria;
        private System.Windows.Forms.RadioButton rad_Departamento;
        private System.Windows.Forms.RadioButton rad_Autor;
    }
}