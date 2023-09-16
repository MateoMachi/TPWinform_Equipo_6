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
    
        public  List <Articulo> listar () {
            
            
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
                    if (!(Dat.Lector["Codigo"] is DBNull)) { art.CodigoArticulo = (string)Dat.Lector["Codigo"]; }
                    if (!(Dat.Lector["Nombre"] is DBNull))  { art.Nombre = (string)Dat.Lector["Nombre"];  }
                    if (!(Dat.Lector["Descripcion"] is DBNull )) { art.Descripcion = (string)Dat.Lector["Descripcion"]; }
                    if (!(Dat.Lector["Precio"] is DBNull )) { art.Precio = (decimal)Dat.Lector["Precio"]; }
                 

                    
                    art.Categoria = new Categoria();
                    if (!(Dat.Lector["Categoria"] is DBNull )) { art.Categoria.nomCategoria = (string)Dat.Lector["Categoria"]; }
                    else
                        art.Categoria.nomCategoria = "Sin categoria";

                   art.Marca = new Marca();
                    if (!(Dat.Lector["Marca"] is DBNull )) { art.Marca.nomMarca = (string)Dat.Lector["Marca"];  }

                    else
                    art.Marca.nomMarca = "Sin Marca";


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
    
        public void agregarArticulo(Articulo nuevoArticulo)
        {

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {

                accesoDatos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio)values('" + nuevoArticulo.CodigoArticulo + "','" + nuevoArticulo.Nombre + "','" + nuevoArticulo.Descripcion + "'," + nuevoArticulo.Marca.idMarca + "," + nuevoArticulo.Categoria.idCategoria + "," + nuevoArticulo.Precio + ") Insert into Imagenes (idArticulo,imagenurl) values (" + nuevoArticulo.Id + ",'" + nuevoArticulo.imagen.url + "')");
                accesoDatos.ejecutarAccion();

           
             }
            catch (Exception)
            {

                throw;
            }

            finally
            {

                accesoDatos.cerrarConexion();
            }
        }
        public void EliminarArticulo(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setParameters("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void ModificarArticulo(Articulo modificar)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
               
                Datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria,  Precio = @precio  Where Id = @id");
                Datos.setParameters("@codigo", modificar.CodigoArticulo);
                Datos.setParameters("@nombre", modificar.Nombre);
                Datos.setParameters("@descripcion", modificar.Descripcion);
                Datos.setParameters("@IdMarca", modificar.Marca.idMarca);
                Datos.setParameters("@IdCategoria", modificar.Categoria.idCategoria);
                Datos.setParameters("@precio", modificar.Precio);
                Datos.setParameters("@id", modificar.Id);
                Datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.cerrarConexion();
            }
        }



        public int TraerUltimoId()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                int cont = 0;
                datos.setearConsulta("select id from ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    cont++;
                }

                return cont + 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }












    }
}
