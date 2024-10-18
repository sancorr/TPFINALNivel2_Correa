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
using System.Configuration;

namespace presentacion_correa
{
	public partial class FormNuevoArticulo : Form
	{
		private Articulo article = null;
		private OpenFileDialog archivo = null;

		//REF AL FORMULARIO PRINCIPAL
		private formArticulos formPrincipal;

		//boton agregar - constructor
		public FormNuevoArticulo()
		{
			InitializeComponent();
		}

		//boton modificar - constructor
		public FormNuevoArticulo(Articulo art, formArticulos formPrincipal)
		{
			InitializeComponent();
			this.article = art;
			//REF AL FORM PRINCIPAL QUE VIENE POR PARAMETRO
			this.formPrincipal = formPrincipal;
		}

		private void btnCancelarNuevo_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("¿Seguro desea cancelar? Los cambios no se guardaran", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.Yes)
			{
				this.Close();
			}

		}

		private void btnAgregarNuevo_Click(object sender, EventArgs e)
		{
			ArticuloNegocio negocio = new ArticuloNegocio();

			if(article == null)
				article = new Articulo();

			try
			{
				string imagenAnterior = (article.Id != 0) ? article.ImagenUrl : null;

				article.Codigo = tbxCodigoNuevo.Text;
				article.Nombre = tbxNombreNuevo.Text;
				article.Descripcion = tbxDescripcionNuevo.Text;
				article.Categoria = (CategoriaArticulo)cbxCategoriaNuevo.SelectedItem;
				article.Marca = (MarcaArticulo)cbxMarcaNuevo.SelectedItem;
				article.ImagenUrl = tbxUrlNuevo.Text;
				article.Precio = decimal.Parse(tbxPrecioNuevo.Text);

				if(article.Id != 0)
				{
					
					if(archivo != null && !(tbxUrlNuevo.Text.ToLower().Contains("http")))
					{
						//libero la img del pbx en modificacion
						if (pbxNuevoArticulo.Image != null)
						{
							pbxNuevoArticulo.Image = null;
							pbxNuevoArticulo.Image.Dispose();
						}

						//si es la misma imagen del pbx en el form principal, la libero tambien desde la referencia al formulario principal que viene por parametro
						if(formPrincipal.pbxArticulo.Image != null && formPrincipal.pbxArticulo.ImageLocation == imagenAnterior)
						{
							formPrincipal.pbxArticulo.Image = null;
							formPrincipal.pbxArticulo.Image.Dispose();
						}

						//si la ruta a la imagen anterior no es nula o vacia Y si esa ruta existe, eliminar.
						if(!string.IsNullOrEmpty(imagenAnterior) && File.Exists(imagenAnterior))
						{
							try
							{
								File.Delete(imagenAnterior);
							}
							catch (Exception ex)
							{

								MessageBox.Show("Error al eliminar la imagen anterior: " +			         ex.ToString());
							}
						}

						File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

						negocio.modificarArticulo(article);
						MessageBox.Show("Articulo modificado con éxito", "ARTICULO MODIFICADO");
					}
				}
				else
				{
					negocio.agregarArticulo(article);
					MessageBox.Show("Articulo agregado con éxito", "ARTICULO AGREGADO");
					if (archivo != null && !(tbxUrlNuevo.Text.ToLower().Contains("http")))
					{
						File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
					}
				}

				

				Close();
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void FormNuevoArticulo_Load(object sender, EventArgs e)
		{
			CategoriaArticuloNegocio articuloNuevoNegocio = new CategoriaArticuloNegocio();
			MarcaArticuloNegocio marcaArticuloNegocio = new MarcaArticuloNegocio();
			try
			{
				cbxMarcaNuevo.DataSource = marcaArticuloNegocio.listar();
				cbxMarcaNuevo.ValueMember = "Id";
				cbxMarcaNuevo.DisplayMember = "Descripcion";
				cbxCategoriaNuevo.DataSource = articuloNuevoNegocio.listar();
				cbxCategoriaNuevo.ValueMember = "Id";
				cbxCategoriaNuevo.DisplayMember = "Descripcion";

				if (article != null)
				{
					tbxCodigoNuevo.Text = article.Codigo;
					tbxNombreNuevo.Text = article.Nombre;
					tbxDescripcionNuevo.Text = article.Descripcion;

					cbxMarcaNuevo.SelectedValue = article.Marca.Id;
					cbxCategoriaNuevo.SelectedValue = article.Categoria.Id;					

					tbxUrlNuevo.Text = article.ImagenUrl;
					cargarImagen(article.ImagenUrl);
					tbxPrecioNuevo.Text = article.Precio.ToString();

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.ToString());
			}
		}

		private void cargarImagen(string imagen)
		{
			try
			{
				pbxNuevoArticulo.Load(imagen);
			}
			catch (Exception ex)
			{

				pbxNuevoArticulo.Load("https://imgs.search.brave.com/fVrzTsY8XbfClD6SD9ps0BmYFUEi7I2qsepvPy4Ypj4/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly90My5m/dGNkbi5uZXQvanBn/LzA3LzU2LzY3LzM0/LzM2MF9GXzc1NjY3/MzQ2Nl9RclpHNU45/bDM4TGw4cE1NQW5J/NzgwWWxQcVROMm5h/aC5qcGc");
			}
		}

		private void tbxUrlNuevo_Leave(object sender, EventArgs e)
		{
			cargarImagen(tbxUrlNuevo.Text);
		}

		private void btnImagen_Click(object sender, EventArgs e)
		{
			archivo = new OpenFileDialog();
			archivo.Filter = "jpg|*.jpg;| png|*.png";
			if(archivo.ShowDialog() == DialogResult.OK)
			{
				tbxUrlNuevo.Text = archivo.FileName;
				cargarImagen(archivo.FileName);

			}
		}
	}
}
