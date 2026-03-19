namespace NavegadorWeb
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonIr = new System.Windows.Forms.Button();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.comboBoxDireccion = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // buttonIr
            // 
            this.buttonIr.Location = new System.Drawing.Point(1066, 45);
            this.buttonIr.Name = "buttonIr";
            this.buttonIr.Size = new System.Drawing.Size(96, 35);
            this.buttonIr.TabIndex = 1;
            this.buttonIr.Text = "Navegar";
            this.buttonIr.UseVisualStyleBackColor = true;
            this.buttonIr.Click += new System.EventHandler(this.buttonIr_Click);
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(34, 103);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(1128, 517);
            this.webView2.TabIndex = 2;
            this.webView2.ZoomFactor = 1D;
            // 
            // comboBoxDireccion
            // 
            this.comboBoxDireccion.FormattingEnabled = true;
            this.comboBoxDireccion.Location = new System.Drawing.Point(34, 45);
            this.comboBoxDireccion.Name = "comboBoxDireccion";
            this.comboBoxDireccion.Size = new System.Drawing.Size(1016, 24);
            this.comboBoxDireccion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 684);
            this.Controls.Add(this.comboBoxDireccion);
            this.Controls.Add(this.webView2);
            this.Controls.Add(this.buttonIr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.Button buttonIr;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.ComboBox comboBoxDireccion;
    }
}

