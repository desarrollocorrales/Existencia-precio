using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReporteExistenciaPrecio.Modelos
{
    public class Reporte
    {
        public string Articulo { set; get; }
        public decimal Existencia { set; get; }
        public decimal PrecioFilial { set; get; }
        public decimal PrecioMayoreo { set; get; }
        public decimal PrecioLista { set; get; }
    }
}
