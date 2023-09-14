using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Marca Marca { get; set; }
    
        public Categoria Categoria { get; set; }
      
        public Imagen imagen { get; set; }
       
        
        public decimal precio { get; set; }

    }
}



