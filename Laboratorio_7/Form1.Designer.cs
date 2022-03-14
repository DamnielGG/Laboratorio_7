
namespace Laboratorio_7
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonResumen = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonMayormenor = new System.Windows.Forms.Button();
            this.labelMayor = new System.Windows.Forms.Label();
            this.labelMenor = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonResumen
            // 
            this.buttonResumen.Location = new System.Drawing.Point(48, 358);
            this.buttonResumen.Name = "buttonResumen";
            this.buttonResumen.Size = new System.Drawing.Size(139, 56);
            this.buttonResumen.TabIndex = 1;
            this.buttonResumen.Text = "Mostrar datos";
            this.buttonResumen.UseVisualStyleBackColor = true;
            this.buttonResumen.Click += new System.EventHandler(this.buttonResumen_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Enabled = false;
            this.buttonOrdenar.Location = new System.Drawing.Point(246, 358);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(121, 56);
            this.buttonOrdenar.TabIndex = 2;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonMayormenor
            // 
            this.buttonMayormenor.Location = new System.Drawing.Point(416, 358);
            this.buttonMayormenor.Name = "buttonMayormenor";
            this.buttonMayormenor.Size = new System.Drawing.Size(144, 56);
            this.buttonMayormenor.TabIndex = 3;
            this.buttonMayormenor.Text = "Mostrar precio de mayor a menor";
            this.buttonMayormenor.UseVisualStyleBackColor = true;
            this.buttonMayormenor.Click += new System.EventHandler(this.buttonMayormenor_Click);
            // 
            // labelMayor
            // 
            this.labelMayor.AutoSize = true;
            this.labelMayor.Location = new System.Drawing.Point(671, 48);
            this.labelMayor.Name = "labelMayor";
            this.labelMayor.Size = new System.Drawing.Size(12, 17);
            this.labelMayor.TabIndex = 4;
            this.labelMayor.Text = ".";
            // 
            // labelMenor
            // 
            this.labelMenor.AutoSize = true;
            this.labelMenor.Location = new System.Drawing.Point(671, 203);
            this.labelMenor.Name = "labelMenor";
            this.labelMenor.Size = new System.Drawing.Size(12, 17);
            this.labelMenor.TabIndex = 5;
            this.labelMenor.Text = ".";
            this.labelMenor.Click += new System.EventHandler(this.labelMenor_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(576, 48);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(12, 17);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelMenor);
            this.Controls.Add(this.labelMayor);
            this.Controls.Add(this.buttonMayormenor);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonResumen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonResumen;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonMayormenor;
        private System.Windows.Forms.Label labelMayor;
        private System.Windows.Forms.Label labelMenor;
        private System.Windows.Forms.Label labelNombre;
    }
}

