
namespace presentacion_correa
{
	partial class FormNuevoArticulo
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
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblNombreArticulo = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.lblImagenUrl = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.tbxCodigoNuevo = new System.Windows.Forms.TextBox();
			this.tbxNombreNuevo = new System.Windows.Forms.TextBox();
			this.tbxDescripcionNuevo = new System.Windows.Forms.TextBox();
			this.tbxUrlNuevo = new System.Windows.Forms.TextBox();
			this.tbxPrecioNuevo = new System.Windows.Forms.TextBox();
			this.btnCancelarNuevo = new System.Windows.Forms.Button();
			this.btnAgregarNuevo = new System.Windows.Forms.Button();
			this.cbxMarcaNuevo = new System.Windows.Forms.ComboBox();
			this.cbxCategoriaNuevo = new System.Windows.Forms.ComboBox();
			this.pbxNuevoArticulo = new System.Windows.Forms.PictureBox();
			this.btnImagen = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbxNuevoArticulo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(12, 56);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(40, 13);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código";
			// 
			// lblNombreArticulo
			// 
			this.lblNombreArticulo.AutoSize = true;
			this.lblNombreArticulo.Location = new System.Drawing.Point(12, 97);
			this.lblNombreArticulo.Name = "lblNombreArticulo";
			this.lblNombreArticulo.Size = new System.Drawing.Size(44, 13);
			this.lblNombreArticulo.TabIndex = 1;
			this.lblNombreArticulo.Text = "Nombre";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.AutoSize = true;
			this.lblDescripcion.Location = new System.Drawing.Point(12, 138);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
			this.lblDescripcion.TabIndex = 2;
			this.lblDescripcion.Text = "Descripción";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(12, 179);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(37, 13);
			this.lblMarca.TabIndex = 3;
			this.lblMarca.Text = "Marca";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(12, 220);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(52, 13);
			this.lblCategoria.TabIndex = 4;
			this.lblCategoria.Text = "Categoria";
			// 
			// lblImagenUrl
			// 
			this.lblImagenUrl.AutoSize = true;
			this.lblImagenUrl.Location = new System.Drawing.Point(12, 261);
			this.lblImagenUrl.Name = "lblImagenUrl";
			this.lblImagenUrl.Size = new System.Drawing.Size(57, 13);
			this.lblImagenUrl.TabIndex = 5;
			this.lblImagenUrl.Text = "Url imagen";
			// 
			// lblPrecio
			// 
			this.lblPrecio.AutoSize = true;
			this.lblPrecio.Location = new System.Drawing.Point(12, 302);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(37, 13);
			this.lblPrecio.TabIndex = 6;
			this.lblPrecio.Text = "Precio";
			// 
			// tbxCodigoNuevo
			// 
			this.tbxCodigoNuevo.Location = new System.Drawing.Point(122, 49);
			this.tbxCodigoNuevo.Name = "tbxCodigoNuevo";
			this.tbxCodigoNuevo.Size = new System.Drawing.Size(178, 20);
			this.tbxCodigoNuevo.TabIndex = 0;
			// 
			// tbxNombreNuevo
			// 
			this.tbxNombreNuevo.Location = new System.Drawing.Point(122, 90);
			this.tbxNombreNuevo.Name = "tbxNombreNuevo";
			this.tbxNombreNuevo.Size = new System.Drawing.Size(178, 20);
			this.tbxNombreNuevo.TabIndex = 1;
			// 
			// tbxDescripcionNuevo
			// 
			this.tbxDescripcionNuevo.Location = new System.Drawing.Point(122, 131);
			this.tbxDescripcionNuevo.Name = "tbxDescripcionNuevo";
			this.tbxDescripcionNuevo.Size = new System.Drawing.Size(178, 20);
			this.tbxDescripcionNuevo.TabIndex = 2;
			// 
			// tbxUrlNuevo
			// 
			this.tbxUrlNuevo.Location = new System.Drawing.Point(122, 254);
			this.tbxUrlNuevo.Name = "tbxUrlNuevo";
			this.tbxUrlNuevo.Size = new System.Drawing.Size(178, 20);
			this.tbxUrlNuevo.TabIndex = 5;
			this.tbxUrlNuevo.Leave += new System.EventHandler(this.tbxUrlNuevo_Leave);
			// 
			// tbxPrecioNuevo
			// 
			this.tbxPrecioNuevo.Location = new System.Drawing.Point(122, 295);
			this.tbxPrecioNuevo.Name = "tbxPrecioNuevo";
			this.tbxPrecioNuevo.Size = new System.Drawing.Size(178, 20);
			this.tbxPrecioNuevo.TabIndex = 6;
			// 
			// btnCancelarNuevo
			// 
			this.btnCancelarNuevo.Location = new System.Drawing.Point(15, 353);
			this.btnCancelarNuevo.Name = "btnCancelarNuevo";
			this.btnCancelarNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnCancelarNuevo.TabIndex = 8;
			this.btnCancelarNuevo.Text = "Cancelar";
			this.btnCancelarNuevo.UseVisualStyleBackColor = true;
			this.btnCancelarNuevo.Click += new System.EventHandler(this.btnCancelarNuevo_Click);
			// 
			// btnAgregarNuevo
			// 
			this.btnAgregarNuevo.Location = new System.Drawing.Point(147, 353);
			this.btnAgregarNuevo.Name = "btnAgregarNuevo";
			this.btnAgregarNuevo.Size = new System.Drawing.Size(75, 23);
			this.btnAgregarNuevo.TabIndex = 7;
			this.btnAgregarNuevo.Text = "Agregar";
			this.btnAgregarNuevo.UseVisualStyleBackColor = true;
			this.btnAgregarNuevo.Click += new System.EventHandler(this.btnAgregarNuevo_Click);
			// 
			// cbxMarcaNuevo
			// 
			this.cbxMarcaNuevo.FormattingEnabled = true;
			this.cbxMarcaNuevo.Location = new System.Drawing.Point(122, 170);
			this.cbxMarcaNuevo.Name = "cbxMarcaNuevo";
			this.cbxMarcaNuevo.Size = new System.Drawing.Size(178, 21);
			this.cbxMarcaNuevo.TabIndex = 3;
			// 
			// cbxCategoriaNuevo
			// 
			this.cbxCategoriaNuevo.FormattingEnabled = true;
			this.cbxCategoriaNuevo.Location = new System.Drawing.Point(122, 211);
			this.cbxCategoriaNuevo.Name = "cbxCategoriaNuevo";
			this.cbxCategoriaNuevo.Size = new System.Drawing.Size(178, 21);
			this.cbxCategoriaNuevo.TabIndex = 4;
			// 
			// pbxNuevoArticulo
			// 
			this.pbxNuevoArticulo.Location = new System.Drawing.Point(373, 49);
			this.pbxNuevoArticulo.Name = "pbxNuevoArticulo";
			this.pbxNuevoArticulo.Size = new System.Drawing.Size(251, 266);
			this.pbxNuevoArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxNuevoArticulo.TabIndex = 16;
			this.pbxNuevoArticulo.TabStop = false;
			// 
			// btnImagen
			// 
			this.btnImagen.Location = new System.Drawing.Point(318, 254);
			this.btnImagen.Name = "btnImagen";
			this.btnImagen.Size = new System.Drawing.Size(36, 20);
			this.btnImagen.TabIndex = 17;
			this.btnImagen.Text = "+";
			this.btnImagen.UseVisualStyleBackColor = true;
			this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// FormNuevoArticulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(636, 450);
			this.Controls.Add(this.btnImagen);
			this.Controls.Add(this.pbxNuevoArticulo);
			this.Controls.Add(this.cbxCategoriaNuevo);
			this.Controls.Add(this.cbxMarcaNuevo);
			this.Controls.Add(this.btnAgregarNuevo);
			this.Controls.Add(this.btnCancelarNuevo);
			this.Controls.Add(this.tbxPrecioNuevo);
			this.Controls.Add(this.tbxUrlNuevo);
			this.Controls.Add(this.tbxDescripcionNuevo);
			this.Controls.Add(this.tbxNombreNuevo);
			this.Controls.Add(this.tbxCodigoNuevo);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblImagenUrl);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblDescripcion);
			this.Controls.Add(this.lblNombreArticulo);
			this.Controls.Add(this.lblCodigo);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(652, 489);
			this.MinimumSize = new System.Drawing.Size(652, 489);
			this.Name = "FormNuevoArticulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo articulo";
			this.Load += new System.EventHandler(this.FormNuevoArticulo_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxNuevoArticulo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label lblNombreArticulo;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblCategoria;
		private System.Windows.Forms.Label lblImagenUrl;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.TextBox tbxCodigoNuevo;
		private System.Windows.Forms.TextBox tbxNombreNuevo;
		private System.Windows.Forms.TextBox tbxDescripcionNuevo;
		private System.Windows.Forms.TextBox tbxUrlNuevo;
		private System.Windows.Forms.TextBox tbxPrecioNuevo;
		private System.Windows.Forms.Button btnCancelarNuevo;
		private System.Windows.Forms.Button btnAgregarNuevo;
		private System.Windows.Forms.ComboBox cbxMarcaNuevo;
		private System.Windows.Forms.ComboBox cbxCategoriaNuevo;
		private System.Windows.Forms.PictureBox pbxNuevoArticulo;
		private System.Windows.Forms.Button btnImagen;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}