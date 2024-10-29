using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
	public class MarcaArticuloNegocio
	{
		//Listar marcas desde db
		public List<MarcaArticulo> listar()
		{
			List<MarcaArticulo> lista = new List<MarcaArticulo>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.setConsulta("select Id, Descripcion from MARCAS");
				datos.ejecutarLectura();
				while (datos.Lector.Read())
				{
					MarcaArticulo aux = new MarcaArticulo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];

					lista.Add(aux);
				}

				return lista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}

		//Insertar nueva marca- no lo uso pero la dejo para implementar a futuro
		public void insertarMarca(MarcaArticulo marca)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				marca.Descripcion = marca.Descripcion.ToLower();
				datos.setConsulta("insert into MARCAS (Descripcion) values (@descripcion)");
				datos.setParametros("@descripcion", marca.Descripcion);
				datos.ejecutarAccion();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}

	}
}
