
namespace presentacion_correa
{
	partial class FormEliminados
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
			this.pbxEliminados = new System.Windows.Forms.PictureBox();
			this.dgvEliminados = new System.Windows.Forms.DataGridView();
			this.btnRestaurar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbxEliminados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).BeginInit();
			this.SuspendLayout();
			// 
			// pbxEliminados
			// 
			this.pbxEliminados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbxEliminados.Location = new System.Drawing.Point(673, 94);
			this.pbxEliminados.MinimumSize = new System.Drawing.Size(177, 225);
			this.pbxEliminados.Name = "pbxEliminados";
			this.pbxEliminados.Size = new System.Drawing.Size(208, 225);
			this.pbxEliminados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxEliminados.TabIndex = 0;
			this.pbxEliminados.TabStop = false;
			// 
			// dgvEliminados
			// 
			this.dgvEliminados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEliminados.Location = new System.Drawing.Point(13, 94);
			this.dgvEliminados.MinimumSize = new System.Drawing.Size(450, 225);
			this.dgvEliminados.Name = "dgvEliminados";
			this.dgvEliminados.Size = new System.Drawing.Size(610, 225);
			this.dgvEliminados.TabIndex = 1;
			this.dgvEliminados.SelectionChanged += new System.EventHandler(this.dgvEliminados_SelectionChanged);
			// 
			// btnRestaurar
			// 
			this.btnRestaurar.Location = new System.Drawing.Point(13, 346);
			this.btnRestaurar.Name = "btnRestaurar";
			this.btnRestaurar.Size = new System.Drawing.Size(117, 23);
			this.btnRestaurar.TabIndex = 2;
			this.btnRestaurar.Text = "Restaurar articulo";
			this.btnRestaurar.UseVisualStyleBackColor = true;
			this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(164, 346);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
			// 
			// FormEliminados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(938, 387);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnRestaurar);
			this.Controls.Add(this.dgvEliminados);
			this.Controls.Add(this.pbxEliminados);
			this.Name = "FormEliminados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormEliminados";
			this.Load += new System.EventHandler(this.FormEliminados_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbxEliminados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEliminados)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbxEliminados;
		private System.Windows.Forms.DataGridView dgvEliminados;
		private System.Windows.Forms.Button btnRestaurar;
		private System.Windows.Forms.Button btnCancelar;
	}
}