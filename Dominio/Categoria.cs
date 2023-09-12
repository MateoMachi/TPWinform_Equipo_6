using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nomCategoria { get; set; }

        public override string ToString()
        {
            return nomCategoria;
        }

    }
}
