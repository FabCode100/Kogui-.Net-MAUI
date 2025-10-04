using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoguiApp.Models
{
    public class ChaveCor
    {
        public string Hex { get; set; }
        public string Cor { get; set; }
        public string Componente { get; set; }

        public ChaveCor(string hex, string cor, string componente)
        {
            Hex = hex;
            Cor = cor;
            Componente = componente;
        }
    }
}

