using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
{
    public string ObtenerEtiquetaProducto(long code, string description, decimal price)
    {
        // El formato moneda se logra con :C
        return $"[{code}] {description} - {price:C}";
    }
}
}
