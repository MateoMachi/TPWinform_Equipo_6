using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        
        
        public int Id { get; set; }
        [DisplayName("Codigo de articulo")]
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descipción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
    
        public Categoria Categoria { get; set; }
      
        public Imagen imagen { get; set; }
       
        
        public decimal Precio { get; set; }

    }
}



