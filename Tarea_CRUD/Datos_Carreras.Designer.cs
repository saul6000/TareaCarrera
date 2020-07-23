namespace Tarea_CRUD
{
    partial class Datos_Carreras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtmteria = new System.Windows.Forms.TextBox();
            this.txtcreditos = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.djcarrera = new System.Windows.Forms.DataGridView();
            this.linkModificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btbguardar = new System.Windows.Forms.Button();
            this.btblimpiar = new System.Windows.Forms.Button();
            this.btbCerrar = new System.Windows.Forms.Button();
            this.btbdelete = new System.Windows.Forms.Button();
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.btbbusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.djcarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(163, 45);
            this.txtcodigo.MaxLength = 7;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(282, 22);
            this.txtcodigo.TabIndex = 0;
            // 
            // txtmteria
            // 
            this.txtmteria.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmteria.Location = new System.Drawing.Point(163, 103);
            this.txtmteria.MaxLength = 100;
            this.txtmteria.Name = "txtmteria";
            this.txtmteria.Size = new System.Drawing.Size(282, 22);
            this.txtmteria.TabIndex = 1;
            this.txtmteria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarletras);
            // 
            // txtcreditos
            // 
            this.txtcreditos.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcreditos.Location = new System.Drawing.Point(163, 170);
            this.txtcreditos.MaxLength = 4;
            this.txtcreditos.Name = "txtcreditos";
            this.txtcreditos.Size = new System.Drawing.Size(282, 22);
            this.txtcreditos.TabIndex = 2;
            this.txtcreditos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarnumeros);
            // 
            // txtcarrera
            // 
            this.txtcarrera.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcarrera.Location = new System.Drawing.Point(163, 243);
            this.txtcarrera.MaxLength = 100;
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(282, 22);
            this.txtcarrera.TabIndex = 3;
            this.txtcarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarletras);
            // 
            // txtnivel
            // 
            this.txtnivel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnivel.Location = new System.Drawing.Point(163, 325);
            this.txtnivel.MaxLength = 1;
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(282, 22);
            this.txtnivel.TabIndex = 4;
            this.txtnivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validarnumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Creditos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carrera ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nivel";
            // 
            // djcarrera
            // 
            this.djcarrera.AllowUserToAddRows = false;
            this.djcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.djcarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkModificar,
            this.linkEliminar});
            this.djcarrera.Location = new System.Drawing.Point(12, 381);
            this.djcarrera.Name = "djcarrera";
            this.djcarrera.ReadOnly = true;
            this.djcarrera.RowHeadersWidth = 51;
            this.djcarrera.RowTemplate.Height = 24;
            this.djcarrera.Size = new System.Drawing.Size(887, 155);
            this.djcarrera.TabIndex = 10;
            this.djcarrera.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.djcarrera_CellContentClick);
            // 
            // linkModificar
            // 
            this.linkModificar.HeaderText = "Acción";
            this.linkModificar.MinimumWidth = 6;
            this.linkModificar.Name = "linkModificar";
            this.linkModificar.ReadOnly = true;
            this.linkModificar.Text = "Modificar";
            this.linkModificar.UseColumnTextForLinkValue = true;
            this.linkModificar.Width = 125;
            // 
            // linkEliminar
            // 
            this.linkEliminar.HeaderText = "Acción";
            this.linkEliminar.MinimumWidth = 6;
            this.linkEliminar.Name = "linkEliminar";
            this.linkEliminar.ReadOnly = true;
            this.linkEliminar.Text = "Eliminar";
            this.linkEliminar.UseColumnTextForLinkValue = true;
            this.linkEliminar.Width = 125;
            // 
            // btbguardar
            // 
            this.btbguardar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbguardar.Location = new System.Drawing.Point(503, 27);
            this.btbguardar.Name = "btbguardar";
            this.btbguardar.Size = new System.Drawing.Size(118, 59);
            this.btbguardar.TabIndex = 11;
            this.btbguardar.Text = "Guardar ";
            this.btbguardar.UseVisualStyleBackColor = true;
            this.btbguardar.Click += new System.EventHandler(this.btbguardar_Click);
            // 
            // btblimpiar
            // 
            this.btblimpiar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btblimpiar.Location = new System.Drawing.Point(503, 108);
            this.btblimpiar.Name = "btblimpiar";
            this.btblimpiar.Size = new System.Drawing.Size(118, 54);
            this.btblimpiar.TabIndex = 12;
            this.btblimpiar.Text = "Limpiar";
            this.btblimpiar.UseVisualStyleBackColor = true;
            // 
            // btbCerrar
            // 
            this.btbCerrar.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCerrar.Location = new System.Drawing.Point(503, 194);
            this.btbCerrar.Name = "btbCerrar";
            this.btbCerrar.Size = new System.Drawing.Size(118, 54);
            this.btbCerrar.TabIndex = 13;
            this.btbCerrar.Text = "Cerrar";
            this.btbCerrar.UseVisualStyleBackColor = true;
            this.btbCerrar.Click += new System.EventHandler(this.btbCerrar_Click);
            // 
            // btbdelete
            // 
            this.btbdelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbdelete.Location = new System.Drawing.Point(503, 278);
            this.btbdelete.Name = "btbdelete";
            this.btbdelete.Size = new System.Drawing.Size(128, 56);
            this.btbdelete.TabIndex = 14;
            this.btbdelete.Text = "Eliminar datos ";
            this.btbdelete.UseVisualStyleBackColor = true;
            this.btbdelete.Click += new System.EventHandler(this.btbdelete_Click);
            // 
            // txtdelete
            // 
            this.txtdelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdelete.Location = new System.Drawing.Point(637, 295);
            this.txtdelete.MaxLength = 7;
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(192, 22);
            this.txtdelete.TabIndex = 15;
            // 
            // btbbusqueda
            // 
            this.btbbusqueda.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbbusqueda.Location = new System.Drawing.Point(682, 144);
            this.btbbusqueda.Name = "btbbusqueda";
            this.btbbusqueda.Size = new System.Drawing.Size(201, 73);
            this.btbbusqueda.TabIndex = 16;
            this.btbbusqueda.Text = "Buscar";
            this.btbbusqueda.UseVisualStyleBackColor = true;
            this.btbbusqueda.Click += new System.EventHandler(this.btbbusqueda_Click);
            // 
            // Datos_Carreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 548);
            this.Controls.Add(this.btbbusqueda);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.btbdelete);
            this.Controls.Add(this.btbCerrar);
            this.Controls.Add(this.btblimpiar);
            this.Controls.Add(this.btbguardar);
            this.Controls.Add(this.djcarrera);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtcarrera);
            this.Controls.Add(this.txtcreditos);
            this.Controls.Add(this.txtmteria);
            this.Controls.Add(this.txtcodigo);
            this.Name = "Datos_Carreras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Datos_Carreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.djcarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtmteria;
        private System.Windows.Forms.TextBox txtcreditos;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView djcarrera;
        private System.Windows.Forms.Button btbguardar;
        private System.Windows.Forms.Button btblimpiar;
        private System.Windows.Forms.Button btbCerrar;
        private System.Windows.Forms.Button btbdelete;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.DataGridViewLinkColumn linkModificar;
        private System.Windows.Forms.DataGridViewLinkColumn linkEliminar;
        private System.Windows.Forms.Button btbbusqueda;
    }
}

