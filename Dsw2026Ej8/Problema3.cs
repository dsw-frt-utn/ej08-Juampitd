using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copiaValor = originalValue;
            copiaValor++;

            Product copiaProduct = product;
            copiaProduct.UpdateDescription("Descripción Modificada");

            return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
        }
    }
}