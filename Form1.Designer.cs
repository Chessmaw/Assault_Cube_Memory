
namespace Assault_Cube_Memory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.Num_Injectar = new System.Windows.Forms.TextBox();
            this.Injectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("BravAda Arma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(1, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Ammon : ";
            // 
            // Num_Injectar
            // 
            this.Num_Injectar.BackColor = System.Drawing.Color.White;
            this.Num_Injectar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Num_Injectar.ForeColor = System.Drawing.Color.Black;
            this.Num_Injectar.Location = new System.Drawing.Point(69, 22);
            this.Num_Injectar.Name = "Num_Injectar";
            this.Num_Injectar.Size = new System.Drawing.Size(100, 13);
            this.Num_Injectar.TabIndex = 1;
            // 
            // Injectar
            // 
            this.Injectar.BackColor = System.Drawing.Color.White;
            this.Injectar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Injectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Injectar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Injectar.ForeColor = System.Drawing.Color.Black;
            this.Injectar.Location = new System.Drawing.Point(186, 17);
            this.Injectar.Name = "Injectar";
            this.Injectar.Size = new System.Drawing.Size(75, 23);
            this.Injectar.TabIndex = 2;
            this.Injectar.Text = "Injectar";
            this.Injectar.UseVisualStyleBackColor = false;
            this.Injectar.Click += new System.EventHandler(this.Injectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(306, 76);
            this.Controls.Add(this.Injectar);
            this.Controls.Add(this.Num_Injectar);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hack_AssaltCube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox Num_Injectar;
        private System.Windows.Forms.Button Injectar;
    }
}

