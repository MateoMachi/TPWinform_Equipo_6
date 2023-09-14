using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
    
        public  List <Articulo> listar() {
            
            
        List <Articulo> lista = new List<Articulo>();

            AccesoDatos Dat = new AccesoDatos();

            try
            {

                Dat.setearConsulta("Select a.Id as Id, a.Codigo as Codigo,a.Nombre as Nombre,a.Descripcion as Descripcion,c.Descripcion AS Categoria,m.Descripcion AS Marca,i.ImagenUrl AS UrlImagen, a.Precio as Precio from ARTICULOS as a left join IMAGENEs as i on i.IdArticulo = a.Id left join marcas as m on m.Id = a.IdMarca left join CATEGORIAS as c on c.Id = a.IdCategoria");
                Dat.ejecutarLectura();
                

                while (Dat.Lector.Read())
                {

                    Articulo art = new Articulo();
                    
                    art.Id = (int)Dat.Lector["Id"];
                    if (!(Dat.Lector["Codigo"] is DBNull)) { art.codigoArticulo = (string)Dat.Lector["Codigo"]; }
                    if (!(Dat.Lector["Nombre"] is DBNull))  { art.nombre = (string)Dat.Lector["Nombre"];  }
                    if (!(Dat.Lector["Descripcion"] is DBNull )) { art.descripcion = (string)Dat.Lector["Descripcion"]; }
                    if (!(Dat.Lector["Precio"] is DBNull )) { art.precio = (decimal)Dat.Lector["Precio"]; }
                 

                    
                    art.Categoria = new Categoria();
                    if (!(Dat.Lector["Categoria"] is DBNull )) { art.Categoria.nomCategoria = (string)Dat.Lector["Categoria"]; }
                    else
                        art.Categoria.nomCategoria = "Sin categoria";

                   art.Marca = new Marca();
                    if (!(Dat.Lector["Marca"] is DBNull )) { art.Marca.nomMarca = (string)Dat.Lector["Marca"];  }

                  art.imagen = new Imagen();
                    if  (!(Dat.Lector["UrlImagen"] is DBNull)) { art.imagen.url = (string)Dat.Lector["UrlImagen"] ; }

                            lista.Add(art);
                    


                }
         
                   return lista; 


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                Dat.cerrarConexion();
            }


        }
    
    
    }
}
