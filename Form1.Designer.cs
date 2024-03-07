
namespace LabRepaso1
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
            this.dataGridViewEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            this.BtnLeer = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSueldo = new System.Windows.Forms.Button();
            this.comboBoxEmpl = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSeEmpl = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmpleado
            // 
            this.dataGridViewEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleado.Location = new System.Drawing.Point(12, 76);
            this.dataGridViewEmpleado.Name = "dataGridViewEmpleado";
            this.dataGridViewEmpleado.Size = new System.Drawing.Size(352, 150);
            this.dataGridViewEmpleado.TabIndex = 1;
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(394, 76);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(351, 150);
            this.dataGridViewAsistencia.TabIndex = 2;
            // 
            // BtnLeer
            // 
            this.BtnLeer.Location = new System.Drawing.Point(481, 250);
            this.BtnLeer.Name = "BtnLeer";
            this.BtnLeer.Size = new System.Drawing.Size(113, 23);
            this.BtnLeer.TabIndex = 3;
            this.BtnLeer.Text = "Cargar Datos";
            this.BtnLeer.UseVisualStyleBackColor = true;
            this.BtnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(400, 250);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(12, 275);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(351, 150);
            this.dataGridViewReporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sueldos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sueldo Base";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnSueldo
            // 
            this.BtnSueldo.Location = new System.Drawing.Point(600, 250);
            this.BtnSueldo.Name = "BtnSueldo";
            this.BtnSueldo.Size = new System.Drawing.Size(113, 23);
            this.BtnSueldo.TabIndex = 9;
            this.BtnSueldo.Text = "Calcular Sueldo";
            this.BtnSueldo.UseVisualStyleBackColor = true;
            this.BtnSueldo.Click += new System.EventHandler(this.BtnSueldo_Click);
            // 
            // comboBoxEmpl
            // 
            this.comboBoxEmpl.FormattingEnabled = true;
            this.comboBoxEmpl.Location = new System.Drawing.Point(461, 457);
            this.comboBoxEmpl.Name = "comboBoxEmpl";
            this.comboBoxEmpl.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmpl.TabIndex = 10;
            this.comboBoxEmpl.SelectedIndexChanged += new System.EventHandler(this.comboBoxEmpl_SelectedIndexChanged);
            this.comboBoxEmpl.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEmpl_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mostrar Empleado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeEmpl
            // 
            this.dataGridViewSeEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeEmpl.Location = new System.Drawing.Point(381, 275);
            this.dataGridViewSeEmpl.Name = "dataGridViewSeEmpl";
            this.dataGridViewSeEmpl.Size = new System.Drawing.Size(484, 150);
            this.dataGridViewSeEmpl.TabIndex = 12;
            this.dataGridViewSeEmpl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeEmpl_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 509);
            this.Controls.Add(this.dataGridViewSeEmpl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxEmpl);
            this.Controls.Add(this.BtnSueldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLeer);
            this.Controls.Add(this.dataGridViewAsistencia);
            this.Controls.Add(this.dataGridViewEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmpleado;
        private System.Windows.Forms.DataGridView dataGridViewAsistencia;
        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSueldo;
        private System.Windows.Forms.ComboBox comboBoxEmpl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSeEmpl;
    }
}

