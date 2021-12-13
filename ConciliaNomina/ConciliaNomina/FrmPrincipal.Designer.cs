namespace ConciliaNomina
{
    partial class FrmPrincipal
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
            this.TbDirRpts = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbDirSUA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDirIDSE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtGenerarRpts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbDirRpts
            // 
            this.TbDirRpts.Location = new System.Drawing.Point(12, 183);
            this.TbDirRpts.Name = "TbDirRpts";
            this.TbDirRpts.Size = new System.Drawing.Size(416, 20);
            this.TbDirRpts.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Directorio para guardar reportes";
            // 
            // TbDirSUA
            // 
            this.TbDirSUA.Location = new System.Drawing.Point(12, 114);
            this.TbDirSUA.Name = "TbDirSUA";
            this.TbDirSUA.Size = new System.Drawing.Size(416, 20);
            this.TbDirSUA.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Directorio carpeta de archivos SUA";
            // 
            // TbDirIDSE
            // 
            this.TbDirIDSE.Location = new System.Drawing.Point(12, 45);
            this.TbDirIDSE.Name = "TbDirIDSE";
            this.TbDirIDSE.Size = new System.Drawing.Size(416, 20);
            this.TbDirIDSE.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Directorio carpeta de archivos IDSE";
            // 
            // BtGenerarRpts
            // 
            this.BtGenerarRpts.Location = new System.Drawing.Point(170, 231);
            this.BtGenerarRpts.Name = "BtGenerarRpts";
            this.BtGenerarRpts.Size = new System.Drawing.Size(100, 23);
            this.BtGenerarRpts.TabIndex = 9;
            this.BtGenerarRpts.Text = "Generar reportes";
            this.BtGenerarRpts.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 270);
            this.Controls.Add(this.TbDirRpts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbDirSUA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbDirIDSE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtGenerarRpts);
            this.Name = "Form1";
            this.Text = "Conciliador nómina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbDirRpts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbDirSUA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDirIDSE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtGenerarRpts;
    }
}

