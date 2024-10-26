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
using System.Text.RegularExpressions;

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

		private void validarCampos(ref bool bandera, string cadena, TextBox campo)
		{
			if (string.IsNullOrEmpty(campo.Text))
			{
				bandera = false;
				errorProvider.SetError(campo, cadena);
			}
			else
			{
				errorProvider.SetError(campo, null);
			}
		}
		
		private void btnAgregarNuevo_Click(object sender, EventArgs e)
		{
			ArticuloNegocio negocio = new ArticuloNegocio();

			if(article == null)
				article = new Articulo();

			try
			{

				//Bandera para validaciones
				bool esValido = true;
				//Bandera para precio
				decimal precio;


				validarCampos(ref esValido, "Ingrese el código del producto", tbxCodigoNuevo);
				
				if (string.IsNullOrEmpty(tbxNombreNuevo.Text) || !tbxNombreNuevo.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
				{
					esValido = false;
					errorProvider.SetError(tbxNombreNuevo, "Ingrese el nombre del producto, sólo letras y números");
				}
				else
				{
					errorProvider.SetError(tbxNombreNuevo, null);
				}

				validarCampos(ref esValido, "Ingrese la descripción del producto", tbxDescripcionNuevo);
				
				if(string.IsNullOrEmpty(tbxPrecioNuevo.Text) || !decimal.TryParse(tbxPrecioNuevo.Text, out precio))
				{
					esValido = false;
					errorProvider.SetError(tbxPrecioNuevo, "Ingrese el precio. Sólo números");
				}
				else
				{
					errorProvider.SetError(tbxPrecioNuevo, null);
				}

				if (!esValido)
				{
					MessageBox.Show("Por favor complete o corriga los campos obligatorios", "Campos incompletos o incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}


				//Si el articulo existe, me guardo la URL de su imagen
				string imagenAnterior = null;
				if (article.Id != 0)
				{
					imagenAnterior = article.ImagenUrl;
				}

				article.Codigo = tbxCodigoNuevo.Text;
				article.Nombre = tbxNombreNuevo.Text;
				article.Descripcion = tbxDescripcionNuevo.Text;
				article.Categoria = (CategoriaArticulo)cbxCategoriaNuevo.SelectedItem;
				article.Marca = (MarcaArticulo)cbxMarcaNuevo.SelectedItem;
				article.Precio = decimal.Parse(tbxPrecioNuevo.Text);


				//SI ES UNA MODIFICACION
				if (article.Id != 0)
				{

					if (archivo != null && !(tbxUrlNuevo.Text.ToLower().Contains("http")))
					{
						string destinoImagen = ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName;

						File.Copy(archivo.FileName, destinoImagen);
						article.ImagenUrl = destinoImagen;
						
					}
					else
					{
						article.ImagenUrl = tbxUrlNuevo.Text;
					}

					negocio.modificarArticulo(article);

					formPrincipal.pbxArticulo.ImageLocation = article.ImagenUrl;

					if (File.Exists(imagenAnterior))
					{

						try
						{
							System.GC.Collect();
							System.GC.WaitForPendingFinalizers();
							
							File.Delete(imagenAnterior);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error al eliminar la imagen anterior: " + ex.ToString());
						}

					}

					MessageBox.Show("Articulo modificado con éxito", "ARTICULO MODIFICADO");
			}
				else
				{

					if (archivo != null && !(tbxUrlNuevo.Text.ToLower().Contains("http")))
					{

						string archivoOriginal = Path.GetFileNameWithoutExtension(archivo.SafeFileName);
						string extensionArchivo = Path.GetExtension(archivo.SafeFileName);
						string fechaHora = DateTime.Now.ToString("yyyyMMDD_HHmmss");
						string archivoNombreCompleto = $"{archivoOriginal}_{fechaHora}{extensionArchivo}";

						string destinoImagen = Path.Combine(ConfigurationManager.AppSettings["images-folder"], archivoNombreCompleto);

						File.Copy(archivo.FileName, destinoImagen);
						article.ImagenUrl = destinoImagen;
					}
					else
					{
						article.ImagenUrl = tbxUrlNuevo.Text;
					}

					negocio.agregarArticulo(article);
					MessageBox.Show("Articulo agregado con éxito", "ARTICULO AGREGADO");
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
				if (!imagen.ToLower().Contains("http"))
				{
					pbxNuevoArticulo.Image = null;
					using (var stream = new FileStream(imagen, FileMode.Open, FileAccess.Read))
					{
						pbxNuevoArticulo.Image = Image.FromStream(stream);
					}
				}
				else if(imagen.ToLower().Contains("http"))
				{
					pbxNuevoArticulo.Load(imagen);
				}
				else
				{
					throw new Exception("URL o archivo local inválido");
				}

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
