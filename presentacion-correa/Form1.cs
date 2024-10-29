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
using System.IO;
using System.Net.Http;

namespace presentacion_correa
{
	public partial class formArticulos : Form
	{
		private List<Articulo> listaArticulo;


		public formArticulos()
		{
			InitializeComponent();
		}


		private async void cargarImagen(string imagen)
		{
			try
			{
				pbxArticulo.Image = null;

				if (string.IsNullOrEmpty(imagen))
					throw new Exception("URL vacia o incorrecta");

				if (Uri.IsWellFormedUriString(imagen, UriKind.Absolute) && imagen.ToLower().Contains("http"))
				{
					using (HttpClient clienteImagen = new HttpClient())
					{
						var respuesta = await clienteImagen.GetAsync(imagen);
						if (respuesta.IsSuccessStatusCode)
						{
							using (var stream = await respuesta.Content.ReadAsStreamAsync())
							{
								pbxArticulo.Image = Image.FromStream(stream);
							}
						}
						else
						{
							throw new Exception("No se pudo acceder a la URL");
						}
					}
					
				}
				else if(File.Exists(imagen))
				{
					using (var stream = new FileStream(imagen, FileMode.Open, FileAccess.Read))
					{
						pbxArticulo.Image = Image.FromStream(stream);
					}
				}
				else
				{
					throw new Exception("URL o archivo local no válido");
				}
			}
			catch (Exception ex)
			{
				pbxArticulo.Load("https://imgs.search.brave.com/fVrzTsY8XbfClD6SD9ps0BmYFUEi7I2qsepvPy4Ypj4/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly90My5m/dGNkbi5uZXQvanBn/LzA3LzU2LzY3LzM0/LzM2MF9GXzc1NjY3/MzQ2Nl9RclpHNU45/bDM4TGw4cE1NQW5J/NzgwWWxQcVROMm5h/aC5qcGc");
			}
		}

		private void ocultarColumna(string cadena)
		{
			dgvArticulos.Columns[cadena].Visible = false;
		}

		private void cargar()
		{
			ArticuloNegocio negocio = new ArticuloNegocio();
			try
			{
				listaArticulo = negocio.listar();
				if (listaArticulo.Count > 0)
				{
					dgvArticulos.DataSource = listaArticulo;
					ocultarColumna("ImagenUrl");
					ocultarColumna("Id");
					ocultarColumna("IdMarca");
					ocultarColumna("IdCategoria");

					btnModificarArticulo.Visible = true;
					btnEliminar.Visible = true;

					cargarImagen(listaArticulo[0].ImagenUrl);
				}
				else if(listaArticulo.Count <= 0)
				{
					//Asigno lista vacia para que no muestre el mensaje sin desplegar la aplicacion primero
					dgvArticulos.DataSource = new List<Articulo>();

					btnModificarArticulo.Visible = false;
					btnEliminar.Visible = false;				

					this.Shown += (s, e) =>
					{
						MessageBox.Show("Sin articulos para mostrar, agregue o restaure para visualizarlo", "Lista vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
					};
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}
		
		private bool validarNumeros(string cadena)
		{
			foreach (char i in cadena)
			{
				if (!(char.IsNumber(i)))
				{
					return false;
				}
			}
			return true;
		}
		
		private bool validacionFiltro()
		{
			if(cbxCampo.SelectedIndex < 0)
			{
				MessageBox.Show("Por favor seleccione un CAMPO");
				return true;
			}
			if(cbxCriterio.SelectedIndex < 0)
			{
				MessageBox.Show("Por favor seleccione un CRITERIO");
				return true;
			}
			if(cbxCampo.SelectedItem.ToString() == "Precio")
			{
				if (string.IsNullOrEmpty(tbxFiltro.Text))
				{
					MessageBox.Show("Por favor ingrese un precio para filtrar");
					return true;
				}
				if (!(validarNumeros(tbxFiltro.Text)))
				{
					MessageBox.Show("Por favor ingrese solamente números para filtrar por precio");
					return true;
				}
			}

			return false;
		}


		//INVOCACIONES A BASE DE DATOS (PARA RENDERIZAR)
		private void formArticulos_Load(object sender, EventArgs e)
		{
			cargar();
			cbxCampo.Items.Add("Codigo de articulo");
			cbxCampo.Items.Add("Nombre de articulo");
			cbxCampo.Items.Add("Marca");
			cbxCampo.Items.Add("Categoria");
			cbxCampo.Items.Add("Precio");
		}

		private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
		{
			Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
			cargarImagen(seleccionado.ImagenUrl);
		}

		private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
		{
			string opcion = cbxCampo.SelectedItem.ToString();
			
			if(opcion == "Precio")
			{
				cbxCriterio.Items.Clear();
				cbxCriterio.Items.Add("Menor a");
				cbxCriterio.Items.Add("Igual a");
				cbxCriterio.Items.Add("Mayor a");

			}
			else
			{
				cbxCriterio.Items.Clear();
				cbxCriterio.Items.Add("Comienza con");
				cbxCriterio.Items.Add("Contiene");
				cbxCriterio.Items.Add("Termina con");
			}
			
			


		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			ArticuloNegocio negocio = new ArticuloNegocio();
			try
			{
				if (validacionFiltro())
					return;

				string campo = cbxCampo.SelectedItem.ToString();
				string criterio = cbxCriterio.SelectedItem.ToString();
				string filtro = tbxFiltro.Text;

				dgvArticulos.DataSource = negocio.filtrarDB(campo, criterio, filtro);

				if (dgvArticulos.Rows.Count == 0)
				{
					pbxArticulo.Image = null;
					pbxArticulo.Visible = false;

					btnModificarArticulo.Visible = false;
					btnEliminar.Visible = false;
				}
				else
				{
					btnModificarArticulo.Visible = true;
					btnEliminar.Visible = true;

					pbxArticulo.Visible = true;
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void btnNuevoArticulo_Click(object sender, EventArgs e)
		{
			FormNuevoArticulo agregar = new FormNuevoArticulo();
			agregar.ShowDialog();
			cargar();
		}

		private void btnModificarArticulo_Click(object sender, EventArgs e)
		{
			Articulo seleccionado;
			seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
			FormNuevoArticulo modificar = new FormNuevoArticulo(seleccionado, this);
			modificar.ShowDialog();
			cargar();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			ArticuloNegocio negocio = new ArticuloNegocio();
			Articulo seleccionado;

			try
			{
				DialogResult res = MessageBox.Show("¿Desea eliminar el articulo?", "ELIMINAR ARTICULO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if(res == DialogResult.Yes)
				{
					seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
					negocio.eliminarArticulo(seleccionado.Id);
					cargar();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnVerEliminados_Click(object sender, EventArgs e)
		{
			FormEliminados ArtEliminados = new FormEliminados();
			ArtEliminados.ShowDialog();
			cargar();
		}
	}
}
