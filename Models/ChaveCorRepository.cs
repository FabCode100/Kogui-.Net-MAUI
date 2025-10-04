using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoguiApp.Models
{
    public static class ChaveCorRepository
    {
        public static List<ChaveCor> GerarListaChaves()
        {
            return new List<ChaveCor>
            {
                new ChaveCor("#F35DA3", "MagentaFuchsia", ""),
                new ChaveCor("#FFFFFF", "White", "para"),
                new ChaveCor("#0000FF", "Blue", "Pares"),
                new ChaveCor("#00FF00", "Green", "alterar"),
                new ChaveCor("#000000", "Black", "#"),
                new ChaveCor("#FFA500", "WebOrange", "e"),
                new ChaveCor("#FFFF00", "Yellow", "impares"),
                new ChaveCor("#FF0000", "Red", "\"\""),
                new ChaveCor("#F0FFF0", "Coconut", "Busca"),
                new ChaveCor("#00FFFF", "CyanAqua", "primos")
            };
        }
    }
}
