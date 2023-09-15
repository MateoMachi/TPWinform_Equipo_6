using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinform_Catalogo
{
    public partial class FormAgregar : Form
    {
        private Articulo articuloSelec = null;

        public FormAgregar(Articulo Seleccionado)
        {
          
            articuloSelec = Seleccionado;
            InitializeComponent();
        
        }

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {


            Articulo artic = new Articulo();
            ArticuloNegocio articNegocio = new ArticuloNegocio();

            try
            {
                /*
                                artic.Id = int.Parse( textBoxId.Text);
                                artic.nombre = textBoxNombre.Text;
                                artic.descripcion = textBoxDescripcion.Text;
                                artic.Categoria.nomCategoria = textBoxCategoria.Text;
                                artic.codigoArticulo = textBoxCodArticulo.Text;
                                artic.imagen.url = textBoxUrlImagen.Text;
                                artic.Marca.nomMarca = textBoxMarca.Text;
                                artic.precio = decimal.Parse(textBoxPrecio.Text );

                                articNegocio.agregarArticulo(artic);
                                */
            }
            catch (Exception)
            {

                throw;
            }







        }

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }



        private void cargarImagen(string imagen)
        {


            try
            {

                pictureBoxAlta.Load(imagen);



            }
            catch (Exception ex)
            {

                pictureBoxAlta.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }



        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
           

                AccesoDatos datos = new AccesoDatos();

                Articulo art = new Articulo();
                art.Categoria = new Categoria();
                art.Marca = new Marca();

                List<Articulo> lista = new List<Articulo>();


                datos.setearConsulta("Select Descripcion as Categoria from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    try
                    {
                        if (!(datos.Lector["Categoria"] is DBNull)) art.Categoria.nomCategoria = (string)datos.Lector["Categoria"];


                        comboBoxCategoria.Items.Add(art.Categoria.nomCategoria);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }

                datos.cerrarConexion();

                datos.setearConsulta("Select Descripcion as Marca from MARCAS");
                datos.ejecutarLectura();



                while (datos.Lector.Read())
                {
                    try
                    {

                        if (!(datos.Lector["Marca"] is DBNull)) art.Marca.nomMarca = (string)datos.Lector["Marca"];


                        comboBoxMarca.Items.Add(art.Marca.nomMarca);


                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }


                }

               if (articuloSelec != null) 
            {
                cargarImagen(articuloSelec.imagen.url);
                
                textBoxNombre.Text = articuloSelec.Nombre;
                textBoxCodArticulo.Text = articuloSelec.CodigoArticulo;
                textBoxDescripcion.Text = articuloSelec.Descripcion;
                textBoxPrecio.Text = articuloSelec.Precio.ToString();
                textBoxUrlImagen.Text = articuloSelec.imagen.url;
                comboBoxCategoria.Text = articuloSelec.Categoria.nomCategoria;
                comboBoxMarca.Text = articuloSelec.Marca.nomMarca;
            
            }
            
            datos.cerrarConexion();
            }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
   }


