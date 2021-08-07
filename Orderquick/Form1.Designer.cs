
namespace Orderquick
{
    partial class QuickOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.listOne = new System.Windows.Forms.ListBox();
            this.Listwo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 266);
            this.button1.TabIndex = 2;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOne
            // 
            this.listOne.FormattingEnabled = true;
            this.listOne.Location = new System.Drawing.Point(12, 79);
            this.listOne.Name = "listOne";
            this.listOne.Size = new System.Drawing.Size(199, 264);
            this.listOne.TabIndex = 3;
            // 
            // Listwo
            // 
            this.Listwo.FormattingEnabled = true;
            this.Listwo.Location = new System.Drawing.Point(381, 81);
            this.Listwo.Name = "Listwo";
            this.Listwo.Size = new System.Drawing.Size(199, 264);
            this.Listwo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Disorder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order";
            // 
            // QuickOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Listwo);
            this.Controls.Add(this.listOne);
            this.Controls.Add(this.button1);
            this.Name = "QuickOrder";
            this.Text = "QuickOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listOne;
        private System.Windows.Forms.ListBox Listwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

