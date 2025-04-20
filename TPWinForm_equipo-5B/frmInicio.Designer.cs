namespace TPWinForm_equipo_5B
{
    partial class frmInicio
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
            this.btnBusquedaArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.btnListarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBusquedaArticulo
            // 
            this.btnBusquedaArticulo.Location = new System.Drawing.Point(238, 136);
            this.btnBusquedaArticulo.Name = "btnBusquedaArticulo";
            this.btnBusquedaArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnBusquedaArticulo.TabIndex = 1;
            this.btnBusquedaArticulo.Text = "Búsqueda de artículos por distintos criterios";
            this.btnBusquedaArticulo.UseVisualStyleBackColor = true;
            this.btnBusquedaArticulo.Click += new System.EventHandler(this.btnBusquedaArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(238, 187);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar artículos";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(238, 238);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar artículos";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(238, 289);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar artículos";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Location = new System.Drawing.Point(238, 340);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnDetalleArticulo.TabIndex = 5;
            this.btnDetalleArticulo.Text = "Ver detalle de un artículo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // btnListarArticulo
            // 
            this.btnListarArticulo.Location = new System.Drawing.Point(238, 85);
            this.btnListarArticulo.Name = "btnListarArticulo";
            this.btnListarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnListarArticulo.TabIndex = 6;
            this.btnListarArticulo.Text = "Listado de articulos";
            this.btnListarArticulo.UseVisualStyleBackColor = true;
            this.btnListarArticulo.Click += new System.EventHandler(this.btnListarArticulo_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.btnListarArticulo);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnBusquedaArticulo);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBusquedaArticulo;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnDetalleArticulo;
        private System.Windows.Forms.Button btnListarArticulo;
    }
}

