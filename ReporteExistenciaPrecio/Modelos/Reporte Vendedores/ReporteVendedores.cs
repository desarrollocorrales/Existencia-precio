using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReporteExistenciaPrecio.Modelos.Reporte_Vendedores
{
    public class ReporteVendedores
    {
        public String Vendedor { set; get; }
        public String Articulo { set; get; }
        public Decimal VentaTotal { set; get; }
        public Decimal UnidadesVendidas { set; get; }
        public Decimal UltimoCostoUnitario { set; get; }
        public Decimal CostoTotal
        {
            get
            {
                return UnidadesVendidas * UltimoCostoUnitario;
            }
        }
        public Decimal Utilidad
        {
            get
            {
                return VentaTotal - CostoTotal;
            }
        }
    }
}
