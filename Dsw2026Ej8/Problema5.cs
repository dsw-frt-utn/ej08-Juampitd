using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public abstract class Sale
    {
        public decimal Amount { get; set; }
        public virtual decimal CalculateTotal() => Amount;
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal() => Amount;
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal() => Amount * 0.9m;
    }

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}