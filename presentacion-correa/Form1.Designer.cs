
namespace presentacion_correa
{
	partial class formArticulos
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
			this.dgvArticulos = new System.Windows.Forms.DataGridView();
			this.pbxArticulo = new System.Windows.Forms.PictureBox();
			this.labelCampo = new System.Windows.Forms.Label();
			this.labelCriterio = new System.Windows.Forms.Label();
			this.labelFiltro = new System.Windows.Forms.Label();
			this.cbxCampo = new System.Windows.Forms.ComboBox();
			this.cbxCriterio = new System.Windows.Forms.ComboBox();
			this.tbxFiltro = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnNuevoArticulo = new System.Windows.Forms.Button();
			this.btnModificarArticulo = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnVerEliminados = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvArticulos
			// 
			this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvArticulos.Location = new System.Drawing.Point(12, 129);
			this.dgvArticulos.MultiSelect = false;
			this.dgvArticulos.Name = "dgvArticulos";
			this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArticulos.Size = new System.Drawing.Size(796, 194);
			this.dgvArticulos.TabIndex = 0;
			this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
			// 
			// pbxArticulo
			// 
			this.pbxArticulo.Location = new System.Drawing.Point(844, 129);
			this.pbxArticulo.Name = "pbxArticulo";
			this.pbxArticulo.Size = new System.Drawing.Size(213, 194);
			this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxArticulo.TabIndex = 1;
			this.pbxArticulo.TabStop = false;
			// 
			// labelCampo
			// 
			this.labelCampo.AutoSize = true;
			this.labelCampo.Location = new System.Drawing.Point(21, 72);
			this.labelCampo.Name = "labelCampo";
			this.labelCampo.Size = new System.Drawing.Size(40, 13);
			this.labelCampo.TabIndex = 2;
			this.labelCampo.Text = "Campo";
			// 
			// labelCriterio
			// 
			this.labelCriterio.AutoSize = true;
			this.labelCriterio.Location = new System.Drawing.Point(211, 72);
			this.labelCriterio.Name = "labelCriterio";
			this.labelCriterio.Size = new System.Drawing.Size(39, 13);
			this.labelCriterio.TabIndex = 3;
			this.labelCriterio.Text = "Criterio";
			// 
			// labelFiltro
			// 
			this.labelFiltro.AutoSize = true;
			this.labelFiltro.Location = new System.Drawing.Point(401, 72);
			this.labelFiltro.Name = "labelFiltro";
			this.labelFiltro.Size = new System.Drawing.Size(29, 13);
			this.labelFiltro.TabIndex = 4;
			this.labelFiltro.Text = "Filtro";
			// 
			// cbxCampo
			// 
			this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCampo.FormattingEnabled = true;
			this.cbxCampo.Location = new System.Drawing.Point(73, 68);
			this.cbxCampo.Name = "cbxCampo";
			this.cbxCampo.Size = new System.Drawing.Size(121, 21);
			this.cbxCampo.TabIndex = 0;
			this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
			// 
			// cbxCriterio
			// 
			this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCriterio.FormattingEnabled = true;
			this.cbxCriterio.Location = new System.Drawing.Point(263, 68);
			this.cbxCriterio.Name = "cbxCriterio";
			this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
			this.cbxCriterio.TabIndex = 1;
			// 
			// tbxFiltro
			// 
			this.tbxFiltro.Location = new System.Drawing.Point(453, 68);
			this.tbxFiltro.Name = "tbxFiltro";
			this.tbxFiltro.Size = new System.Drawing.Size(137, 20);
			this.tbxFiltro.TabIndex = 2;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(635, 66);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 3;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnNuevoArticulo
			// 
			this.btnNuevoArticulo.Location = new System.Drawing.Point(12, 345);
			this.btnNuevoArticulo.Name = "btnNuevoArticulo";
			this.btnNuevoArticulo.Size = new System.Drawing.Size(87, 23);
			this.btnNuevoArticulo.TabIndex = 4;
			this.btnNuevoArticulo.Text = "Nuevo artículo";
			this.btnNuevoArticulo.UseVisualStyleBackColor = true;
			this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
			// 
			// btnModificarArticulo
			// 
			this.btnModificarArticulo.Location = new System.Drawing.Point(123, 345);
			this.btnModificarArticulo.Name = "btnModificarArticulo";
			this.btnModificarArticulo.Size = new System.Drawing.Size(75, 23);
			this.btnModificarArticulo.TabIndex = 5;
			this.btnModificarArticulo.Text = "Modificar artículo";
			this.btnModificarArticulo.UseVisualStyleBackColor = true;
			this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(222, 345);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 23);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar artículo";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnVerEliminados
			// 
			this.btnVerEliminados.Location = new System.Drawing.Point(362, 345);
			this.btnVerEliminados.Name = "btnVerEliminados";
			this.btnVerEliminados.Size = new System.Drawing.Size(106, 23);
			this.btnVerEliminados.TabIndex = 7;
			this.btnVerEliminados.Text = "Ver eliminados";
			this.btnVerEliminados.UseVisualStyleBackColor = true;
			this.btnVerEliminados.Click += new System.EventHandler(this.btnVerEliminados_Click);
			// 
			// formArticulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1094, 450);
			this.Controls.Add(this.btnVerEliminados);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificarArticulo);
			this.Controls.Add(this.btnNuevoArticulo);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.tbxFiltro);
			this.Controls.Add(this.cbxCriterio);
			this.Controls.Add(this.cbxCampo);
			this.Controls.Add(this.labelFiltro);
			this.Controls.Add(this.labelCriterio);
			this.Controls.Add(this.labelCampo);
			this.Controls.Add(this.pbxArticulo);
			this.Controls.Add(this.dgvArticulos);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1110, 489);
			this.MinimumSize = new System.Drawing.Size(1110, 489);
			this.Name = "formArticulos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Articulos";
			this.Load += new System.EventHandler(this.formArticulos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvArticulos;
		private System.Windows.Forms.Label labelCampo;
		private System.Windows.Forms.Label labelCriterio;
		private System.Windows.Forms.Label labelFiltro;
		private System.Windows.Forms.ComboBox cbxCampo;
		private System.Windows.Forms.ComboBox cbxCriterio;
		private System.Windows.Forms.TextBox tbxFiltro;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnNuevoArticulo;
		private System.Windows.Forms.Button btnModificarArticulo;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnVerEliminados;
		public System.Windows.Forms.PictureBox pbxArticulo;
	}
}

