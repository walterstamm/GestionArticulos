﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Articulo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }///URL de imagen 
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public float Precio { get; set; }

    }
}
