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
            this.tituloApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBusquedaArticulo
            // 
            this.btnBusquedaArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusquedaArticulo.Location = new System.Drawing.Point(238, 167);
            this.btnBusquedaArticulo.Name = "btnBusquedaArticulo";
            this.btnBusquedaArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnBusquedaArticulo.TabIndex = 1;
            this.btnBusquedaArticulo.Text = "Búsqueda de artículos por distintos criterios";
            this.btnBusquedaArticulo.UseVisualStyleBackColor = true;
            this.btnBusquedaArticulo.Click += new System.EventHandler(this.btnBusquedaArticulo_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarArticulo.Location = new System.Drawing.Point(238, 218);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar artículos";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarArticulo.Location = new System.Drawing.Point(238, 269);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnModificarArticulo.TabIndex = 3;
            this.btnModificarArticulo.Text = "Modificar artículos";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarArticulo.Location = new System.Drawing.Point(238, 320);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar artículos";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalleArticulo.Location = new System.Drawing.Point(238, 371);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnDetalleArticulo.TabIndex = 5;
            this.btnDetalleArticulo.Text = "Ver detalle de un artículo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnDetalleArticulo.Click += new System.EventHandler(this.btnDetalleArticulo_Click);
            // 
            // btnListarArticulo
            // 
            this.btnListarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarArticulo.Location = new System.Drawing.Point(238, 116);
            this.btnListarArticulo.Name = "btnListarArticulo";
            this.btnListarArticulo.Size = new System.Drawing.Size(151, 45);
            this.btnListarArticulo.TabIndex = 0;
            this.btnListarArticulo.Text = "Listado de articulos";
            this.btnListarArticulo.UseVisualStyleBackColor = true;
            this.btnListarArticulo.Click += new System.EventHandler(this.btnListarArticulo_Click);
            // 
            // tituloApp
            // 
            this.tituloApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloApp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tituloApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloApp.Location = new System.Drawing.Point(238, 24);
            this.tituloApp.Name = "tituloApp";
            this.tituloApp.Size = new System.Drawing.Size(151, 51);
            this.tituloApp.TabIndex = 7;
            this.tituloApp.Text = "Gestor de artículos";
            this.tituloApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.tituloApp);
            this.Controls.Add(this.btnListarArticulo);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btnBusquedaArticulo);
            this.MinimumSize = new System.Drawing.Size(674, 489);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label tituloApp;
    }
}

