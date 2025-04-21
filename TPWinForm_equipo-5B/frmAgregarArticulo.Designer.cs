namespace TPWinForm_equipo_5B
{
    partial class frmAgregarArticulo
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.numeroCategoriaBox = new System.Windows.Forms.NumericUpDown();
            this.numeroMarcaBox = new System.Windows.Forms.NumericUpDown();
            this.numeroPrecioBox = new System.Windows.Forms.NumericUpDown();
            this.listboxLinks = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCategoriaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMarcaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPrecioBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo =";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca(1-10) =";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria(1-8) =";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio =";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion =";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre =";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Imagenes =";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxCodigo.Location = new System.Drawing.Point(280, 48);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(124, 20);
            this.tbxCodigo.TabIndex = 7;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNombre.Location = new System.Drawing.Point(280, 74);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(124, 20);
            this.tbxNombre.TabIndex = 8;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDescripcion.Location = new System.Drawing.Point(280, 106);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(124, 20);
            this.tbxDescripcion.TabIndex = 9;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(280, 351);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(124, 25);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // numeroCategoriaBox
            // 
            this.numeroCategoriaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroCategoriaBox.Location = new System.Drawing.Point(280, 161);
            this.numeroCategoriaBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeroCategoriaBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroCategoriaBox.Name = "numeroCategoriaBox";
            this.numeroCategoriaBox.Size = new System.Drawing.Size(124, 20);
            this.numeroCategoriaBox.TabIndex = 16;
            this.numeroCategoriaBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeroMarcaBox
            // 
            this.numeroMarcaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroMarcaBox.Location = new System.Drawing.Point(280, 132);
            this.numeroMarcaBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeroMarcaBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroMarcaBox.Name = "numeroMarcaBox";
            this.numeroMarcaBox.Size = new System.Drawing.Size(124, 20);
            this.numeroMarcaBox.TabIndex = 17;
            this.numeroMarcaBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeroPrecioBox
            // 
            this.numeroPrecioBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroPrecioBox.Location = new System.Drawing.Point(280, 187);
            this.numeroPrecioBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numeroPrecioBox.Name = "numeroPrecioBox";
            this.numeroPrecioBox.Size = new System.Drawing.Size(124, 20);
            this.numeroPrecioBox.TabIndex = 18;
            // 
            // listboxLinks
            // 
            this.listboxLinks.FormattingEnabled = true;
            this.listboxLinks.Location = new System.Drawing.Point(280, 223);
            this.listboxLinks.Name = "listboxLinks";
            this.listboxLinks.Size = new System.Drawing.Size(120, 95);
            this.listboxLinks.TabIndex = 19;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 450);
            this.Controls.Add(this.listboxLinks);
            this.Controls.Add(this.numeroPrecioBox);
            this.Controls.Add(this.numeroMarcaBox);
            this.Controls.Add(this.numeroCategoriaBox);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarArticulo";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numeroCategoriaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMarcaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPrecioBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numeroCategoriaBox;
        private System.Windows.Forms.NumericUpDown numeroMarcaBox;
        private System.Windows.Forms.NumericUpDown numeroPrecioBox;
        private System.Windows.Forms.ListBox listboxLinks;
    }
}