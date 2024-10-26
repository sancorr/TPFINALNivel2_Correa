using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion_correa
{
	public partial class FormEliminados : Form
	{
		private List<Articulo> listaEliminados;
		public FormEliminados()
		{
			InitializeComponent();
		}

		private void ocultarColumna(string cadena)
		{
			dgvEliminados.Columns[cadena].Visible = false;
		}

		private void cargarImagen(string imagen)
		{
			try
			{
				pbxEliminados.Load(imagen);
			}
			catch (Exception ex)
			{

				pbxEliminados.Load("https://imgs.search.brave.com/fVrzTsY8XbfClD6SD9ps0BmYFUEi7I2qsepvPy4Ypj4/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly90My5m/dGNkbi5uZXQvanBn/LzA3LzU2LzY3LzM0/LzM2MF9GXzc1NjY3/MzQ2Nl9RclpHNU45/bDM4TGw4cE1NQW5J/NzgwWWxQcVROMm5h/aC5qcGc");
			}
		}

		private void cargarEliminados()
		{
			ArticuloNegocio negocio = new ArticuloNegocio();
			try
			{
				listaEliminados = negocio.listarEliminados();
				dgvEliminados.DataSource = listaEliminados;
				ocultarColumna("ImagenUrl");
				ocultarColumna("Id");
				ocultarColumna("IdMarca");
				ocultarColumna("IdCategoria");
				cargarImagen(listaEliminados[0].ImagenUrl);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void FormEliminados_Load(object sender, EventArgs e)
		{
			cargarEliminados();
		}

		private void dgvEliminados_SelectionChanged(object sender, EventArgs e)
		{
			Articulo seleccionado = (Articulo)dgvEliminados.CurrentRow.DataBoundItem;
			cargarImagen(seleccionado.ImagenUrl);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRestaurar_Click(object sender, EventArgs e)
		{
			ArticuloNegocio negocio = new ArticuloNegocio();
			Articulo seleccionado; 

			try
			{
				DialogResult res = MessageBox.Show("¿Reactivar articulo?", "REACTIVAR ARTICULO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(res == DialogResult.Yes)
				{
					seleccionado = (Articulo)dgvEliminados.CurrentRow.DataBoundItem;
					negocio.reactivarArticulo(seleccionado.Id);
					cargarEliminados();
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al restaurar articulo. ERROR: ", ex.ToString());
			}
		}
	}
}
