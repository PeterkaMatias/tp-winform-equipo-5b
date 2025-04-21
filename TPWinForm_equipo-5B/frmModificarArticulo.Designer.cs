namespace TPWinForm_equipo_5B
{
    partial class frmModificarArticulo
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
            this.lblID = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.numeroID = new System.Windows.Forms.NumericUpDown();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxImagenURL = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.numeroMarca = new System.Windows.Forms.NumericUpDown();
            this.numeroCategoria = new System.Windows.Forms.NumericUpDown();
            this.numeroPrecio = new System.Windows.Forms.NumericUpDown();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeroID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(306, 41);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID = ";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(351, 84);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // numeroID
            // 
            this.numeroID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroID.Location = new System.Drawing.Point(351, 39);
            this.numeroID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroID.Name = "numeroID";
            this.numeroID.Size = new System.Drawing.Size(120, 20);
            this.numeroID.TabIndex = 2;
            this.numeroID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(91, 160);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo =";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(91, 192);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre =";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(91, 228);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion =";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(91, 270);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca =";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(91, 307);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria =";
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(91, 342);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio =";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ImgURL =";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(599, 160);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(120, 20);
            this.tbxCodigo.TabIndex = 10;
            // 
            // tbxImagenURL
            // 
            this.tbxImagenURL.Location = new System.Drawing.Point(599, 372);
            this.tbxImagenURL.Name = "tbxImagenURL";
            this.tbxImagenURL.Size = new System.Drawing.Size(120, 20);
            this.tbxImagenURL.TabIndex = 11;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Location = new System.Drawing.Point(599, 228);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(120, 20);
            this.tbxDescripcion.TabIndex = 12;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(599, 192);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(120, 20);
            this.tbxNombre.TabIndex = 13;
            // 
            // numeroMarca
            // 
            this.numeroMarca.Location = new System.Drawing.Point(599, 270);
            this.numeroMarca.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeroMarca.Name = "numeroMarca";
            this.numeroMarca.Size = new System.Drawing.Size(120, 20);
            this.numeroMarca.TabIndex = 14;
            this.numeroMarca.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeroCategoria
            // 
            this.numeroCategoria.Location = new System.Drawing.Point(599, 307);
            this.numeroCategoria.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numeroCategoria.Name = "numeroCategoria";
            this.numeroCategoria.Size = new System.Drawing.Size(120, 20);
            this.numeroCategoria.TabIndex = 15;
            this.numeroCategoria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numeroPrecio
            // 
            this.numeroPrecio.Location = new System.Drawing.Point(599, 340);
            this.numeroPrecio.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numeroPrecio.Name = "numeroPrecio";
            this.numeroPrecio.Size = new System.Drawing.Size(120, 20);
            this.numeroPrecio.TabIndex = 16;
            this.numeroPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(599, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.numeroPrecio);
            this.Controls.Add(this.numeroCategoria);
            this.Controls.Add(this.numeroMarca);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxImagenURL);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.numeroID);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblID);
            this.Name = "frmModificarArticulo";
            this.Text = "frmModificarArticulo";
            ((System.ComponentModel.ISupportInitialize)(this.numeroID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.NumericUpDown numeroID;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxImagenURL;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.NumericUpDown numeroMarca;
        private System.Windows.Forms.NumericUpDown numeroCategoria;
        private System.Windows.Forms.NumericUpDown numeroPrecio;
        private System.Windows.Forms.Button btnModificar;
    }
}