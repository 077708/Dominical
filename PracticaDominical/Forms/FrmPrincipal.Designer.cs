
namespace PracticaDominical.Forms
{
    partial class FrmPrincipal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtaDatos = new System.Windows.Forms.DataGridView();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.btnGetByName = new System.Windows.Forms.Button();
            this.txtGetName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(1015, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(1015, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(1015, 174);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(199, 23);
            this.txt.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(922, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(292, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio";
            // 
            // dtaDatos
            // 
            this.dtaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaDatos.Location = new System.Drawing.Point(13, 43);
            this.dtaDatos.Name = "dtaDatos";
            this.dtaDatos.RowTemplate.Height = 25;
            this.dtaDatos.Size = new System.Drawing.Size(882, 564);
            this.dtaDatos.TabIndex = 11;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(1015, 134);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(199, 23);
            this.cmbMarca.TabIndex = 12;
            // 
            // btnGetByName
            // 
            this.btnGetByName.Location = new System.Drawing.Point(922, 584);
            this.btnGetByName.Name = "btnGetByName";
            this.btnGetByName.Size = new System.Drawing.Size(292, 23);
            this.btnGetByName.TabIndex = 13;
            this.btnGetByName.Text = "GETBYNAME";
            this.btnGetByName.UseVisualStyleBackColor = true;
            this.btnGetByName.Click += new System.EventHandler(this.btnGetByName_Click);
            // 
            // txtGetName
            // 
            this.txtGetName.Location = new System.Drawing.Point(922, 555);
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(292, 23);
            this.txtGetName.TabIndex = 14;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 653);
            this.Controls.Add(this.txtGetName);
            this.Controls.Add(this.btnGetByName);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.dtaDatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtaDatos;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Button btnGetByName;
        private System.Windows.Forms.TextBox txtGetName;
    }
}