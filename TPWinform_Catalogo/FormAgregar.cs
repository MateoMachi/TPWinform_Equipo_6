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
          
            this.articuloSelec = Seleccionado;
            InitializeComponent();
        
        }

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {


           
                if (buttonConfirmar.Text != "" && textBoxDescripcion.Text != "" && textBoxPrecio.Text != "")
                {
                    if (articuloSelec == null)
                    {
                        articuloSelec = new Articulo();
                    }

                    articuloSelec.CodigoArticulo = textBoxCodArticulo.Text;
                    articuloSelec.Nombre = textBoxNombre.Text;
                    articuloSelec.Descripcion = textBoxDescripcion.Text;


                    articuloSelec.Categoria = new Categoria();
                    if (comboBoxCategoria.Text == "Celulares")
                    {
                        articuloSelec.Categoria.idCategoria = 1;
                    }
                    if (comboBoxCategoria.Text == "Televisores")
                    {
                        articuloSelec.Categoria.idCategoria = 2;
                    }
                    if (comboBoxCategoria.Text == "Media")
                    {
                        articuloSelec.Categoria.idCategoria = 3;
                    }
                    if (comboBoxCategoria.Text == "Audio")
                    {
                        articuloSelec.Categoria.idCategoria = 4;
                    }

                    articuloSelec.Marca = new Marca();
                    if (comboBoxMarca.Text == "Samsung")
                    {
                        articuloSelec.Marca.idMarca = 1;
                    }
                    if (comboBoxMarca.Text == "Apple")
                    {
                        articuloSelec.Marca.idMarca = 2;
                    }
                    if (comboBoxMarca.Text == "Sony")
                    {
                        articuloSelec.Marca.idMarca = 3;
                    }
                    if (comboBoxMarca.Text == "Huawei")
                    {
                        articuloSelec.Marca.idMarca = 4;
                    }
                    if (comboBoxMarca.Text == "Motorola")
                    {
                        articuloSelec.Marca.idMarca = 5;
                    }
                    


                    articuloSelec.imagen = new Imagen();



                    articuloSelec.imagen.idArticulo = negocio.TraerUltimoId();
                    articuloSelec.imagen.url = textBoxDescripcion.Text;
                    articuloSelec.Precio = decimal.Parse(textBoxPrecio.Text);

                    if (articuloSelec.Id != 0)
                    {
                        negocio.ModificarArticulo(articuloSelec);
                        MessageBox.Show("Modificado!");
                    }
                    else
                    {
                        articuloSelec.Id = negocio.TraerUltimoId();
                        negocio.agregarArticulo(articuloSelec);
                        MessageBox.Show("Agregado!");
                    }

                    Close();
                }
                else
                {
                    textBoxPrecio.BackColor = Color.Red;
                    textBoxNombre.BackColor = Color.Red;
                    textBoxCodArticulo.BackColor = Color.Red;
                    MessageBox.Show("Por favor cargue Nombre, Codigo y Precio", "ATENCION ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

             }



        

        private void textBoxUrlImagen_leave(object sender, EventArgs e)
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

        private void textBoxUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }
    }
   }


