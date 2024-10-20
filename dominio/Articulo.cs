﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
		public int Id { get; set; }
		public int IdMarca { get; set; }
		public int IdCategoria { get; set; }
		public decimal Precio { get; set; }
		public string Codigo { get; set; }
		public string Nombre { get; set; }
		public string Descripcion { get; set; }
		public string ImagenUrl { get; set; }
		public CategoriaArticulo Categoria { get; set; }
		public MarcaArticulo Marca { get; set; }
	}
}
