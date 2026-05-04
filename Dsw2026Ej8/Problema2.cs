using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            // El total es 0 si la cantidad es <= 0
            decimal total = quantity > 0 ? quantity * unitPrice : 0;

            // Creación de la clase anónima que pide el ejercicio
            var resumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            // Retornamos el formato pedido: Codigo-Descripcion-Total
            return $"{resumen.Code}-{resumen.Description}-{resumen.Total}";
        }
    }
}