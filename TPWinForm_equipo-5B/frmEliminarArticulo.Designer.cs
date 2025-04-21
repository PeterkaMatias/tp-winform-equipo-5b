namespace TPWinForm_equipo_5B
{
    partial class frmEliminarArticulo
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
            this.btnId = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.numeroIDbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeroIDbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnId
            // 
            this.btnId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnId.AutoSize = true;
            this.btnId.Location = new System.Drawing.Point(223, 171);
            this.btnId.Name = "btnId";
            this.btnId.Size = new System.Drawing.Size(27, 13);
            this.btnId.TabIndex = 0;
            this.btnId.Text = "ID =";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(268, 208);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 35);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Borrar Permanente";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // numeroIDbox
            // 
            this.numeroIDbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroIDbox.Location = new System.Drawing.Point(268, 169);
            this.numeroIDbox.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numeroIDbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroIDbox.Name = "numeroIDbox";
            this.numeroIDbox.Size = new System.Drawing.Size(120, 20);
            this.numeroIDbox.TabIndex = 3;
            this.numeroIDbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.numeroIDbox);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnId);
            this.Name = "frmEliminarArticulo";
            this.Text = "frmEliminarArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.numeroIDbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnId;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NumericUpDown numeroIDbox;
    }
}