using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoguiApp.Models
{
    public class CorItem
    {
        public string Nome { get; set; }
        public string Hex { get; set; }

        public CorItem(string nome, string hex)
        {
            Nome = nome;
            Hex = hex;
        }
    }
}

