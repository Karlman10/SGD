namespace SGD
{
    partial class Registro_Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombre_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.lbl_confirmar_contrasena = new System.Windows.Forms.Label();
            this.lbl_correo_electronico = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_confirmar_contrasena = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Usuarios";
            // 
            // lbl_nombre_usuario
            // 
            this.lbl_nombre_usuario.AutoSize = true;
            this.lbl_nombre_usuario.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_usuario.Location = new System.Drawing.Point(53, 98);
            this.lbl_nombre_usuario.Name = "lbl_nombre_usuario";
            this.lbl_nombre_usuario.Size = new System.Drawing.Size(140, 39);
            this.lbl_nombre_usuario.TabIndex = 1;
            this.lbl_nombre_usuario.Text = "Nombre de usuario";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contrasena.Location = new System.Drawing.Point(53, 149);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(91, 39);
            this.lbl_contrasena.TabIndex = 3;
            this.lbl_contrasena.Text = "Contraseña";
            this.lbl_contrasena.Click += new System.EventHandler(this.lbl_contrasena_Click);
            // 
            // lbl_confirmar_contrasena
            // 
            this.lbl_confirmar_contrasena.AutoSize = true;
            this.lbl_confirmar_contrasena.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmar_contrasena.Location = new System.Drawing.Point(53, 212);
            this.lbl_confirmar_contrasena.Name = "lbl_confirmar_contrasena";
            this.lbl_confirmar_contrasena.Size = new System.Drawing.Size(158, 39);
            this.lbl_confirmar_contrasena.TabIndex = 4;
            this.lbl_confirmar_contrasena.Text = "Confirmar contraseña";
            // 
            // lbl_correo_electronico
            // 
            this.lbl_correo_electronico.AutoSize = true;
            this.lbl_correo_electronico.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo_electronico.Location = new System.Drawing.Point(53, 270);
            this.lbl_correo_electronico.Name = "lbl_correo_electronico";
            this.lbl_correo_electronico.Size = new System.Drawing.Size(129, 39);
            this.lbl_correo_electronico.TabIndex = 5;
            this.lbl_correo_electronico.Text = "Correo electrónico";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(60, 126);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(236, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Location = new System.Drawing.Point(60, 179);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.Size = new System.Drawing.Size(236, 20);
            this.txt_contrasena.TabIndex = 7;
            // 
            // txt_confirmar_contrasena
            // 
            this.txt_confirmar_contrasena.Location = new System.Drawing.Point(60, 241);
            this.txt_confirmar_contrasena.Name = "txt_confirmar_contrasena";
            this.txt_confirmar_contrasena.Size = new System.Drawing.Size(236, 20);
            this.txt_confirmar_contrasena.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(60, 299);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(236, 20);
            this.txt_email.TabIndex = 9;
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_registrar.Location = new System.Drawing.Point(78, 343);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(82, 35);
            this.btn_registrar.TabIndex = 10;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_eliminar.Location = new System.Drawing.Point(178, 343);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(94, 35);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Limpiar Campos";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Registro_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 430);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_confirmar_contrasena);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_correo_electronico);
            this.Controls.Add(this.lbl_confirmar_contrasena);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.lbl_nombre_usuario);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Usuarios";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombre_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Label lbl_confirmar_contrasena;
        private System.Windows.Forms.Label lbl_correo_electronico;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_confirmar_contrasena;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}