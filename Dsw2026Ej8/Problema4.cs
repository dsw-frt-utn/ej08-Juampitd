using System;
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double ObtenerPromedio(int? n1, int? n2, int? n3)
        {
            var notas = new List<int?> { n1, n2, n3 };

            var validas = notas
                .Where(n => n.HasValue && n.Value >= 0 && n.Value <= 10)
                .Select(n => (double)n!.Value)
                .ToList();

            if (validas.Count == 0) return 0;

            return validas.Average();
        }
    }
}