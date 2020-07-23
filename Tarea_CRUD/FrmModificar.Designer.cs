namespace Tarea_CRUD
{
    partial class FrmModificar
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtcreditos = new System.Windows.Forms.TextBox();
            this.txtmteria = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btbCambios = new System.Windows.Forms.Button();
            this.btbcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Carrera ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Creditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código";
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(167, 322);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(282, 22);
            this.txtnivel.TabIndex = 14;
            // 
            // txtcarrera
            // 
            this.txtcarrera.Location = new System.Drawing.Point(167, 240);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.Size = new System.Drawing.Size(282, 22);
            this.txtcarrera.TabIndex = 13;
            // 
            // txtcreditos
            // 
            this.txtcreditos.Location = new System.Drawing.Point(167, 167);
            this.txtcreditos.Name = "txtcreditos";
            this.txtcreditos.Size = new System.Drawing.Size(282, 22);
            this.txtcreditos.TabIndex = 12;
            // 
            // txtmteria
            // 
            this.txtmteria.Location = new System.Drawing.Point(167, 100);
            this.txtmteria.Name = "txtmteria";
            this.txtmteria.Size = new System.Drawing.Size(282, 22);
            this.txtmteria.TabIndex = 11;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(167, 42);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(282, 22);
            this.txtcodigo.TabIndex = 10;
            // 
            // btbCambios
            // 
            this.btbCambios.Location = new System.Drawing.Point(543, 84);
            this.btbCambios.Name = "btbCambios";
            this.btbCambios.Size = new System.Drawing.Size(118, 59);
            this.btbCambios.TabIndex = 20;
            this.btbCambios.Text = "Aplicar Cambios ";
            this.btbCambios.UseVisualStyleBackColor = true;
            this.btbCambios.Click += new System.EventHandler(this.btbCambios_Click);
            // 
            // btbcerrar
            // 
            this.btbcerrar.Location = new System.Drawing.Point(543, 203);
            this.btbcerrar.Name = "btbcerrar";
            this.btbcerrar.Size = new System.Drawing.Size(118, 59);
            this.btbcerrar.TabIndex = 21;
            this.btbcerrar.Text = "cerrar";
            this.btbcerrar.UseVisualStyleBackColor = true;
            this.btbcerrar.Click += new System.EventHandler(this.btbcerrar_Click);
            // 
            // FrmModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbcerrar);
            this.Controls.Add(this.btbCambios);
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
            this.Name = "FrmModificar";
            this.Text = "FrmModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.TextBox txtcarrera;
        private System.Windows.Forms.TextBox txtcreditos;
        private System.Windows.Forms.TextBox txtmteria;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btbCambios;
        private System.Windows.Forms.Button btbcerrar;
    }
}