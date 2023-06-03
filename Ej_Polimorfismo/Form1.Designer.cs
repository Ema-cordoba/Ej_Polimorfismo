
namespace Ej_Polimorfismo
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
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.radioButtonEmplAdministrativo = new System.Windows.Forms.RadioButton();
            this.radioButtonEmplGerente = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(13, 261);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // radioButtonEmplAdministrativo
            // 
            this.radioButtonEmplAdministrativo.AutoSize = true;
            this.radioButtonEmplAdministrativo.Checked = true;
            this.radioButtonEmplAdministrativo.Location = new System.Drawing.Point(228, 266);
            this.radioButtonEmplAdministrativo.Name = "radioButtonEmplAdministrativo";
            this.radioButtonEmplAdministrativo.Size = new System.Drawing.Size(140, 17);
            this.radioButtonEmplAdministrativo.TabIndex = 2;
            this.radioButtonEmplAdministrativo.TabStop = true;
            this.radioButtonEmplAdministrativo.Text = "Empelado Administrativo";
            this.radioButtonEmplAdministrativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmplGerente
            // 
            this.radioButtonEmplGerente.AutoSize = true;
            this.radioButtonEmplGerente.Location = new System.Drawing.Point(228, 302);
            this.radioButtonEmplGerente.Name = "radioButtonEmplGerente";
            this.radioButtonEmplGerente.Size = new System.Drawing.Size(113, 17);
            this.radioButtonEmplGerente.TabIndex = 3;
            this.radioButtonEmplGerente.Text = "Empleado Gerente";
            this.radioButtonEmplGerente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonEmplGerente);
            this.Controls.Add(this.radioButtonEmplAdministrativo);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.RadioButton radioButtonEmplAdministrativo;
        private System.Windows.Forms.RadioButton radioButtonEmplGerente;
    }
}

